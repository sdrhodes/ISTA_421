## Steven Rhodes
### C# Chapter 19 Homework

### 1. What is an enumerable collection?
Collection that uses the IInterface

### 2. What properties and methods does the IEnumerable interface contain?
Contains one. Git enumerator

### 3. What properties and methods does the IEnumerator interface contain?
One property, and two methods. Current, move next and reset

### 4. What values does the MoveNext() method return? What does it do?
It is boolean. It returns true or false

### 5. What values does the Reset() method return? What does it do?
Void

### 6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
Not type safe. It returns an object, not a specific type

### 7. Why don’t recursive methods retain state when used with data structures like binary trees?
New items are in the stack

### 8. How do you define an enumerator?
A pointer indicating elements in a list

### 9. What is an iterator?
A block of code that yields an ordered sequence of values

### 10. What does yield do?
When you use the yield keyword in a statement, you indicate that the method, operator, or get accessor in which it appears is an iterator