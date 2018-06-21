## Steven Rhodes
### ASP.NET Chapter 7 Homework

### 1. What is a Visual Studio Solution? How do you create them?
A solution is a structure for organizing projects in Visual Studio. The solution maintains the state information for projects in .sln

### 2. Why would you use an Empty project instead of a completed template? What are the advantages of an empty project, are there disadvantages with creating a project from a template?
An empty project would be useful if you want to create your solution from scratch, without any framework. Creating a project from a template might introduce unneccessary bloat into your solution

### 3. What is Nuget? Describe how you use it and why?
Nuget is a package of .NET code that can be shared. It allows for useful reuse of utilities

### 4. Explain what a Reference is, what is it used for? How you would add or remove one?
A reference is essentially an entry in a project file that contains the information that Visual Studio needs to locate the component or the service.

### 5. What is a DI Container? In this book they reference Ninject as the software being used, are there
other software products that can be used for DI in Visual Studio?


### 6. What is a domain model and how is it used? What is a view model and how is it used?
A domain model is generally implemented as an object model within a layer that uses a lower-level layer for persistence and "publishes" an API to a higher-level layer to gain access to the data and behavior of the model.

View Model is a model class that can hold only those properties that is required for a view.

### 7. What is meant by the term Repository Pattern? How is it used?
The Repository Pattern is one of the most popular patterns to create an enterprise level application. It restricts us to work directly with the data in the application and creates new layers for database operations, business logic, and the application's UI.

### 8. What software development strategy is the term Mock Repository referring to? Why would you create a Mock repository?
It is a part of the test double strategy. Mock objects are simulated objects that mimic the behavior of real objects in controlled ways. 

### 9. Describe the role played by a Controller in this chapter, what is a View as explained in this chapter?
The controller accepts input and converts it to commands for the model or view.

The view can be any output representation of information

### 10. What is a default route and what purpose does it serve? In what way does having readable Urls impact the website?
Default routes are the initial point of entry into a website. Readable url's block behind the scenes code, and allow for easy to use url's for the user

### 11. What is ORM? Are we employing this technique? If so how?
ORM is a programming technique for converting data between incompatible type systems using object-oriented programming languages

### 12. How many ways can you add Database support to your solution? Name at least one way.
You can add a SQL database in Visual Studio

### 13. What is a context class? Be specific.
The context class is the root class for all managed code responses. 

### 14. How are optional parameters used within this chapter, give examples.
Optional parameters allow for the passing of optional arguments. Otherwise, the method can resort to some default functionality without any parameters

### 15. What do TDD mean?
Test driven development

### 16. What method is used in TDD to verify the success or failure of the code?
Code is refactored until all methods pass their required functionality

### 17. What are Html Helpers?
HtmlHelper class generates html elements using the model class object in razor view.

### 18. Breakdown this expression:
a. @Html.PageLinks(Model.PagingInfo, x => Url.Action("List", new { page = x }))
b. What does MvcHtmlString represent? How is it used?

Using MvcHtmlString in your html helpers you can tell razor that it doesn't need to encode it.

### 19. What is Bootstrap? What is it used for?
It is an HTML, CSS, javascript framework that you can use as a basis for creating web sites or web applications.

It is used for creating user interface components