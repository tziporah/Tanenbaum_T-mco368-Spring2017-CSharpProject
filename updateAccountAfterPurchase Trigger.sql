use TziporahStore
go

CREATE TRIGGER [dbo].[updateAccount]
	ON [dbo].[Purchase]
	AFTER INSERT
AS
BEGIN
	declare @custNum int
	declare @price decimal(4,2)
	declare @qty decimal;--how many were ordered
	declare @total decimal(6,2)--total charge for this purchase
	if exists (select * from inserted)
	--a new record is being inserted into purchase
	begin
		select @price = price from inserted
		select @qty = quantity from inserted
		set @total = @qty * @price --how much will be owed for this order

		--verify can make this purchase. Users cannot owe more than $500
		declare @balance decimal(8,2)
		declare @projectedBalance decimal(8,2)
		select @custNum = custID from Purchase
		select @balance = balance from Account where userID = @custNum
		set @projectedBalance = @balance + @total
		if @projectedBalance > 500
			begin
				raiserror('insufficient credit',10,1)
				rollback transaction
			end
		--now update customer balance to reflect this order
		update Account
			set balance = balance + @total where userID = @custNum
	end
	if exists (select * from deleted)
	if not exists (select * from inserted)
	--a record is being deleted from purchase
	begin
		select @price = price from inserted
		select @qty = quantity from deleted
		set @total = @qty * @price
		--find which customer placed this order
		select @custNum = custID from Purchase
		--find the account of this customer
		update Account
		set balance = balance - @total where userID = @custNum
	end --end update
END
GO