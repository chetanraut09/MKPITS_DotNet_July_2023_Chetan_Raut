create table order1 (orderid int , custname varchar(50) , prodname varchar(50) , quantity int, orderdate date)

select *from order1

insert into order1 values(1,'chetan','tv',2,'2022-05-01')
insert into order1 values(2,'lucky','freez',3,'2023-12-12')
insert into order1 values(3,'rahul','mixer',5,'2001-02-27')
insert into order1 values(4,'akshay','sofa',9,'2012-12-23')

select prodname from order1 where orderdate between '2012-12-23' and '2023-12-12'



