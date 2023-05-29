Create database [Stores_and_Orders]
Go

Use [Stores_and_Orders]
Go

Create table [County]
(
	[Id] int IDENTITY(1, 1) not null,
	[Country_name] nvarchar(100) not null, 
	
	Constraint [Primary_key_Country] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],
	
	Constraint [Unique_Values_Country] Unique ([Country_name]),
)
Go

Create table [City]
(
	[Id] int IDENTITY(1, 1) not null,
	[Postal_code] nvarchar(100) not null, 
	[City_name] nvarchar(100) not null,
	[Country_Id] int not null,
	
	Constraint [Primary_key_City] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],
	
	Constraint [Unique_Values_City] Unique ([Postal_code], [City_name]),

	Constraint [Foreign_ket_to_Country_from_City] Foreign key ([Country_Id]) references [County]([Id])
)
Go

Create table [Bottles]
(
	[Id] int IDENTITY(1, 1) not null,
	[Full_name] nvarchar(100) not null, 
	[Category_Id] int not null,
	[Label] nvarchar(100) null default N'Base Label!',
	[Volume] decimal(5, 2) not null,
	[Producer_Id] int not null,
	[Year_Produced] int not null,
	[Alcohol_Percentage] decimal(5, 2) not null,
	[Current_Price] decimal(8, 2) not null,

	
	Constraint [Primary_key_Bottles] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	--Constraint [Foreign_ket_to_Category_from_Bottles] Foreign key ([Category_Id]) references [Category]([Id]),

	--Constraint [Foreign_ket_to_Produces_from_Bottles] Foreign key ([Producer_Id]) references [Producer]([Id]),

	Constraint [Unique_Values_Bottles] Unique ([Full_name], [Producer_Id])
)
Go

Create table [Store]
(
	[Id] int IDENTITY(1, 1) not null,
	[Store_name] nvarchar(100) not null,
	[City_Id] int not null,
	[Address] nvarchar(100) not null,
	[Mobile] nvarchar(100) not null,
	[Phone] nvarchar(100) not null,
	[Email] nvarchar(100) not null,
	[Details] nvarchar(max) null default N'Base Details!',

	Constraint [Primary_key_Store] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Unique_Values_Store] Unique ([Store_name], [City_Id]),

	Constraint [Foreign_ket_to_City_from_Store] Foreign key ([City_Id]) references [City]([Id])
)
Go

Create table [Inventory]
(
	[Id] int IDENTITY(1, 1) not null,
	[Store_Id] int not null,
	[Bottle_Id] int not null,
	[Quantity] int not null default 0,

	Constraint [Primary_key_Inventory] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Foreign_ket_to_Store_from_Inventory] Foreign key ([Store_Id]) references [Store]([Id]),

	Constraint [Foreign_ket_to_Bottle_from_Inventory] Foreign key ([Bottle_Id]) references [Bottles]([Id]),

	Constraint [Unique_Values_Inventory] Unique ([Store_Id], [Bottle_Id]),
)
Go

Create table [Supplier]
(
	[Id] int IDENTITY(1, 1) not null,
	[Supplier_name] nvarchar(100) not null,
	[Address] nvarchar(100) not null,
	[Mobile] nvarchar(100) null,
	[Phone] nvarchar(100) null,
	[Email] nvarchar(100) null,
	[Details] nvarchar(max) null default N'Base Details!',

	Constraint [Primary_key_Supplier] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],
	
	Constraint [Unique_Values_Supplier] Unique ([Supplier_name]),
)
Go

Create table [Employees]
(
	[Id] int IDENTITY(1, 1) not null,
	[First_name] nvarchar(100) not null,
	[Last_name] nvarchar(100) not null,
	[User_name] nvarchar(100) not null,
	[Password] nvarchar(100) not null,
	[Phone] nvarchar(100) null,
	[Email] nvarchar(100) null,
	[Created_at] datetime not null,
	[Active_is] bit not null,
	
	Constraint [Primary_key_Employees] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],
)
Go

Create table [Order_Main]
(
	[Id] int IDENTITY(1, 1) not null,
	[Order_number] nvarchar(64) not null,
	[Expected_delivery_Date] date not null,
	[Time_Placed] datetime not null,
	[Time_Canceled] datetime null,
	[Time_Deliverd] datetime null,
	[Supplier_Id] int not null,
	[Store_Id] int not null,
	[Employee_Id] int not null,
	[Order_Price] decimal(8,2) not null default null,

	Constraint [Primary_key_Order] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Foreign_ket_to_Supplier_from_Order_Main] Foreign key ([Supplier_Id]) references [Supplier]([Id]),

	Constraint [Foreign_ket_to_Employees_from_Order_Main] Foreign key ([Employee_Id]) references [Employees]([Id]),

	Constraint [Unique_Values_Order_Main] Unique ([Order_number]),
)
Go

Create table [Order_Item]
(
	[Id] int IDENTITY(1, 1) not null,
	[Order_Id] int not null,
	[Bottle_Id] int not null,
	[Quantity] int not null,
	[Order_Price] decimal (8,2) null,

	Constraint [Primary_key_Order_Item] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Foreign_ket_to_Order_Main_from_Order_Item] Foreign key ([Order_Id]) references [Order_Main]([Id]),

	Constraint [Foreign_ket_to_Bottel_from_Order_Item] Foreign key ([Bottle_Id]) references [Bottles]([Id]),
)
Go