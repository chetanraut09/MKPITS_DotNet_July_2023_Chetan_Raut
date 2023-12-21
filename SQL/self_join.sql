create table mmstudent ( id int identity primary key,first_name varchar(50),last_name varchar(50), city varchar(50))

insert into mmstudent values ( 'chetan', 'raut','nagpur')
insert into mmstudent values ( 'lucky', 'tambe','pachpaoli')
insert into mmstudent values ( 'devid ', 'kothe','mauda')
insert into mmstudent values ( 'sujit', 'khangar','bhandara')
insert into mmstudent values ( 'trishala', 'bhisikar','nagpur')

select * from mmstudent

select s1.first_name,s2.last_name,s2.city
     from mmstudent s1,mmstudent s2
     where s1.id <> s2.id 
     and s1.city=s2.city
     order by s2.city


