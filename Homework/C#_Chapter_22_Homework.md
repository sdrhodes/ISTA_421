## Steven Rhodes
### C# Chapter 22 Homework

### 1. Explain the difference between the concepts of associativity and precedence.
The precedence and associativity of C operators affect the grouping and evaluation of operands in expressions. An operator's precedence is meaningful only if other operators with higher or lower precedence are present. Expressions with higher-precedence operators are evaluated first. Precedence can also be described by the word "binding." Operators with a higher precedence are said to have tighter binding.

### 2. Explain the difference between the concepts of binary and unary operators.
Unary operators act on only one operand in an expression. 

Operators that take two operands, such as arithmetic operators ( + , - , * , / ), are referred to as binary operators

### 3. List four constraints imposed by C# with respect to operator overloading.
-The operator function should be a member function of the containing type.
-The operator function must be static.
-The operator function must have the keyword operator followed by the operator to be overridden.
-The arguments of the function are the operands.
-The return value of the function is the result of the operation.

### 4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.
You can redefine or overload most of the built-in operators available in C#. Thus a programmer can use operators with user-defined types as well. Overloaded operators are functions with special names the keyword operator followed by the symbol for the operator being defined. similar to any other function, an overloaded operator has a return type and a parameter list.


	public static Box operator+ (Box b, Box c) {
	   Box box = new Box();
	   box.length = b.length + c.length;
	   box.breadth = b.breadth + c.breadth;
	   box.height = b.height + c.height;
	   return box;
	}

### 5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?
Symmetric operators come in pairs

### 6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.
You can't explicitly overload the compound assignment operators. You can however overload the main operator and the compiler expands it.

x += 1 is purely syntactic sugar for x = x + 1 and the latter is what it will be translated to. If you overload the + operator it will be called.

### 7. What is the difference between overloading increment and decrement operators for value types and reference types?
Increment and decrement on reference types create new objects based on the data in the original. the data in the new object is incremented, but the data in the original is left unchanged

### 8. Why do we overload some operators in pairs?
Some operators naturally come in pairs, ==, !=   <>   <= >=  The compiler does not write any of these operator partners for you. You must write them all explicitly

### 9. What is the difference between widening conversion and narrowing conversion?
A widening conversion changes a value to a data type that can allow for any possible value of the original data. Widening conversions preserve the source value but can change its representation. This occurs if you convert from an integral type to Decimal, or from Char to String.

A narrowing conversion changes a value to a data type that might not be able to hold some of the possible values. For example, a fractional value is rounded when it is converted to an integral type, and a numeric type being converted to Boolean is reduced to either True or False.

### 10. What is the difference between explicit conversion and implicit conversion?
Implicit means C# compiler can use it without requiring a cast, explicit conversion requires a cast