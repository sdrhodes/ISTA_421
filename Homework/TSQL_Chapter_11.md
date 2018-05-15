## Steven Rhodes
### TSQL Ch 11 Homework

### 1. Why do we use variables in T-SQL? HOw do you declare and initialize T-SQL variables?
Variables are declared in the body of a batch or procedure with the DECLARE statement and are assigned values by using either a SET or SELECT statement. Cursor variables can be declared with this statement and used with other cursor-related statements. After declaration, all variables are initialized as NULL, unless a value is provided as part of the declaration.

### 2. Describe what is meant by a batch file in T-SQL? What is the difference between batches and transactions?
A batch file is a text file that contains a sequence of commands for a computer operating system. It's called a batch file because it batches (bundles or packages) into a single file a set of commands that would otherwise have to be presented to the system interactively from a keyboard one at a time.
-SQL Batch is just that a collection of commands that need to be executed without guaranteed of success or fail.
-SQL Transaction is a collection of commands that are guaranteed to succeed or fail totally.Transactions won't complete half the commands and then fail on the rest, if one fails they all fail.
### 3. What is the scope of variables with respect to T-SQL batches?
The scope of a variable is the range of Transact-SQL statements that can reference the variable. The scope of a variable lasts from the point it is declared until the end of the batch or stored procedure in which it is declared. For example, the following script generates a syntax error because the variable is declared in one batch and referenced in another:

### 4. Write a T-SQL code snippet that returns a data element stating whether the current person can legally purchase alcohol, that is, has reached his 21st birthday.


### 5. (Not in book) Does T-SQL have a for loop construction?
In SQL Server, there is no FOR LOOP. However, you simulate the FOR LOOP using the WHILE LOOP.

DECLARE @cnt INT = 0;

WHILE @cnt < cnt_total
BEGIN
   {...statements...}
   SET @cnt = @cnt + 1;
END;

### 6. What is a cursor? What is the difference between a relation and a cursor?
A cursor is a temporary work area created in the system memory when a SQL statement is executed. A cursor contains information on a select statement and the rows of data accessed by it. This temporary work area is used to store the data retrieved from the database, and manipulate this data.

### 7. How do you declare a temporary table? Why would you declare a temporary table?
Most common scenario for using temporary tables is from within a stored procedure.

If there is logic inside a stored procedure which involves manipulation of data that cannot be done within a single query, then in such cases, the output of one query / intermediate results can be stored in a temporary table which then participates in further manipulation via joins etc to achieve the final result.

create table #Temp
(
    EventID int, 
    EventTitle Varchar(50), 
    EventStartDate DateTime, 
    EventEndDate DatetIme, 
    EventEnumDays int,
    EventStartTime Datetime,
    EventEndTime DateTime, 
    EventRecurring Bit, 
    EventType int
)

### 8. What is the difference between a stored procedure, a user defined function, and a trigger?
A stored procedure is a user defined piece of code written in the local version of PL/SQL, which may return a value (making it a function) that is invoked by calling it explicitly.

User-defined functions are routines that accept parameters, perform an action, such as a complex calculation, and return the result of that action as a value. The return value can either be a single scalar value or a result set.

A trigger is a stored procedure that runs automatically when various events happen (eg update, insert, delete).

### 9. Write a user defined function that returns a Booleans as to whether a customer may purchase alcohol as of the instant that the function runs.


### 10. Write a trigger that places a customer in the OFF LIMITS table if he attempt to purchase alcohol when he is underage.


### 11. Write a stored procedure that deletes customers from the OFF LIMITS table when they have reached their 21st birthday.