create database Salon;

use Salon;

--Login Details Table
create table Login_Details
(Username varchar(50) primary key, 
L_Password varchar (10),
Confirm_Password varchar (10),
Email varchar(50));


insert into Login_Details values
--('admin', 'admin@123','admin@123','amashinayonika.98@gmail.com');
--('adminColombo', 'admin@456','admin@456','admincolombo@gmail.com'),
--('adminWattala', 'admin@789','admin@789','adminwattala@gmail.com');


--update Login_Details set L_Password='admin@123' ,Confirm_Password='admin@123'  
--where Username='admin';
--drop table Login_Details

select * from Login_Details


--Employee Table
create table Employee
(Employee_Id int primary key, 
Joining_Date date, 
FirstName varchar(30), 
LastName varchar(30),
Branch varchar(30), 
Telephone varchar(10), 
Email varchar(60), 
Date_of_Birth date, 
Designation varchar(30), 
Salary decimal(10,2),
Employee_Status varchar(20));


--insert query
insert into Employee values
--('1','2021-05-30','Amashi', 'Costa', 'Gampaha', '0772569019','amashinayonika.98@gmail.com', '1993-01-22','Manager',50000,'Active'),
--('2','2021-12-31','Sanduni', 'Wijesinghe', 'Wattala', '0783309019','sanduniw@gmail.com', '1994-11-22','Beautition',30000,'Active');


--select query
SELECT MAX(Employee_Id)+1 FROM Employee;

select Branch,Sum(Salary) as Branch_Total 
from Employee
where Employee_Status='Active'
group by Branch;

select Employee_Status, count(Employee_Id) as Employee_Count
from Employee
select * from Employee


--drop table
--drop table Employee





--Customer Table
create table Customer(
Customer_Id int primary key, 
FirstName varchar(30), 
LastName varchar(30),
Telephone varchar(10), 
Email varchar(60), 
Date_of_Birth date);

--Insert Query
insert into Customer values
--('500','Vishaka', 'Sandamali','0789569014','vishakas@gmail.com', '1998-01-22');

--Select Query
Select * from Customer;


--drop table Customer
delete from Customer where Customer_Id='510';





--Salon Services Table
create table Salon_Services(
Branch varchar(30),
Ser_Name varchar(30),
Ser_Category varchar(20), 
Duration_Minutes int , 
Ser_Charge int ,
primary key(Branch,Ser_Name));

--Insert Query For Salon_Services
insert into Salon_Services values

--('Gampaha','Straighting','Hair',60,10000),
--('Wattala','Straighting','Hair',60,10000),
--('Gampaha','Cleanup','Facial',30,2000);

--Select Query For Salon Services
Select * from Salon_Services;
Select * from Salon_Services
where Branch='Gampaha';

--drop table Salon_Services;
delete from Salon_Services where Branch='Gampaha'and Ser_name='Straighting';




--Appointment Table
Create table Appointment(Appointment_Id int primary key,
Customer_Id int,
Ser_Name varchar(30), 
Branch varchar(30), 
Appointment_Date date,
Start_Time time, 
End_Time time, 
Price int, 
Status_Update varchar(10));


--insert command of Appointment
insert into Appointment values
--('1','500','Cleanup','Gampaha', '2023-02-04', '10:00', '10:30',2000,'Paid'),


--Select Query for Appointment
SELECT *
FROM Appointment
WHERE Appointment_Date>='2023-02-01' and Appointment_Date <='2023-02-28';

Select Appointment_Date,Branch, Ser_Name, Start_Time,End_Time,Price,FirstName,LastName
from Appointment, Customer
where Appointment.Customer_Id=Customer.Customer_Id and Appointment_Id= 1;

Select * from Appointment;


SELECT Branch, count(*) as Branch_Booking FROM Appointment
WHERE Status_Update='Pending' AND MONTH(Appointment_Date) = MONTH( GETDATE())
GROUP BY Branch

SELECT * FROM Appointment
WHERE Status_Update='Pending' AND MONTH(Appointment_Date) = MONTH( GETDATE())


--Monthly Income chart
select year(Appointment_Date) as Appointment_Year,
DATENAME(Month,Appointment_Date) as Appointment_Month ,
sum(Price) as Monthly_Income from Appointment
where Status_Update='Paid'
group by year(Appointment_Date), DATENAME(MONTH,Appointment_Date) order by year(Appointment_Date);

--appointment count chart
select Branch,year(Appointment_Date) as Appointment_Year,
DATENAME(Month,Appointment_Date) as Appointment_Month,
count(*) as Monthly_Count from Appointment
where Status_Update='Paid'
group by Branch, year(Appointment_Date), DATENAME(MONTH,Appointment_Date) order by year(Appointment_Date);

--drop table Appointment



--Expenses Table
CREATE TABLE Expenses (
	Expense_Id int NOT NULL PRIMARY KEY,
    Expense_Type varchar(50) NOT NULL,
    Expense_Description varchar(255),
    Branch varchar(30),
	Expense_Date date,
	Amount decimal(20,2)
);

insert into Expenses values
--(1,'Rent','Gampaha Branch','Gampaha','2023-02-28',80000);
--(4,'Products','Shampoo, Facial Cream','Colombo','2023-02-28',10000),
--(5,'Salary & Wages','Total Salary','Wattala','2023-02-28',80000);
--(6,'Other','Bua a Broom','Wattala','2023-02-28',200);
--(7,'Equipments','Hair Dryer','Wattala','2023-03-01',1000);


--Select Query for Expenses
select year(Expense_Date) as Expense_Year,
DATENAME(Month,Expense_Date) as Expense_Month ,
Expense_Type,Branch,
sum(Amount) as Monthly_Total from Expenses
where Expense_Type='Salary & Wages'
group by year(Expense_Date), DATENAME(MONTH,Expense_Date),Expense_Type,Branch order by year(Expense_Date);

select * from Expenses


--Monthly Expenses table
select year(Expense_Date) as Expense_Year,
DATENAME(Month,Expense_Date) as Expense_Month ,
sum(Amount) as Monthly_Expenses from Expenses
group by year(Expense_Date), DATENAME(MONTH,Expense_Date) order by year(Expense_Date);

-- Appointments of the current Month
SELECT Branch, count(*) as branch_booking FROM Appointment
WHERE  MONTH(Appointment_Date) = MONTH( GETDATE())
GROUP BY Branch


Select year(Appointment_Date) as Yr,
DATENAME(Month,Appointment_Date) as Mon, sum(Price) as amt,
year(Expense_Date) as Yr,DATENAME(Month,Expense_Date) as Mon,
sum(Amount) as Ammount from Appointment full outer join Expenses
On Expenses.Branch = Appointment.Branch
where Status_Update='Paid'
group by year(Appointment_Date), DATENAME(MONTH,Appointment_Date) order by year(Appointment_Date);


--Income Chart Query
SELECT Incomes.Yr, Incomes.Mon, Income_Ammount, Expense_Amount , Income_Ammount - Expense_Amount AS Profit  FROM(
select year(Expense_Date) as Yr, 
DATENAME(Month,Expense_Date) as Mon ,
sum(Amount) as Expense_Amount from Expenses
group by year(Expense_Date), DATENAME(MONTH,Expense_Date)
) Expence
LEFT JOIN (
select year(Appointment_Date) as Yr,
DATENAME(Month,Appointment_Date) as Mon ,
sum(Price) as Income_Ammount from Appointment
where Status_Update='Paid'
group by year(Appointment_Date), DATENAME(MONTH,Appointment_Date) ) AS Incomes
ON Expence.Yr = Incomes.Yr AND Expence.Mon= Incomes.Mon

ORDER BY Incomes.Yr, Incomes.Mon;


--Other tested Query
SELECT Appointment_Id, Customer_Id, Ser_Name, Branch,
CONVERT(date,Appointment_Date) AS Appointment_Date,
Start_Time, End_Time, Price, Status_Update
FROM dbo.Appointment