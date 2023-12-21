create table student5 ( id int identity primary key , admissiom_no int , first_name varchar(50),
last_name varchar(50), area varchar(50),city varchar(50) )

insert into student5 values (1234, 'chetan', 'raut', 'chatrapati','nagpur')
insert into student5 values (1235, 'lucky', 'tambe', 'pachpaoli','nagpur')
insert into student5 values (1236, 'sujit', 'khangar', 'bhandara','bhandara')
insert into student5 values (1237, 'sarang', 'prajapati', 'saoner','nagpur')
insert into student5 values (1238, 'akash', 'gaitam', 'dharchotli','mp')
insert into student5 values (1239, 'devid', 'kothe', 'mouda','nagpur')
insert into student5 values (1230, 'ms', 'dhoni', 'ranchi','up')
insert into student5 values (1231, 'virat ', 'kohli', 'noida','dillhi')



create table fees ( admission_no  varchar(50) not null , course varchar(50) not null, amount_paid int )

insert into fees values (1236, 'dotnet', 50000)
insert into fees values (1237, 'java', 70000)
insert into fees values (1238, 'c#', 60000)
insert into fees values (1239, 'c++', 40000)
insert into fees values (5555,'html',30000)

select * from fees
select * from student5

select student5.admissiom_no,student5.first_name, student5.last_name, fees.course,fees.amount_paid 
 from student5 cross join fees -- where student4.admissiom_no=fees.admission_no