create table percent1 (marks int, studname varchar(50),fees float)

select * from percent1

insert into percent1 values(77,'chetan',65000)
insert into percent1 values(99,'lucky',44000)
insert into percent1 values(55,'sujit',50000)
insert into percent1 values(88,'devid',99000)
insert into percent1 values(66,'akash',65000)

select top 40 percent * from percent1

select distinct marks from percent1 
																
drop table percent1