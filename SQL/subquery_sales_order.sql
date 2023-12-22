create table sales_order(order_id int identity primary key, customer_id int, order_status varchar(200), order_date date,
required_date date,shiped_date date,store_id int, staff_id int)

insert into sales_order values (11 , 'arriving', '2001-12-12','2005-12-22','2011-12-20',12,13)
insert into sales_order values (22 , 'arriving', '2002-12-12','2006-12-22','2012-12-20',99,98)
insert into sales_order values (33 , 'arriving', '2003-12-12','2007-12-22','2013-12-20',88,76)
insert into sales_order values (44 , 'arriving', '2004-12-12','2008-12-22','2014-12-20',77,67)
insert into sales_order values (55 , 'arriving', '2005-12-12','2009-12-22','2015-12-20',66,90)



 create table sales_customer (customer_id int, first_name varchar(100),last_name varchar(100),phone bigint,email varchar(100),
 street varchar(100), city varchar(100), state varchar(100) , zip_code int)

 insert into sales_customer values( 11, 'chetan', 'raut',8669775843,'rautchetan866@gmail.com','dhotiwada', 'kondhali', 'mh', 441103)
 insert into sales_customer values( 22, 'rahul ', 'raut',123456789,'rautrahul6@gmail.com','kamthi', 'kondhali', 'mh', 441103)
 insert into sales_customer values( 33, 'akshay', 'dhewle',3456789012,'akshaydhewle866@gmail.com','masod', 'kondhali', 'mh', 441103)
 insert into sales_customer values( 44, 'lucky', 'tambe',09876543,'luckytambe866@gmail.com','pachpaoli', 'nagpur', 'mh', 441103)

 select * from sales_order 
 select * from sales_customer 

 select order_id , order_date , customer_id from sales_order where customer_id 
 in( select customer_id from sales_customer where street='kamthi') order by order_date desc

 drop table sales_customer