create table sales (id int , name varchar(50), salesamount int ,)

insert into sales values (1, 'chetan', 5000)
insert into sales values (1, 'raut', 500)
insert into sales values (1, 'lucky', 1000)
insert into sales values (1, 'tambe', 4000)
insert into sales values (1, 'sujit', 3000)
insert into sales values (1, 'khangar', 15000)

create proc sp10
as
begin
select * from sales where salesamount > 1000 and salesamount<10000
end

exec sp10 