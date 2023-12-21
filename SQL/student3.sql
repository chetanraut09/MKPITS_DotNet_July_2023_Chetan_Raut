create table student3 ( id int identity primary key, name varchar(50) not null , roll_no int , fees int ,marks int ,city varchar(20), grade varchar(20))

insert into student3 values ( 'chetan', 12, 50000, 99,'nagpur','A')
insert into student3 values ( 'akshay', 13, 50000, 98,'dhotiwada ','B')
insert into student3 values ( 'chetan', 12, 50000, 55,'rautpura','C')

select *from student3 


alter table student3 
drop column grade 

drop table student3