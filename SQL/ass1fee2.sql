create table student9( rno int identity primary key, name varchar(50) ,email varchar(50), city varchar(50), course_id int)

insert into student9 values ( 'chetan', 'rautchetan866@gmail.com', 'nagpur', 11 )
insert into student9 values ( 'lucky', 'rautchetan866@gmail.com', 'bhopal', 22 )
insert into student9 values ( 'rohit', 'rautchetan866@gmail.com', 'mumbai', 33 )
insert into student9 values ( 'shubham', 'rautchetan866@gmail.com', 'delhi', 44 )
insert into student9 values ( 'himanshu', 'rautchetan866@gmail.com', 'delhi', 55 )
insert into student9 values ( 'devid', 'rautchetan866@gmail.com', 'mumbai', 66 )
insert into student9 values ( 'sarang', 'rautchetan866@gmail.com', 'delhi', 77 )
insert into student9 values ( 'rahul', 'rautchetan866@gmail.com', 'nagpur', 88 )
insert into student9 values ( 'nagya', 'rautchetan866@gmail.com', 'nagpur', 99 )
insert into student9 values ( 'garib', 'rautchetan866@gmail.com', 'bajargao', 00 )

select * from student9

create table fee2 ( feesid int,rno int,feesdate date,amount int,courseid int)

insert into fee2 values ( 12, 1, '2001-12-12', 50000,11)
insert into fee2 values ( 13, 1, '2001-12-12', 50000,22)
insert into fee2 values ( 21, 1, '2001-12-12', 50000,33)
insert into fee2 values ( 22, 1, '2001-12-12', 50000,44)
insert into fee2 values ( 23, 1, '2001-12-12', 50000,55)
insert into fee2 values ( 24, 1, '2001-12-12', 50000,66)
insert into fee2 values ( 43, 1, '2001-12-12', 50000,77)
insert into fee2 values ( 34, 1, '2001-12-12', 50000,88)
insert into fee2 values ( 35, 1, '2001-12-12', 50000,99)

select * from student9
select * from fee2

select * from fee2 
where courseid in( select course_id from student9 where city = 'mumbai')

