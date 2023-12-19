create table persons_skills(id int identity primary key , person_id int , skill_id int , update_at datetime, unique (person_id,skill_id) )

insert into persons_skills values (111,10,'2001-12-5')
insert into persons_skills values (112,10,'2001-12-5')
insert into persons_skills values (113,10,'2001-12-5')
insert into persons_skills values (114,10,'2001-12-5')

select * from persons_skills