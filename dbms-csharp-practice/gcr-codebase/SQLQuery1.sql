use hellodb;

create table Employees (
	EmployeeID int primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	BirthDate date,
	HireDate date,
	Position nvarchar(100),
	Salary decimal(18, 2)
);
Insert into Employees (EmployeeID, FirstName, LastName, BirthDate, HireDate, Position, Salary) values
(1, 'John', 'Doe', '1980-05-15', '2010-06-01', 'Software Engineer', 75000.00),
(2, 'Jane', 'Smith', '1985-08-22', '2012-09-15', 'Project Manager', 90000.00),
(3, 'Emily', 'Johnson', '1990-11-30', '2015-03-20', 'Business Analyst', 65000.00),
(4, 'Michael', 'Brown', '1975-02-10', '2008-12-05', 'Senior Developer', 85000.00),
(5, 'Sarah', 'Davis', '1988-07-25', '2013-07-30', 'QA Engineer', 60000.00);

create table Departments (
	DepartmentID int primary key,
	DepartmentName nvarchar(100) not null,
	ManagerID int foreign key references Employees(EmployeeID)
);
insert into Departments (DepartmentID, DepartmentName, ManagerID) values
(1, 'IT', 2),
(2, 'HR', 4),
(3, 'Finance', 1);
select * from Employees;
select * from Departments;