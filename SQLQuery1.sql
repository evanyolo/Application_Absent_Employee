create database UasVisprog;

use UasVisprog;

use UasVisprog
create table Admins (
username varchar(20),
passwords varchar(10)
);
insert into Admins (username, passwords) values
('admins', 'admin');

select * from admins



create table employee(
emp_ID char (6) primary key check (emp_ID like 'EM[0-9][0-9][0-9][0-9]'),
emp_Name varchar(20),
emp_phone varchar(20), 
emp_gender char(1),
emp_email text, 
dob date,
emp_role varchar(8)foreign key references salary (emp_role)
);



select *from employee;

--dengan juga employee
insert into employee(emp_ID, emp_Name, emp_phone, emp_gender, emp_email, dob, emp_role ) 
values
('EM0001', 'Sasuke', '62813648166', 'M', 'saske@gmail.com','2003/03/12', 'staff'),
('EM0002', 'Maki', '62815313212', 'F', 'maki@gmail.com','1993/03/12', 'manager');

select employee.emp_ID, employee.emp_Name, salary.emp_role, salary.many_salary
from employee 
inner join salary on employee.emp_role = salary.emp_role
where employee.emp_role = 'manager';


--salary nya di lakukan insert terlebih dahulu 
create table salary (
emp_role varchar(8)primary key,
many_salary int
);
insert into salary (emp_role, many_salary) values 
('staff', 2000000),('manager', 4000000);

select * from salary;

create table statusatt(
stat_ID int identity(1,1) primary key,
emp_ID char (6)foreign key references employee (emp_ID),
status_Emp varchar(10),
description text,
time_in datetime
);


INSERT INTO statusatt (emp_ID, status_Emp, description, time_in)
VALUES 
  ('EM0001', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:41:38', 121)),
  ('EM0002', 'Late', 'Wake up late', CONVERT(DATETIME, '2023-06-03 08:05:47', 121)),
  ('EM0003', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:56:02', 121)),
  ('EM0004', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:51:02', 121)),
  ('EM0005', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:52:37', 121)),
  ('EM0006', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:54:28', 121)),
  ('EM0007', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:36:27', 121)),
  ('EM0008', 'Ontime', '', CONVERT(DATETIME, '2023-06-03 07:56:30', 121)),
  ('EM0009', 'Late', 'Car accident', CONVERT(DATETIME, '2023-06-03 08:45:38', 121)),
  ('EM0010', 'NotPresent', '', CONVERT(DATETIME, '2023-06-03 ', 121)),
  ('EM0011', 'Permission', 'Have a flu and I went to the hospital', CONVERT(DATETIME, '2023-06-03', 121));


  select employee.emp_ID, statusatt.status_Emp, statusatt.description, statusatt.time_in from employee
  inner join statusatt on employee.emp_ID = statusatt.emp_ID;

delete from statusatt where emp_ID ='EM0006' or emp_ID ='EM0007' or emp_ID ='EM0008' or 
 emp_ID ='EM0009' or  emp_ID ='EM0010' or  emp_ID ='EM0011';

	select * from statusatt;
	


	drop table loans

select*from loans
create table loans (
loans_ID int identity(1,1) primary key, 
emp_ID char (6)foreign key references employee (emp_ID),
how_many int,
descs text
);

select *from loans

select * from paymentloans

create table paymentloans(
payment_id int identity (1,1) primary key, 
loans_ID int foreign key references loans (loans_ID),
emp_ID char (6)foreign key references employee (emp_ID),
total int,
date_pay datetime
);




