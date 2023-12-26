create table stud1( rno int , name varchar(50), marks float  , grade varchar(20) , city varchar(50))

insert into stud1 values ( 11 , 'chetan', 99 , 'a' , 'nagpur' )
insert into stud1 values ( 12 , 'akshay', 98 , 'b' , 'masod' )
insert into stud1 values ( 13 , 'rahul', 66 , 'a' , 'kamthi' )
insert into stud1 values ( 14 , 'dhiraj', 77 , 'b' , 'kondhali' )
insert into stud1 values ( 15 , 'chirag', 55 , 'ac' , 'bajargao' )
insert into stud1 values ( 16 , 'rakesh', 90 , 'a' , 'dhurkheda' )





select name,rno from stud1
where rno in (select rno stud1
where rno % 2 =0)