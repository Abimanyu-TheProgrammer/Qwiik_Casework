# Qwiik_Casework
Azure Link: [qwiik-casework.azurewebsites.net](qwiik-casework.azurewebsites.net) <br>

## Description
This is the implementation of the Data Structures and Functions specified in the casework PDF

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
