create table store(store_id int identity primary key, store_name varchar(50),phone varchar(50), 
email varchar(50), street varchar(100) ,city varchar(100) ,state varchar(100)  , zip_code varchar(100) )

insert into store values ('mana','1234567890','mana@gmail.com','sadar','nagpur','maharastra','4400')
insert into store values ('dhanush','2234567890','d@gmail.com','sadar','nagpur','maharastra','4400')
insert into store (phone,email) values ('3222','ab@gmail.com')
insert into store (store_name,phone,email) values('radha','3222','ab@gmail.com')

select * from store

CREATE TABLE staffs (staff_id INT IDENTITY (1, 1) PRIMARY KEY,
                     first_name VARCHAR (50) NOT NULL, 
                     last_name VARCHAR (50) NOT NULL,
                     email VARCHAR (255)NOT NULL UNIQUE,
                     phone bigint ,
                     active int NOT NULL,
                     store_id INT NOT NULL,
                     manager_id INT,
                     FOREIGN KEY (store_id)  REFERENCES store (store_id),
                     FOREIGN KEY (manager_id)  REFERENCES staffs (staff_id)   )

	insert into staffs values('chetan','raut','rautchetan866@gmail.com','8669775843',28, 1, 1)
	insert into staffs values('chetan','raut','chetan866@gmail.com','866934543',20, 1, 2)

	select * from staffs
	select * from store

	CREATE TABLE categories (
	category_id INT IDENTITY (1, 1) PRIMARY KEY,
	category_name VARCHAR (255) NOT NULL)

	insert into categories values ( 'hondacity')

	
CREATE TABLE brands (
	brand_id INT IDENTITY (1, 1) PRIMARY KEY,
	brand_name VARCHAR (255) NOT NULl)

	insert into brands values( 'splender')

	CREATE TABLE products8(
	product_id INT IDENTITY (1, 1) PRIMARY KEY,
	product_name VARCHAR (255) NOT NULL,
	brand_id INT NOT NULL,
	category_id INT NOT NULL,
	model_year SMALLINT NOT NULL,
	list_price DECIMAL (10, 2) NOT NULL,
	FOREIGN KEY (category_id) 
        REFERENCES categories (category_id) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (brand_id) 
        REFERENCES brands (brand_id) 
        ON DELETE CASCADE ON UPDATE CASCADE)

		insert into products8 values ( 'bawasir', 1 ,1,2001, 123)
		insert into products8 values ( 'loosee motion', 1, 2,2001, 123)
    	insert into products8 values ( 'kutubminar', 1 ,2,2001, 123)

		CREATE TABLE sale_scustomers1 (
	customer_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (255) NOT NULL,
	last_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25),
	email VARCHAR (255) NOT NULL,
	street VARCHAR (255),
	city VARCHAR (50),
	statee VARCHAR (25), 
	zip_code VARCHAR (6))

	insert into sale_scustomers1 values ( 'lucky','tambe', '0987654321','luckytambe@gmail.com','nandnavan','bhopal','maharastra','44110')
	insert into sale_scustomers1 values ( 'chetant','titu' ,'1234567' )   

	
	select * from categories 
	select * from staffs
	select * from store
	select * from brands
	select * from products8
		select * from sale_scustomers1
	
	drop table sale_scustomers1