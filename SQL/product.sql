create table product(productid int , productname varchar(50),price int, quantity int)

select * from product

insert into product values(5,'indian oil', 200, 10)
insert into product values(3, 'hp laptop',50000,2)
insert into product values(6,'bat', 1000, 10)
insert into product values(12, 'book',50,22)
insert into product values(51,'pencil', 20, 10)
insert into product values(13, 'bag',5000,13)
insert into product values(5,'balls', 200, 10)
insert into product values(3, 'hoodies',7000,2)
insert into product values(5,'keyboard', 20000, 10)
insert into product values(3, 'mouse',50000,12)

select top 2 * from product order by quantity desc

