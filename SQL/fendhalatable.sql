create table TableProductGSTDetails(Product_Gst_ID int primary key  , Gst_Detail_Name varchar(500),CGST decimal,SGST decimal, IGST decimal)

insert into TableProductGSTDetails values (1 ,'soap', 8.3, 9.3,3.3)
insert into TableProductGSTDetails values (2 ,'shampu', 8.5, 9.5,3.5)
insert into TableProductGSTDetails values (3 ,'singhade', 8.6, 9.7,3.8)


create table TableProductCategory (Product_Category_ID int  primary key, Product_Type_Name varchar(50), Product_Gst_ID  int foreign key (Product_Gst_ID) references  TableProductGSTDetails)


insert into TableProductCategory values (4 ,'oil', 1)
insert into TableProductCategory values (5 ,'salt', 2)
insert into TableProductCategory values (6 ,'dhaniya',3)

create table TableProduct (ProductlD int  primary key, ProductTypelD int, Product_Name varchar(500))

insert into TableProduct values ( 9 , 11 , 'oil')
insert into TableProduct values (8 , 22 , 'salt')
insert into TableProduct values ( 7 , 33 , 'dhaniya')


create table TableInvoiceDetails ( Invoice_details_id int  , 
Customer_name Varchar(500) ,
Customer_Contact varchar(50) ,
product_Category_ID int foreign key ( product_Category_ID ) references TableProductCategory ,
ProductlD int foreign key (ProductlD) references TableProduct, 
residential_type_ID int , 
Invoice_Date Datetime , 
Quantity Decimal, 
Price Decimal , 
CGST decimal ,
SGST decimal ,
IGST decimal, 
CGST_Value decimal ,
SGST_Value decimal ,
IGST_Value decimal, 
Total_Amount decimal )

insert into TableInvoiceDetails values( 1 , 'Lucky Tambe' , 4353 , 4 , 9 , 101 , '2023-10-11' , 20 , 500 , 5 , 6 , 7 , 80 , 90 , 100 , 500 )
insert into TableInvoiceDetails values( 2 , 'Akash Gautam' , 5353 , 5 , 8 , 102 , '2023-10-12' , 21 , 600 , 6 , 7 , 8 , 81 , 91 , 200 , 600 )
insert into TableInvoiceDetails values( 3 , 'Chetan raut' , 4353 , 6 , 7 , 103 , '2023-11-11' , 21 , 700 , 6 , 8 , 9 ,70 , 20 , 300 , 700 )


select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails