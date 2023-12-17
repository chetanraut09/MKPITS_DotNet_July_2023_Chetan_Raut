create table vendors_group(group_id int identity primary key, group_name varchar(50) not null)


create table vendors ( vendor_id INT IDENTITY PRIMARY KEY, vendor_name VARCHAR(100) NOT NULL, group_id INT NOT NULL)

select * from vendors_group

insert into vendors ( vendor_name , group_id ) values ( 'cheaten' , 1)

select * from vendors


       
       
       

