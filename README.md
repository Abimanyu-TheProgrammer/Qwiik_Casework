# Qwiik_Casework
Azure Link: [qwiik-casework.azurewebsites.net](qwiik-casework.azurewebsites.net) <br>

## Description
This is the implementation of the Data Structures and Functions specified in the casework PDF:

• Function to accept three sides of a triangle and returns the type of triangle i.e., isosceles, equilateral etc.<br>
• Function to accept a number and generate the Fibonacci series till that number.<br>
• Implement Queue in C# and suggest its usage.<br>
• Implement QuickSort algorithm and calculate the complexity.<br>

With these demonstration points:

• Introduce separation of concerns between Business and Web layer<br>
• Leverage third party libraries using NuGet<br>
• Make classes ready for IoC/DI which can later be used, e.g. Autofac<br>
• Simplify code with LINQ<br>
• Create API documentation using Swagger.<br>
• Write Unit Tests<br>
• Use WebAPI for web services.<br>
• Use Azure cloud hosting to manage and host Web API projects.<br>
• Practice source control using GitHub.<br>

## Notes:
• Usage suggestion of Queue and the complexity of QuickSort is in the API Documentation, in the summary section of the routes.<br>
• LINQ is used in filtering an list for the input of QuickSort.<br>
• Third party libraries used include Moq and FluentAssertions.<br>

## Routes
- /fib/{num}<br>
Returns a list of integers forming a fibonacci series of n numbers

- /queue<br>
Shows the implementation of queue.<br>
The implementation enqueues the integers 1 and 2, then dequeues 1<br>

- /triangle<br>
Determines the type of a triangle based on its three sides<br>
The three sides are given as request parameters named "first", "second", and "third".

- /sort<br>
Sorts a list, which is first filtered with the condition that the numbers taken must be even.


For building and running the application you need:
- .Net 6

Run unit testing with [Xunit](https://xunit.net/)
```
$ dotnet test
```
