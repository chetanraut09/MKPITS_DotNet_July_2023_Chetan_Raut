create table stud3( rno int , name varchar(50), marks float  , grade varchar(20) , city varchar(50))

insert into stud3 values ( 11 , 'chetan', 99 , 'a' , 'nagpur' )
insert into stud3 values ( 12 , 'akshay', 98 , 'b' , 'masod' )
insert into stud3 values ( 13 , 'rahul', 66 , 'a' , 'kamthi' )
insert into stud3 values ( 14 , 'dhiraj', 77 , 'b' , 'kondhali' )
insert into stud3 values ( 15 , 'chirag', 55 , 'ac' , 'bajargao' )
insert into stud3 values ( 16 , 'rakesh', 90 , 'a' , 'dhurkheda' )

select * from stud3 

select * from stud3 where city='nagpur'

select max (marks) from (select * from stud3 where city='nagpur') as temp