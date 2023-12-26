create table em1(empid int , empname nvarchar(50), phone bigint , email nvarchar(50), dates date )

create table em2( id int identity (1,1), eempid int , fname varchar(50), works nvarchar(50), dates date)

select * from em1
select * from em2

insert into em1 values ( 1 , 'Chetan jhtya' , 3636336 , '@gmail.com' , '2023-12-12')
insert into em1 values ( 2 , 'Chetan chomya' , 3636336 , '@gmail.com' , '2023-12-12')
insert into em1 values ( 3 , 'Chetan chondrya' , 3636336 , '@gmail.com' , '2023-12-12')

create trigger T11
 on em1
 after update
 as
 insert em2 (eempid ,fname , works , dates)
 select empid,empname,'Update' , GETDATE() from deleted

 update em1 set empname = 'Devid' where empid = 2

 drop table em1
 drop table em2