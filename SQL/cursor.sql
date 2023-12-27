create table products ( product_id int , product_name varchar(50) , brand_id int , category_id int , model_yr int , list_price int  )

insert into products values ( 1 , 'soap', 9 ,11 ,2001, 50) 
insert into products values ( 2 , 'shampu', 8 ,12 ,2002, 77) 
insert into products values ( 3 , 'oil', 7 ,13 ,2003, 99) 
insert into products values ( 4 , 'laptop', 6 ,14 ,2004, 33) 
insert into products values ( 5 , 'mouse', 10 ,15 ,2005, 44) 

select * from products

declare
@product_name varchar(max),
@list_price int;

declare cursor_product2 cursor
for select 
        product_name ,
		list_price
		from products;

open cursor_product2 ;

FETCH NEXT FROM cursor_product2 INTO 
@product_name,
@list_price;

while @@FETCH_STATUS=0
    BEGIN
        PRINT @product_name + ' ' + CAST(@list_price AS varchar)
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name, 
            @list_price;
    END;


	close cursor_product2;

	deallocate cursor_product2;
