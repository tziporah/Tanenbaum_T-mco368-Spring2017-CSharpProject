USE [TziporahStore]
GO
/****** Object:  Trigger [dbo].[updateAccount]    Script Date: 7/25/2017 12:52:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[updateAccount]
	ON [dbo].[Purchase]
	instead of INSERT
AS
BEGIN
	declare @custNum int
	declare @price decimal(4,2)
	declare @qty decimal;--how many were ordered
	declare @total decimal(6,2)--total charge for this purchase
	
	begin
		select @price = price from inserted
		select @qty = quantity from inserted
		set @total = @qty * @price --how much will be owed for this order

		--verify can make this purchase. Users cannot owe more than $500
		declare @balance decimal(8,2)
		declare @projectedBalance decimal(8,2)
		select @custNum = custID from inserted
		select @balance = balance from Account where userID = @custNum
		set @projectedBalance = @balance + @total
		if @projectedBalance > 500
			begin
				raiserror('insufficient credit',10,1)
				return
			end
		--now update customer balance to reflect this order
		declare @item int
		select @item = itemNo from inserted
		declare @date datetime
		select @date = purchaseDate from inserted
		insert into Purchase(custID, itemNo, quantity, purchaseDate, price) 
		values (@custNum, @item, @qty, @date, @total)

		update Account
			set balance = balance + @total where userID = @custNum
		
		
	end
	
END
