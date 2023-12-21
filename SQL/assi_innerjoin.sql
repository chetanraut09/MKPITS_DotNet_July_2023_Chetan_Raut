create table customer2( custid int, custname varchar(50), telno bigint)


insert into customer2 values(15, 'chetan', 8669775843)
insert into customer2 values( 14,'rahul', 9112005023)
insert into customer2 values(13, 'akshay', 0987654321)
insert into customer2 values( 16,'lucky', 1234567890)



create table orders (orderid int primary key,orderdate date,custid int,prodname varchar(50) ,qty varchar(50),rate int)

insert into orders values(1, '2001-12-12', 11,'suger' , '10kg', 100)
insert into orders values( 2,'2001-12-13', 12,'rice' , '10kg', 100)
insert into orders values( 3,'2001-12-14', 13,'oil' , '10kg', 100)
insert into orders values(4,'2001-12-15', 14,'weed' , '10kg', 100)
insert into orders values(5,'2001-12-16', 15,'segarate' , '10kg', 100)
insert into orders values( 6,'2001-12-17',16,'chillem' , '10kg', 100)
insert into orders values( 7,'2001-12-18', 17,'paper' , '10kg', 100)

select * from customer2
select * from orders

select orders.custid,orders.orderdate, orders.prodname, orders.rate, customer2.custname, customer2.telno 
from  customer2
inner join orders 
on orders.custid= customer2.custid



drop table orders
drop table customer2
