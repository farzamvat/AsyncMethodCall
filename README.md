##Calling synchronous methods asynchronously with callback function

Recently I found a link (https://msdn.microsoft.com/en-us/library/2e08f6yc(v=vs.110).aspx) 
about calling sync methods async in c#,
I found this feature interesting and decided to write a class to simplify this process.


How to use AsyncMethodCall :
- Instantiate an instance of AsyncCall class
- Invoke Call method on AsynCall instance
- 1st param is your synchronous method that you want to call asynchronously
- 2nd param is your callback function which has the return type of void and argument type of IAsyncResult
- 3rd param is your first method argument
- 4th param is your callback function argument which has to be object

There is an example of using AsyncCall class in Program.cs
