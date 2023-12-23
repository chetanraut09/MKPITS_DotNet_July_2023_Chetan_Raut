create table salesmen(id int , name varchar(50), city varchar(50), commision float)

insert into salesmen values (5001 , 'James Hoog',  'New York' ,   0.15 )
insert into salesmen values (5002 , 'Nail Knite',  'Paris', 0.13 )
insert into salesmen values (5005 , 'Pit Alex', 'London' , 0.11)
insert into salesmen values (5006 , 'Mc Lyon','Paris' ,  0.14 )
insert into salesmen values (5003 , 'Lauson Hen' , 'San Jose', 0.12)
insert into salesmen values (5007 , 'Paul Adam' ,   'Rome' , 0.13)



create table ordr ( ordno int , purch_amt int , ord_date date , cust_id int, salesmen_id int )

insert into ordr values(70001,150.5,'2012-10-05' , 3005,5002)
insert into ordr values(70009, 270.65 ,'2012-09-10',  3001,5005)
insert into ordr values(70002, 65.26, '2012-10-05' ,3002 , 5001)
insert into ordr values(70004,110.5,'2012-08-17' , 3009,5003)
insert into ordr values(70007,948.5,'2012-09-10',  3005,5002)
insert into ordr values(70005,2400.6,'2012-07-27',  3007,5001)
insert into ordr values(70008,5760,'2012-09-10',3002,5001)

select * from salesmen
select * from ordr 

SELECT *
FROM ordr
WHERE salesmen_id =
    (SELECT salesmen_id 
     FROM salesmen 
     WHERE name='Paul Adam');
