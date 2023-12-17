create table order1(orderid int primary key, orddate date,custid int)

create table orderdetails(orderid int ,productname varchar(50), quantity int ,
constraint fk1 foreign key (orderid) references order1(orderid) on delete set null)

insert into order1 values(1,'2001-12-12',23)
insert into order1 values(2,'2001-12-11',12)

insert into orderdetails values(1,'mouse',3)
insert into orderdetails values(2,'keyboard',2)

select *from order1
select *from orderdetails

delete from order1 where orderid = 1


drop table order1
drop table orderdetails