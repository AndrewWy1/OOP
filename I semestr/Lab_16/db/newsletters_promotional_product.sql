CREATE DATABASE newsletters_promotional_product
GO

USE newsletters_promotional_product

CREATE TABLE country
(
	country_id SMALLINT PRIMARY KEY,
	country_name NVARCHAR(40) NOT NUll
)
CREATE TABLE interested_section
(
	section_id SMALLINT PRIMARY KEY,
	section_name NVARCHAR(50) NOT NULL
)
CREATE TABLE promotional_product
(
	product_id SMALLINT PRIMARY KEY,
	product_name NVARCHAR(50) NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,
)
GO

USE newsletters_promotional_product

CREATE TABLE town
(
	town_id SMALLINT PRIMARY KEY,
	town_name NVARCHAR(40) NOT NULL,
	country_id SMALLINT NOT NULL

	FOREIGN KEY (country_id) REFERENCES country (country_id)
)
GO

USE newsletters_promotional_product

CREATE TABLE buyer
(
	buyer_id SMALLINT PRIMARY KEY,
	first_name NVARCHAR(20) NOT NULL,
	last_name NVARCHAR(30) NOT NULL,
	birthdate DATE NOT NULL,
	sex NVARCHAR(1) NOT NULL,
	email NVARCHAR(50) NOT NULL,
	country_id SMALLINT NOT NULL,
	town_id SMALLINT NOT NULL

	FOREIGN KEY (country_id) REFERENCES country (country_id),
	FOREIGN KEY (town_id) REFERENCES town (town_id)
)
GO

USE newsletters_promotional_product

CREATE TABLE share_for_buyer
(
	share_id SMALLINT PRIMARY KEY,
	buyer_id SMALLINT NOT NULL,
	section_id SMALLINT NOT NULL,
	product_id SMALLINT NOT NULL,
	country_id SMALLINT NOT NULL,

	FOREIGN KEY (buyer_id) REFERENCES buyer (buyer_id),
	FOREIGN KEY (section_id) REFERENCES interested_section (section_id),
	FOREIGN KEY (product_id) REFERENCES promotional_product (product_id),
	FOREIGN KEY (country_id) REFERENCES country (country_id)
)
GO