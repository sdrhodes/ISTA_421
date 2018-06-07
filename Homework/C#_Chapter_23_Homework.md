## Steven Rhodes
### C# Chapter 23 Homework

### 1 List two reasons for multitasking, and explain the rationale for them.
Improve scalability and responsiveness by spreading the work over multiple cpus

### 2 Explain Moore’s law. What does Moore’s law have to do with multitasking?
Number of transistors on integrated circuits doubles every two years

### 3 In UWP, what namespace is used as the container for the multitasking methods?
The System.Threading.Tasks namespace provides types that simplify the work of writing concurrent and asynchronous code.

### 4 What is the difference between tasks and threads? Explain.
A task is something you want done.
A thread is one of the many possible workers which performs that task.

### 5 What is the ThreadPool?
Implements a number of optimization and uses work scaling algorithms to ensure threads are scheduled efficiently

### 6 What parameters does the Task() constructor take?
It is overloaded, there are several.

### 7 How do you start a thread?
Use a Start() method

### 8 What is the difference between the Start() and Run() methods?
Start() is overloaded, and you can optionally specify a object to provide hints about how to schedule the task

run()method takes an action delegate specifying the operation to perform, but starts the task running immediately

### 9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.
Task means the programmer decides to divide the work. Parallel means the compiler decides how to divide the work

### 10 Explain how manual cancellation works using a cancellation token.
Create a token, and give every thread of execution access to the token. Thread will check the token, and if it returns true, it will stop the process.