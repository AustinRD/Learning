-- DDL - Data Definition Language

-- How do you create a table in sql?
-- Syntax: 
-- CREATE TABLE table_name (column1 datatype, ..., columnx datatype)

-- Example: Create a table called 'Persons' that contains five columns: PersonID, LastName, FirstName, Address, and City

CREATE TABLE Persons (PersonID int, LastName varchar(255), FirstName varchar(255), Address varchar(255), City varchar(255));

-- Common Datatypes:
-- char(size) - fixed-length character string, max length is 255 bytes
-- varchar(size) - variable length character string
-- number(size) - number value with a max number of digits 'size'
-- number(size, d) - number value with a max number of digits of 'size' and number of digits to the right of the decimal 'd'
-- date - date value
-- int(size) - integer value

-- Task: Write an SQL Command for creating a table 'PAYMENT' with the following structure:
-- Loan_number -- integer -- 4
-- Payment_number -- varchar -- 3
-- Payment_date -- date
-- Payment_amount -- integer - 8

CREATE TABLE PAYMENT (Loan_number int(4), Payment_number varchar(3), Payment_date Date, Payment_amount int(8));

-- Task: Write an SQL query to create the table SALESPERSON with the following structure:
-- First Name -- varchar -- 30
-- Last Name -- varchar -- 30
-- City -- varchar -- 30
-- Sales -- decimal -- 8

CREATE TABLE SALESPERSON (first_name varchar(30), last_name varchar(30), city varchar(30), sales decimal(8));

-- How do you remove/delete/drop/truncate a table in SQL?

-- Drop - deletes/removes an existing table in the database
-- Syntax: 
-- DROP TABLE table_name;

-- Truncate - deletes the data inside a table but not the table itself
-- Syntax:
-- TRUNCATE TABLE table_name;

-- How do you change existing table structure?
-- Alter    - used to add, delete, or modify columns in an existing table.
--          - may also be used to add and drop various constraints on an existing table.
-- Syntax:
-- ALTER TABLE table_name ADD column_name datatype;
-- ALTER TABLE table_name DROP COLUMN column_name;

-- Example: Add an 'Email' column to the 'Customers' table:
ALTER TABLE Customers ADD Email varchar(255);

