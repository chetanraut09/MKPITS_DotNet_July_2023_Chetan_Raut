create table ordersss (orderid int , custid int, orderdate date, productname varchar(20),qty int)

insert into ordersss values(1,1,'2022-2-2','mouse',5)
insert into ordersss values(1,2,'2022-2-2','keyboard',5)
insert into ordersss values(2,3,'2022-2-2','desktop',5)
insert into ordersss values(2,4,'2022-2-2','ram',5)
insert into ordersss values(3,3,'2022-2-2','laptop',5)
insert into ordersss values(4,3,'2022-1-2','mouse',5)
insert into ordersss values(5,4,'2022-2-2','mouse',5)
insert into ordersss values(6,4,'2022-2-2','ram',5)
insert into ordersss values(7,5,'2022-2-2','desktop',5)
insert into ordersss values(7,5,'2022-2-2','ram',5)



create table customers (customer_id int, first_name varchar(100),last_name varchar(100),phone bigint,email varchar(100),
 street varchar(100), city varchar(100), state varchar(100) , zip_code int)

 insert into customers values( 1, 'chetan', 'raut',8669775843,'rautchetan866@gmail.com','dhotiwada', 'kondhali', 'mh', 441103)
 insert into customers values( 2, 'rahul ', 'raut',123456789,'rautrahul6@gmail.com','kamthi', 'kondhali', 'mh', 441103)
 insert into customers values( 3, 'akshay', 'dhewle',3456789012,'akshaydhewle866@gmail.com','masod', 'kondhali', 'mh', 441103)
 insert into customers values( 4, 'lucky', 'tambe',09876543,'luckytambe866@gmail.com','pachpaoli', 'nagpur', 'mh', 441103)

 select * from ordersss 
 select * from customers
 
 select customer_id from customers where city='nagpur'

select * from ordersss
where custid in (select custid from customers where city='Kondhali')

select * from customers
select customer_id from customers where city='nagpur'
select * from ordersss

