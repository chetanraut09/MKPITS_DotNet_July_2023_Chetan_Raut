create table productss ( product_id int , product_name2 varchar(50) , brand_id int , category_id int , model_yr int , list_price2 int  )

insert into productss values ( 1 , 'soap', 9 ,11 ,2001, 50) 
insert into productss values ( 2 , 'shampu', 8 ,12 ,2002, 77) 
insert into productss values ( 3 , 'oil', 7 ,13 ,2003, 99) 
insert into productss values ( 4 , 'laptop', 6 ,14 ,2004, 33) 
insert into productss values ( 5 , 'mouse', 10 ,15 ,2005, 44) 

select * from productss

DECLARE 
    @product_name2 VARCHAR(MAX), 
    @list_price2   DECIMAL;

DECLARE cursor_product2 CURSOR
FOR SELECT 
        product_name, 
        list_price
    FROM 
        productss;

OPEN cursor_product2;

FETCH NEXT FROM cursor_product2 INTO 
    @product_name2, 
    @list_price2;
PRINT @product_name2 + CAST(@list_price2 AS varchar);
WHILE @@FETCH_STATUS = 0
    BEGIN
       
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name2, 
            @list_price2;
            
          PRINT @product_name2 + CAST(@list_price2 AS varchar);
    END;

CLOSE cursor_product2;

DEALLOCATE cursor_product2;


