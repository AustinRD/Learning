-- DML - Data Manipulation Language

-- How do we add data to a database table?
-- Insert - adds data to a database table
-- Syntax: 
-- INSERT INTO table_name VALUES (value1, ..., valueX)
-- INSERT INTO table_name (column1, ..., columnX) VALUES (value1, ..., valueX)
INSERT INTO Person (first_name, last_name, state, city) VALUES ('Nitsua', 'Odranoelid', 'Ainigriv', 'Swen Tropwen');

-- How do we change existing data in a database table?
-- Update - updates data in a database table
-- Syntax:
-- UPDATE table_name SET column_name = new_value WHERE column_name = some_value

-- Example: Add a first name to the person in a database table 'Person' where the last name = DiLeonardo
UPDATE Person SET first_name = 'Austin' WHERE last_name = 'DiLeonardo';

-- Example: Change the state and city of the person from the previous example
UPDATE Person SET state = 'Virginia', city = 'Newport News' WHERE last_name = 'DiLeonardo';

-- How do we delete data from a database table?
-- Delete - used to delete rows in a table
-- Syntax: 
-- DELETE FROM table_name WHERE column_name = some_value
-- DELETE FROM table_name
-- DELETE * FROM table_name

-- Example: Delete Austin from the table
DELETE FROM Person WHERE last_name = 'DiLeonardo';

-- Task:
-- Based on the 'employees' table, delete all employee records whose salary is greater than $60,000

CREATE TABLE employees 
    (employee_number int NOT NULL, 
    last_name char(50) NOT NULL, 
    first_name char(50) NOT NULL, 
    salary int, dept_id int, 
    CONSTRAINT employees_pk PRIMARY KEY (employee_number));

INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1001, 'Smith', 'John', 62000, 500);
INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1002, 'Doe', 'Jane', 57500, 500);
INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1003, 'Everest', 'Brad', 71000, 501);

DELETE FROM employees WHERE salary > 60000;