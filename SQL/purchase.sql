
/*3- Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders. */  

create table purchase (ordno int,purchamt float,orddate date,customerid int,salesmanid int)

select *from purchase 

insert into purchase values(70001, 150.5, '2012-10-05',3005, 5002)
insert into purchase values( 70009 , 270.65,'2012-09-10',  3001, 5005)
insert into purchase values(70002, 65.26, '2012-10-05',  3002, 5001)
insert into purchase values(70004 ,110.5 , '2012-08-17', 3009, 5003)
insert into purchase values(70007, 948.5 ,'2012-09-10',   3005 , 5002)
insert into purchase values(70005, 2400.6 ,'2012-07-27',  3007, 5001)
insert into purchase values(70005, 2400.6,'2012-07-27 ', 3007 ,5001)

select orddate, salesmanid, ordno ,purchamt from purchase order by orddate, salesmanid, ordno ,purchamt