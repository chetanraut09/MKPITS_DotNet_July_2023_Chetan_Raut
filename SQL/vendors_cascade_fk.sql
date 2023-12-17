
create table vendors_group1(group_id int identity primary key, group_name varchar(50) not null)

create table vendors1(vendor_id int , vendors_name varchar(50), quamtity int, constraint fk foreign key(vendor_id) references vendors_group1(group_id) on delete cascade )

insert into vendors_group1 values('chetan')
insert into  vendors_group1 values('lucky')
insert into  vendors_group1 values('sujit')

insert into vendors1 values(1, 'shampoo', 5)
insert into vendors1 values(1, 'soap' , 7)
insert into vendors1 values (2, 'buiscuits',1)
insert into vendors1 values(2, 'soap' , 7)
insert into vendors1 values (3, 'buiscuits',1)
insert into vendors1 values(3, 'soap' , 7)
insert into vendors1 values (3, 'buiscuits',1)

delete from vendors_group1 where group_id = 3

select *from vendors_group1
select *from vendors1

drop table vendors1
drop table vendors_group1

