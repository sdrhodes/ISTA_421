## Steven Rhodes
### C# Chapter 20 Homework

### 1. What is a delegate? Explain delegates in terms of pointers and reference types.
Delegates "delegate processing to the referenced method when they are invoked. It is an object that refers to a method

### 2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
Use the delegate keyword, specify return type, a name for the delegate, and any parameters

### 3. How do you create instances of delegates and assign values to the instance? What are the values?
Include access modifier, type, and a name. It's a method

### 4. How do you invoke a method that has been added to a delegate?
Using the same syntax as as a method, example
myDelegate;
...
del();

### 5. What is an event? Why do we have events?
Are used to define and trap significant actions and arrange for a delegate to be called to handle the situation

### 6. How do you declare events?
The type of an event must be a delegate and you must prefix the declaration with the event keyword

### 7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
You subscribe using a += operator. You unsubscribe by using -=

### 8. How do you raise an event? How do you declare code that raises an event?
You raise an event by calling it like a method. When you raise an event all the attachec delegates are called in sequence

### 9. Explain with specificity what happens when an event fires and that event has been attached to a delegate
When an event happens, a threshold or some sort of condition is met, and it notifies the delegate, and runs the code