# Challenges
# Challege 1: 
This application build on MVC model, which takes customer data from db shows in UI, also it provide provision to create new customer.

High Level Representation Of Architecture Layer Files

1> View (Presentation tier) : Views/Home/Index.cshtml
2> Controller(Application tier): Controllers/HomeController.cs
3> Model(Data tier): Model/Customer.cs,DbRepo/CustomDbContext.cs,DbRepo/CustomerRepository.cs

# Challege 2:
This challege include powershell commands.
Command 1: Return Azure Instance details.
Command 2: Convert Json to Object.
Command 3: Prompt for the compute metadata intance parameter such as osProfile etc.
Command 4: Based on input in prompt shows result in the json format.

# Challege 3:
This application includes recursive function getString which takes two parameters one is Object and second is keys and returns value of the key.
eg.
Example 1:
Pass two parameters to getString function such as.
Input:
object = {“a”:{“b”:{“c”:”d”}}}
key = a/b/c
Output:
d

Example 2:
Pass two parameters to getString function such as.
Input:
object = {“a”:{“b”:{“c”:”d”}}}
key = a/b
Output:
{“c”:”d”}
