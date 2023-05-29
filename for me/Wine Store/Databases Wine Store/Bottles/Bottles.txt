Create database [Bottles]
Go

Use [Bottles]
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

Create table [Region]
(
	[Id] int IDENTITY(1, 1) not null,
	[Region_name] nvarchar(100) not null,
	[Country_Id] int not null,
 	
	Constraint [Primary_key_Region] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Unique_Values_Region] Unique ([Region_name], [Country_Id]),

	Constraint [Foreign_ket_to_Country_from_Region] Foreign key ([Country_Id]) references [County]([Id])
)
Go

Create table [Producer]
(
	[Id] int IDENTITY(1, 1) not null,
	[Producer_name] nvarchar(100) not null, 
	[Region_Id] int not null,
	[Details] nvarchar(100) null default N'Base description!',

	Constraint [Primary_key_Producer] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],

	Constraint [Unique_Values_Producer] Unique ([Producer_name], [Region_Id]),

	Constraint [Foreign_ket_to_Region_from_Produces] Foreign key ([Region_Id]) references [Region]([Id])
)
Go

Create table [Category]
(
	[Id] int IDENTITY(1, 1) not null,
	[Category_name] nvarchar(100) not null, 
	
	Constraint [Primary_key_Category] Primary key Clustered([Id] ASC)
	with (Pad_index = off, Statistics_norecompute = off, Ignore_dup_key = off,
	allow_row_locks = on, allow_page_locks = on) on [Primary],
	
	Constraint [Unique_Values_Category] Unique ([Category_name]),
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

	Constraint [Foreign_ket_to_Category_from_Bottles] Foreign key ([Category_Id]) references [Category]([Id]),

	Constraint [Foreign_ket_to_Produces_from_Bottles] Foreign key ([Producer_Id]) references [Producer]([Id]),

	Constraint [Unique_Values_Bottles] Unique ([Full_name], [Producer_Id])
)
Go


