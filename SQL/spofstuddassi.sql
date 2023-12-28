create table studd(id int , name varchar(60), rno int , city varchar (50) )

insert into studd values ( 1, 'chetan' , 12 , 'kondhali')
insert into studd values ( 2, 'raut' , 11 , 'nagpur')
insert into studd values ( 3, 'lucky' , 13 , 'nagpur')
insert into studd values ( 4, 'tambe' , 14 , 'kondhali')
insert into studd values ( 5, 'sujit' , 15 , 'kondhali')
insert into studd values ( 6, 'bhangar' , 16 , 'kondhali')
insert into studd values ( 7, 'devid' , 17, 'nagpur')
insert into studd values ( 8, 'kothe' , 18, 'kondhali')

select * from studd

create proc sp7
as
begin
select * from studd where rno>3 and rno<20
end 

exec sp7

drop table studd