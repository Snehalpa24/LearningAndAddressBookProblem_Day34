create table AddressBook
(fname varchar(20),lname varchar(20),address varchar(20),city varchar(20),state varchar(20),zip int,phone int);

insert into AddressBook
values
('Snehal','Patil','Sivam Residency','Pune','Maharashtra',412101,9823023518)

update AddressBook set phone=897587125
where fname='Snehal';

delete AddressBook where fname='Snehal';

select * from AddressBook where city='Pune' or state='Goa';

select count(city) cityCount,count(state) stateCount from AddressBook;

select * from AddressBook where city='Pune' order by fname;

alter table AddressBook 
add type varchar(20) default 'NA',name varchar(20) default 'NA';

select count(type) from AddressBook;

update AddressBook set type='Family' where fname='Snehal';

select * from AddressBook;
