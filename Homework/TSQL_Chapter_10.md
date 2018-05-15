## Steven Rhodes
### TSQL Ch 10 Homework

### 1. What is the purpose of transactions? Why do we use transactions in SQL scripts?
A transaction is a single unit of work. If a transaction is successful, all of the data modifications made during the transaction are committed and become a permanent part of the database. If a transaction encounters errors and must be canceled or rolled back, then all of the data modifications are erased.

### 2. Briefly describe each of the ACID properties.
atomic transaction is either fully completed, or is not begun at all
A transaction enforces consistency in the system state by ensuring that at the end of any transaction the system is in a valid state
When a transaction runs in isolation, it appears to be the only action that the system is carrying out at one time
A transaction is durable in that once it has been successfully completed, all of the changes it made to the system are permanent.

### 3. What do we mean when we talk about the granularity of locks?
The granularity of locks in a database refers to how much of the data is locked at one time. In theory, a database server can lock as much as the entire database or as little as one column of data. Such extremes affect the concurrency (number of users that can access the data) and locking overhead (amount of work to process lock requests) in the server.

### 4. What do we mean when we talk about the modes of locks?
Exclusive (X)
Shared (S)
Update (U)
Intent (I)
Schema (Sch)
Bulk update (BU)

### 5. In your own words, describe blocking, and give an example.
"Blocking" is simply a term that means that one connection is holding a lock on a resource when another connection wants to read or write to it. It doesn't necessarily mean that the owner connection won't release it, just that it's currently holding it.

### 6. What are the properties of locks? That is, list the column name and column type of the fields in sys.dm tran locks.
Returns information about currently active lock manager resources in SQL Server 2017. Each row represents a currently active request to the lock manager for a lock that has been granted or is waiting to be granted.

The columns in the result set are divided into two main groups: resource and request. The resource group describes the resource on which the lock request is being made, and the request group describes the lock request.

https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-tran-locks-transact-sql?view=sql-server-2017

### 7. What are the properties of sessions? That is, list the column name and column type of the fields in sys.dm exec connections.
Returns one row per authenticated session on SQL Server. sys.dm_exec_sessions is a server-scope view that shows information about all active user connections and internal tasks. This information includes client version, client program name, client login time, login user, current session setting, and more. Use sys.dm_exec_sessions to first view the current system load and to identify a session of interest, and then learn more information about that session by using other dynamic management views or dynamic management functions.

https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sessions-transact-sql?view=sql-server-2017

### 8. What are the requests of sessions? That is, list the column name and column type of the fields in sys.dm exec requests.
Returns information about each request that is executing within SQL Server.

https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-requests-transact-sql?view=sql-server-2017

### 9. What is an isolation level? Give an example of the operation of an isolation level.
Controls the locking and row versioning behavior of Transact-SQL statements issued by a connection to SQL Server.

### 10. (Not in the book.) What do we mean when we say that an object is serializable?
Convert to binary

The two most important reasons are to persist the state of an object to a storage medium so an exact copy can be recreated at a later stage, and to send the object by value from one application domain to another. For example, serialization is used to save session state in ASP.NET and to copy objects to the clipboard in Windows Forms. It is also used by remoting to pass objects by value from one application domain to another. This article provides an overview of the serialization used in the Microsoft .NET Framework.

### 11. What is an deadlock? Give an example of a deadlock?
A deadlock occurs when two or more processes are waiting on the same resource and each process is waiting on the other process to complete before moving forward.