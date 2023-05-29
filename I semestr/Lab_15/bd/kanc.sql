CREATE DATABASE stationery
GO

USE stationery

CREATE TABLE buyer_company
(
	buyer_id SMALLINT PRIMARY KEY,
	buyer_name NVARCHAR(30) NOT NULL
)

CREATE TABLE stationery_type
(
	stationery_type NVARCHAR(50) PRIMARY KEY,
	count_stationery_type INT NOT NULL
)

CREATE TABLE manager
(
	manager_id SMALLINT PRIMARY KEY,
	first_name NVARCHAR(20) NOT NULL,
	last_name NVARCHAR(30) NOT NULL
)
GO

USE stationery
CREATE TABLE stationery_goods
(
	stationery_id SMALLINT PRIMARY KEY,
	stationery_name NVARCHAR(50) NOT NULL,
	stationery_type NVARCHAR(50) NOT NULL,
	cost MONEY NOT NULL,
	
	FOREIGN KEY (stationery_type) REFERENCES stationery_type(stationery_type)
)
GO

USE stationery
CREATE TABLE agreement
(
	agreement_id SMALLINT PRIMARY KEY,
	manager_id SMALLINT NOT NULL,
	buyer_id SMALLINT NOT NULL,
	stationery_id SMALLINT NOT NULL,
	price MONEY NOT NULL,
	date_sele DATE NOT NULL,
	count_sele_goods INT NOT NULL,

	FOREIGN KEY (manager_id) REFERENCES manager (manager_id),
	FOREIGN KEY (buyer_id) REFERENCES buyer_company (buyer_id),
	FOREIGN KEY (stationery_id) REFERENCES stationery_goods (stationery_id)
)
GO