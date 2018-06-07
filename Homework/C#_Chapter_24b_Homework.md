## Steven Rhodes
### C# Chapter 24b Homework

### 1. What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?
When using large data sets or if the criteria for matching data involves expensive operations

### 2. How doesAsParallel qualify as an extension method? First, explain what an extension method is and how you define entension methods, and them explain why AsParallel qualifies as an extension method.
AsParallel futher extends the LINQ class by allowing the query to partition data into smaller sects, and operate multiple threads to search these sects

### 3. How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and methods used for the cancellation operation, and how the variables abd methods are used.
You create a cancellation token from a cancellationtokensource

### 4. Why is it important to synchronize concurrent access to a server? Give an example of a specific condition that will cause an error in your application if concurrent access is not synchronized.
Two operations running concurrently that change and read the data may not execute perfectly in parallel

### 5. What does the lock statement do?
Ensures exclusive access to a resource

### 6. This is not in the book. Define mutex, define semaphore, and explain the difference between them.
Mutex ensures that only a producer of information can run and prevent a consumer from accessing the information. Semaphore is a signaling mechanism. Semaphore restricts the number of keys used.

### 7. What does it mean to say that some collection classes are not thread safe? Explain how not being thread safe may lead one of these collection classes to produce a malfunction in the program.
Multiple operations can access and manipulate the contained data at the same time, which can lead to data corruption

### 8. Explain how thread safe collection classes are made thread safe.
They are made thread safe by using the synchronization primitives to wrap code that adds, queries, and removes elements in a collection.

### 9. Why are thread safe classes slower than non-thread safe classes? Be specific.
Thread safe collections increase computational work.