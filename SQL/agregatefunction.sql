create table employi (id int, name varchar(50), dep_id int, salary int)

insert into employi values( 1, 'devid', 11, 50000)
insert into employi values( 2, 'chetan', 22, 60000)
insert into employi values( 3, 'lucky', 12, 20000)
insert into employi values( 4, 'sujit', 13, 12000)
insert into employi values( 5, 'sarang', 33, 520000)
insert into employi values( 6, 'akash', 44, 501000)

select * from employi

select sum(salary) from employi 