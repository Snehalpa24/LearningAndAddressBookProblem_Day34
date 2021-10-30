create table employee_payroll
(id int IDENTITY(1,1),name varchar(30),salary int,startDate date,PRIMARY KEY (id));



insert into employee_payroll values
(
'Akshay',8000000,'15/10/2021'
);



insert into employee_payroll values
(
'Amol',9000000,'11/10/2020'
);



select * from employee_payroll;



select salary from employee_payroll where name='Akshay';



select * from employee_payroll 
where startDate='11/10/2010';




alter table employee_payroll add gender varchar(10);


update employee_payroll set gender='M' where name='Amol';



select count(gender) from employee_payroll where gender='M' group by gender;



select avg(salary) from employee_payroll;



alter table employee_payroll 
add phone int,address varchar(20),dept varchar(20);



alter table employee_payroll 
add basicPay int,deduction int,taxablePat int,incomeTax int,netPay int;



create table employee_department(empId int,deptId int);



insert into employee_department values
(1,10);



insert into employee_department values
(2,20);



select * from employee_department;



select count(empId) from employee_department;
