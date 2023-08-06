-- 1.
-- Based on the 'employees' table, insert an employee record whose employee_number is 1005, 
-- employee_name is Sally Johnson, salary is $58,000, and dept_id is 500;

CREATE TABLE employees (
    employee_number int NOT NULL, 
    last_name char(50) NOT NULL, 
    first_name char(50) NOT NULL, 
    salary int, dept_id int, 
    CONSTRAINT employees_pk PRIMARY KEY (employee_number));

INSERT INTO employees (employee_number, first_name, last_name, salary, dept_id) VALUES (1005, 'Sally', 'Johnson', 58000, 500);

-- 2.
-- Based on the 'suppliers' table populated with the following data, insert a supplier record 
-- whose supplier_id is 1000, supplier_name is Apple:

CREATE TABLE suppliers (
    supplier_id int NOT NULL, 
    supplier_name char(50) NOT NULL, 
    city char(50), 
    state char(50), 
    CONSTRAINT suppliers_pk PRIMARY KEY (supplier_id));

INSERT INTO suppliers (supplier_id, supplier_name) VALUES (1000, 'Apple');

-- 3.
-- Based on the 'products' table populated with the following data update the product_name to 
-- 'Grapefruit' for all records whose product_name is 'Apple'

CREATE TABLE products (
    product_id int NOT NULL, 
    product_name char(50) NOT NULL, 
    category_id int, 
    CONSTRAINT products_pk PRIMARY KET (product_id));

INSERT INTO products (product_id, product_name, category_id) VALUES (1, 'Pear', 50);
INSERT INTO products (product_id, product_name, category_id) VALUES (2, 'Banana', 50);
INSERT INTO products (product_id, product_name, category_id) VALUES (3, 'Apple', 50);
INSERT INTO products (product_id, product_name, category_id) VALUES (4, 'Orange', 50);

UPDATE products SET product_name = 'Grapefruit' WHERE product_name = 'Apple';

-- 4. 
-- Based on the 'suppliers' table populated with the following data, update the city to 
-- 'Boise' and the state to 'Idaho' for all records whose supplier_name is "Microsoft"

CREATE TABLE suppliers (
    supplier_id int NOT NULL, 
    supplier_name char(50) NOT NULL, 
    city char(50), 
    state char(50), 
    CONSTRAINT suppliers_pk PRIMARY KEY (supplier_id));

INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (100, 'Microsoft', 'Redmond', 'Washington');
INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (200, 'Google', 'Mountain View', 'California');
INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (300, 'Oracle', 'Redwood City', 'California');

UPDATE suppliers SET (city = 'Boise', state = 'Idaho') WHERE supplier_name = 'Microsoft'; 

-- 5. 
-- Based on the employees table, delete all employee records whose salary is greater than $60000

CREATE TABLE employees (
    employee_number int NOT NULL, 
    last_name char(50) NOT NULL, 
    first_name char(50) NOT NULL, 
    salary int, 
    dept_id int, 
    CONSTRAINT employees_pk PRIMARY KEY (employee_number));

INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1001, 'Smith', 'John', 62000, 500);
INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1002, 'Anderson', 'Jane', 57500, 500);
INSERT INTO employees (employee_number, last_name, first_name, salary, dept_id) VALUES (1003, 'Everest', 'Brad', 71000, 501);

DELETE FROM employees WHERE salary > 60000

-- 6. 
-- Based on the suppliers table delete the supplier record whose state is 'California' and 'supplier_name' is not Google:

CREATE TABLE suppliers (
    supplier_id int NOT NULL, 
    supplier_name char(50) NOT NULL, 
    city char(50),
    state char(50), 
    CONSTRAINT suppliers_pk PRIMARY KEY (supplier_id));

INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (100, 'Microsoft', 'Redmond', 'Washington');
INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (200, 'Google', 'Mountain View', 'California');
INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (300, 'Oracle', 'Redwood City', 'California');
INSERT INTO suppliers (supplier_id, supplier_name, city, state) VALUES (400, 'Kimberly-Clark', 'Irving', 'Texas');

DELETE FROM suppliers WHERE (state = 'California' AND supplier_name NOT 'Google');
