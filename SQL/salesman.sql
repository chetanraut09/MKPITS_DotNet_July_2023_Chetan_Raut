/*1 -Write a SQL statement to display all the information of all salesmen. */  

create table salesman ( salesman_id int ,name varchar(50) , city varchar(50), commission float)

select *from salesman

insert into salesman values(123, 'chetan', 'kondhali', 0.12)
insert into salesman values(124, 'sarang', 'nagpur', 0.87)
insert into salesman values(432, 'lucky', 'bajargao', 0.34)
insert into salesman values(12433, 'sujit', 'masod', 0.55)
insert into salesman values(454, 'rahul', 'jagdo', 0.99)
insert into salesman values(23, 'shubham', 'dharchotli', 0.66)

select name, city from salesman 

       