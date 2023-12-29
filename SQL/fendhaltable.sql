create table TableNation(NationID int primary key , NationName  varchar(500))

insert into TableNation values( 1 , 'India')
insert into TableNation values( 2 , 'India')
insert into TableNation values( 3 , 'India')

----------------------------------------------------

create table TableState (StatelD int primary key , NationID int foreign key (NationID) references TableNation ,StateName varchar(50))

insert into TableState values ( 4 , 1 , 'maharashtra' )
insert into TableState values ( 5 , 2 , 'mp' )
insert into TableState values ( 6 , 3 , 'up' )

--------------------------------------------------

create table TableCity (CitylD int , StatelD int foreign key (StatelD) references TableState (StatelD) , CityName varchar(50))

insert into TableCity values ( 11 , 4 , 'nagpur' )
insert into TableCity values ( 12 , 5 , 'pachapaoli' )
insert into TableCity values ( 13 , 6 , 'hingna' )

--------------------------------------------------------

create table TableCourseRegDetail (CourseRegiD int primary key, Categorylnd int , FullName varchar(500), Genderlnd int)

insert into TableCourseRegDetail values (22 , 99 , 'chetan raut', 80 )
insert into TableCourseRegDetail values (33 , 88 , 'lucky  tambus', 90 )
insert into TableCourseRegDetail values (44 , 77 , 'sujit bhangar', 70 )

--------------------------------------------------------

create table TableRegAddress ( RegAddresslD int  ,CourseRegiD int foreign key(CourseRegiD) references TableCourseRegDetail ,
NationlD int foreign key (NationlD) references TableNation , StatelD  int ,CitylD int)

insert into TableRegAddress values ( 111 , 22 ,1, 4,11 )
insert into TableRegAddress values ( 222 , 33 ,2, 5,12 )
insert into TableRegAddress values ( 333 , 44 ,3, 6,13 )

----------------------------------------------------------------------

create table TableFeeDetail (FeelD int ,CourseReglD int foreign key (CourseReglD) references TableCourseRegDetail , TotalAmount decimal, MinPer decimal,
PaidAmount decimal,BalAmount decimal, PaidDate datetime)

insert into TableFeeDetail values ( 444, 22, 50000 , 80.80 , 25000 , 25000 , '2001-12-12')
insert into TableFeeDetail values ( 555, 33, 60000 , 70.80 , 30000 , 30000 , '2001-12-22')
insert into TableFeeDetail values ( 666, 44, 70000 , 50.80 , 35000 , 35000 , '2001-12-12')

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail

drop table TableNation
drop table TableState
drop table TableCity
drop table TableCourseRegDetail
drop table TableFeeDetail
drop table TableRegAddress


