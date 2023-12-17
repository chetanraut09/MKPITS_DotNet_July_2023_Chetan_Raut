
create table custo (  customer_id int , cust_name varchar(50) ,  city  varchar(20)  , grade int , salesman_id  int )

select *from custo

insert into custo values( 3002 , 'Nick Rimando' , ' New York ',100, 5001)
insert into custo values (3007, 'Brad Davis' ,' New York',200 , 5001)
insert into custo values(3005 ,'Graham Zusi', 'California',200 ,  5002)
insert into custo values (3008,'Julian Green', 'London' , 300 ,5002) 
insert into custo values(3004,'Fabian Johnson','Paris ',300,5006)
insert into custo values(3009,'Geoff Cameron','Berlin',100 ,5003)
insert into custo values(3003,'Jzy Altidor','Moscow', 200 ,5007)      

select  customer_id, cust_name, grade, salesman_id  from custo where grade =200
drop table custo

      
     
        
      
