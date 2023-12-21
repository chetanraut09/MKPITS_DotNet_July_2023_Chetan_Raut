create table customer3( custid int, custname varchar(50), telno bigint)


insert into customer3 values(15, 'chetan', 8669775843)
insert into customer3 values( 14,'rahul', 9112005023)
insert into customer3 values(13, 'akshay', 0987654321)
insert into customer3 values( 16,'lucky', 1234567890)



create table orderss (orderid int primary key,orderdate date,custid int,prodname varchar(50) ,qty varchar(50),rate int)

insert into orderss values(1, '2001-12-12', 11,'suger' , '10kg', 100)
insert into orderss values( 2,'2001-12-13', 12,'rice' , '10kg', 100)
insert into orderss values( 3,'2001-12-14', 13,'oil' , '10kg', 100)
insert into orderss values(4,'2001-12-15', 14,'weed' , '10kg', 100)
insert into orderss values(5,'2001-12-16', 15,'segarate' , '10kg', 100)
insert into orderss values( 6,'2001-12-17',16,'chillem' , '10kg', 100)
insert into orderss values( 7,'2001-12-18', 17,'paper' , '10kg', 100)

select * from customer3
select * from orderss

select orderss.custid,orderss.orderdate, orderss.prodname, orderss.rate, customer3.custname, customer3.telno 
from  customer3
right outer join orderss 
on orderss.custid= customer3.custid


