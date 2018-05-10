## Steven Rhodes
### C# Chapter 21 Homework

### 1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?
SQL is query writing mechanism which database developer used to write inside a RDBMS to insert, fetch records. While LINQ is methodology where queries are written inside .Net framework to fetch data from RDBMS

### 2. What is the one essential requirement for the datastructures used with LINQ? Why is this requirement important?
LINQ requires data to be stored in a data structure that implements the IEnumerable or IEnumderable<T> interface

### 3. Were does the LINQ Select() method live?
In the enumerable class. 
Namespace:   System.Linq
Assembly:  System.Core (in System.Core.dll)

### 4. (Select) Explain, token by token, each token in this line of code: IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
Selects the first name for each item in the array. First is an interface that returns generic type string. customerfirstnames = customers (object) . select (method) accepts parameters cust.firstname

### 5. (Filter) Explain, token by token, each token in this line of code: IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);
uscompanies ienumerable string type. we're assigning it to addresses, using the where function, passing the parameters addr (every record) where addr.country and united states are equal. and selects the company names

### 6. (OrderBy) Explain, token by token, each token in this line of code: IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);
It orders the returned results by companyname

### 7. (Group) Explain, token by token, each token in this line of code: var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);
companiesgroupedbycountry equals addresses (object) groupby(method) where addrs = country (group by country)

### 8. (Distinct) Explain, token by token, each token in this line of code: int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();
numberofcountries is a variable = addresses (object) select(method) (parameter countries) where distinct and count()

### 9. (Join) Explain, token by token, each token in this line of code: Page 1, Revised on February 22, 2018 by Charles Carter var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country });
companiesandcustomers (variable) customers.select (method), c is every value in the data structure new = new object {firstname,lastname,companyname} join with addresses (data structure)

### 10. Explain the difference between a deferred collection and a static, cached collection.
Deferred collection will show changes, whether the changes were made, and static will not