create table product3(product_id int primary key, product_name varchar(100), unit_price  dec(10,2) constraint pd check (unit_price>0))

insert into product3 values(1,'honda', 90000)
insert into product3 values(1,'another awsom bike', null)

select * from product3