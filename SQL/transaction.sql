    CREATE TABLE Product1 (  
     Product_id INT PRIMARY KEY,   
     Product_name VARCHAR(40),   
     Price INT,  
     Quantity INT  
    )  

	INSERT INTO Product1 VALUES(111, 'Mobile', 10000, 10),  
    (112, 'Laptop', 20000, 15),  
    (113, 'Mouse', 300, 20),  
    (114, 'Hard Disk', 4000, 25),  
    (115, 'Speaker', 3000, 20);  

	select * from product1

	begin transaction 
	insert into product1 values (111, 'Mobile', 10000, 10)
	     UPDATE Product1 SET Price = 450 WHERE Product_id = 111
		     COMMIT TRANSACTION  
