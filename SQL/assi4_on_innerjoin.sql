create table studdd(id int primary key , name varchar(60), rno int , city varchar (50) )

insert into studdd values ( 1, 'chetan' , 12 , 'kondhali')
insert into studdd values ( 2, 'raut' , 11 , 'nagpur')
insert into studdd values ( 3, 'lucky' , 13 , 'nagpur')
insert into studdd values ( 4, 'tambe' , 14 , 'kondhali')
insert into studdd values ( 5, 'sujit' , 15 , 'kondhali')
insert into studdd values ( 6, 'bhangar' , 16 , 'kondhali')
insert into studdd values ( 7, 'devid' , 17, 'nagpur')
insert into studdd values ( 8, 'kothe' , 18, 'kondhali')

create table feesss ( id int ,   feess int , rno int )

insert into feesss values ( 22 , 25000 , 12)
insert into feesss values ( 23 , 25000 , 16)
insert into feesss values ( 24 , 25000 , 17)
insert into feesss values ( 25 , 25000 , 13)

select * from studdd
select * from feesss


create proc sp6
as
begin
select *from studdd inner join feesss on 
studdd.rno=feesss.rno
end 

exec sp6
