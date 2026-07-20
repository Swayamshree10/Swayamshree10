CREATE TABLE Employee (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);


INSERT INTO Employee (EmpID, EmpName, Department, Salary) VALUES
(1, 'Amit', 'HR', 50000),
(2, 'Priya', 'HR', 60000),
(3, 'Rahul', 'IT', 70000),
(4, 'Sneha', 'IT', 80000),
(5, 'Rohan', 'Sales', 55000),
(6, 'Neha', 'Sales', 65000);

-- Ranking and Window Functions
SELECT
    EmpID,
    EmpName,
    Department,
    Salary,

    RANK() OVER (ORDER BY Salary DESC) AS SalaryRank,

    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRank,

    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNumber,

    RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) AS DepartmentRank

FROM Employee;