create table fees (rno int ,name varchar(50) , course varchar(50), amount int , paiddate date)

select *from fees

insert into fees values(1,'chetann', 'dotnet', 65000,'2023-05-01')
insert into fees values(2,'lucky', 'java', 65000, '2023-06-01')
insert into fees values(3,'sarang', 'dotnet', 65000, '2023-09-01')
insert into fees values(4,'sujit', 'fulastacck', 65000, '2023-09-11')
insert into fees values(5,'devid', 'sql', 65000, '2023-09-12')
insert into fees values(6,'akash', 'html', 65000, '2023-09-4')
insert into fees values(7,'mrunal', 'css', 65000, '2023-09-22')
insert into fees values(8,'trishala', 'js', 65000, '2023-09-23')
insert into fees values(9,'reeta', 'python', 65000, '2023-09-31')
insert into fees values(10,'mayuri', 'oops', 65000, '2023-09-25')

select paiddate from fees where paiddate between '2023-09-01' and '2023-09-25'

select * from fees where rno in (3,4,5)

select * from fees where name like '%sh%'
drop table fees 