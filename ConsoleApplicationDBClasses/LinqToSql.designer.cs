﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplicationDBClasses
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TziporahStore")]
	public partial class LinqToSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertPurchase(Purchase instance);
    partial void UpdatePurchase(Purchase instance);
    partial void DeletePurchase(Purchase instance);
    #endregion
		
		public LinqToSqlDataContext() : 
				base(global::ConsoleApplicationDBClasses.Properties.Settings.Default.TziporahStoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Purchase> Purchases
		{
			get
			{
				return this.GetTable<Purchase>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _accountID;
		
		private int _userID;
		
		private decimal _balance;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnaccountIDChanging(int value);
    partial void OnaccountIDChanged();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnbalanceChanging(decimal value);
    partial void OnbalanceChanged();
    #endregion
		
		public Account()
		{
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accountID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int accountID
		{
			get
			{
				return this._accountID;
			}
			set
			{
				if ((this._accountID != value))
				{
					this.OnaccountIDChanging(value);
					this.SendPropertyChanging();
					this._accountID = value;
					this.SendPropertyChanged("accountID");
					this.OnaccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL")]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="Decimal(8,2) NOT NULL")]
		public decimal balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Account", Storage="_Customer", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _firstName;
		
		private string _lastName;
		
		private decimal _creditCard;
		
		private int _houseNum;
		
		private string _street;
		
		private string _city;
		
		private string _usState;
		
		private string _zip;
		
		private decimal _phone;
		
		private string _username;
		
		private string _aPassword;
		
		private EntitySet<Account> _Accounts;
		
		private EntitySet<Purchase> _Purchases;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OncreditCardChanging(decimal value);
    partial void OncreditCardChanged();
    partial void OnhouseNumChanging(int value);
    partial void OnhouseNumChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnusStateChanging(string value);
    partial void OnusStateChanged();
    partial void OnzipChanging(string value);
    partial void OnzipChanged();
    partial void OnphoneChanging(decimal value);
    partial void OnphoneChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnaPasswordChanging(string value);
    partial void OnaPasswordChanged();
    #endregion
		
		public Customer()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creditCard", DbType="Decimal(16,0) NOT NULL")]
		public decimal creditCard
		{
			get
			{
				return this._creditCard;
			}
			set
			{
				if ((this._creditCard != value))
				{
					this.OncreditCardChanging(value);
					this.SendPropertyChanging();
					this._creditCard = value;
					this.SendPropertyChanged("creditCard");
					this.OncreditCardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_houseNum", DbType="Int NOT NULL")]
		public int houseNum
		{
			get
			{
				return this._houseNum;
			}
			set
			{
				if ((this._houseNum != value))
				{
					this.OnhouseNumChanging(value);
					this.SendPropertyChanging();
					this._houseNum = value;
					this.SendPropertyChanged("houseNum");
					this.OnhouseNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usState", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string usState
		{
			get
			{
				return this._usState;
			}
			set
			{
				if ((this._usState != value))
				{
					this.OnusStateChanging(value);
					this.SendPropertyChanging();
					this._usState = value;
					this.SendPropertyChanged("usState");
					this.OnusStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zip", DbType="NVarChar(9) NOT NULL", CanBeNull=false)]
		public string zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if ((this._zip != value))
				{
					this.OnzipChanging(value);
					this.SendPropertyChanging();
					this._zip = value;
					this.SendPropertyChanged("zip");
					this.OnzipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="Decimal(10,0) NOT NULL")]
		public decimal phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aPassword", DbType="VarChar(20)")]
		public string aPassword
		{
			get
			{
				return this._aPassword;
			}
			set
			{
				if ((this._aPassword != value))
				{
					this.OnaPasswordChanging(value);
					this.SendPropertyChanging();
					this._aPassword = value;
					this.SendPropertyChanged("aPassword");
					this.OnaPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Account", Storage="_Accounts", ThisKey="userID", OtherKey="userID")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Purchase", Storage="_Purchases", ThisKey="userID", OtherKey="custID")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _itemID;
		
		private decimal _price;
		
		private string _descript;
		
		private EntitySet<Purchase> _Purchases;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnitemIDChanging(int value);
    partial void OnitemIDChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OndescriptChanging(string value);
    partial void OndescriptChanged();
    #endregion
		
		public Item()
		{
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int itemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((this._itemID != value))
				{
					this.OnitemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("itemID");
					this.OnitemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(4,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descript", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string descript
		{
			get
			{
				return this._descript;
			}
			set
			{
				if ((this._descript != value))
				{
					this.OndescriptChanging(value);
					this.SendPropertyChanging();
					this._descript = value;
					this.SendPropertyChanged("descript");
					this.OndescriptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase", Storage="_Purchases", ThisKey="itemID", OtherKey="itemNo")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchase")]
	public partial class Purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _purchaseID;
		
		private int _custID;
		
		private int _itemNo;
		
		private int _quantity;
		
		private System.DateTime _purchaseDate;
		
		private decimal _price;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Item> _Item;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpurchaseIDChanging(int value);
    partial void OnpurchaseIDChanged();
    partial void OncustIDChanging(int value);
    partial void OncustIDChanged();
    partial void OnitemNoChanging(int value);
    partial void OnitemNoChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnpurchaseDateChanging(System.DateTime value);
    partial void OnpurchaseDateChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public Purchase()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Item = default(EntityRef<Item>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int purchaseID
		{
			get
			{
				return this._purchaseID;
			}
			set
			{
				if ((this._purchaseID != value))
				{
					this.OnpurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._purchaseID = value;
					this.SendPropertyChanged("purchaseID");
					this.OnpurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_custID", DbType="Int NOT NULL")]
		public int custID
		{
			get
			{
				return this._custID;
			}
			set
			{
				if ((this._custID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncustIDChanging(value);
					this.SendPropertyChanging();
					this._custID = value;
					this.SendPropertyChanged("custID");
					this.OncustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemNo", DbType="Int NOT NULL")]
		public int itemNo
		{
			get
			{
				return this._itemNo;
			}
			set
			{
				if ((this._itemNo != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnitemNoChanging(value);
					this.SendPropertyChanging();
					this._itemNo = value;
					this.SendPropertyChanged("itemNo");
					this.OnitemNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaseDate", DbType="Date NOT NULL")]
		public System.DateTime purchaseDate
		{
			get
			{
				return this._purchaseDate;
			}
			set
			{
				if ((this._purchaseDate != value))
				{
					this.OnpurchaseDateChanging(value);
					this.SendPropertyChanging();
					this._purchaseDate = value;
					this.SendPropertyChanged("purchaseDate");
					this.OnpurchaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(6,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Purchase", Storage="_Customer", ThisKey="custID", OtherKey="userID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._custID = value.userID;
					}
					else
					{
						this._custID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase", Storage="_Item", ThisKey="itemNo", OtherKey="itemID", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._itemNo = value.itemID;
					}
					else
					{
						this._itemNo = default(int);
					}
					this.SendPropertyChanged("Item");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
