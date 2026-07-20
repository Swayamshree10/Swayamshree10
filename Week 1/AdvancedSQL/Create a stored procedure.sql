CREATE TABLE Employee (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);


INSERT INTO Employee VALUES
(1, 'Amit', 'HR', 50000),
(2, 'Priya', 'IT', 60000),
(3, 'Rahul', 'Sales', 55000),
(4, 'Sneha', 'IT', 70000),
(5, 'Rohan', 'HR', 45000);

CREATE PROCEDURE GetEmployeeDetails
AS
BEGIN
    SELECT * FROM Employee;
END;

EXEC GetEmployeeDetails;