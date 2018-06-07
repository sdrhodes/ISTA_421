## Steven Rhodes
### C# Chapter 26 Homework

### 1. Describe the three concerns that the Model-View-ViewModel design pattern addresses.
Allows a designer to focus on the view, the data guy to optimizing data structures for storing and accessing the data, and dev can focus on business logic

### 2. Describe in detail how the MVVM design pattern works.
Model provides data uses by the app, view is the dipsplay, and the ViewModel contains logic that connects the two by taking user commands that perform business operations on the model.

### 3. Describe in detail how data binding works with respect to controls and models.
It allows the property of a control to affect the property of an object

### 4. Describe the three methods that the ICommand interface defines. What is the purpose of each method?
CanExecute- which returns a boolean value indicating whether a command can run
Execute- runs when the command is invoked
CanExecuteChanged- triggered when the state of ViewModel changes

### 5. What is a data context? Why do we need a data context? What does it do?
Source of all entities mapped over a database connection. It tracks changes you made to all retrieved entities