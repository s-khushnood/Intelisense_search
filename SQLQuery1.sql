create table Students
(
ID int primary key identity (1,1) not null,
FirstName varchar(30) not null,
LastName varchar(30) not null,
Age int not null,
Course varchar(50) not null
)

insert into students(FirstName,LastName,Age,Course)
values('Atif','Ali',23,'Programming Fundamentals'),
('Khawar','Shah',25,'Fluids'),
('Sohaib','TA',23,'Web Dev')

Create procedure FetchAllStudents
as
begin
select * from students
end


Create procedure FetchbyName
@name varchar(30)
as 
begin
SELECT * FROM Students WHERE FirstName Like'%'+@name+'%' OR LastName Like '%'+@name+'%'
end
