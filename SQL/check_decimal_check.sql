create table product1 (product_id int identity primary key , product_name varchar(100) not null , unit_price dec(10,2) check(unit_price>0))
/*we used check and dec(10,2) for storing tha data thata alows only ten digits and two no. after decimal point*/

insert into product1 values('chetan',222)
insert into product1 values ('lucky',111)

select * from product1


create table result (rno int primary key , marks int check (marks>0))

insert into result values (12,0)
insert into result values (2,99)

select * from result

drop table result
