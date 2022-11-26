# crypto-marketplace-mvc

Crypto Marketplace Task is developed in ASP.NET Core 6 MVC.

> Code structure

I have divided the application in some of the following folders.\
![image](https://user-images.githubusercontent.com/68497389/204107580-b28f9d4c-7992-4fc4-9c86-2fd6aafd6494.png)

**-Models:** Inside this folder I have created a model class for Coins.\
![image](https://user-images.githubusercontent.com/68497389/204107660-d6a5cc24-e837-42d9-a307-1ec6a46ababa.png)

**-Repositories:** Inside this folder I have created two subfolders. One for interfaces and one for helper methods.\
 In the helper methods folder, I have created a function which is a helper to get data from the external API using HttpClient and returning a JSON with the data.\
 ![image](https://user-images.githubusercontent.com/68497389/204107614-49d6310e-2a29-4c52-a2f7-1caee11dc077.png)
 
 After that I have created a function where I get all this data filtered by symbol and also paginated.\
 For pagination I have used the a package called X.PagedList.MVC.Core
 ![image](https://user-images.githubusercontent.com/68497389/204107638-d3920636-f73b-4e63-b630-d7eabcc7a4ca.png)


Below is the code inside the index view.\
![image](https://user-images.githubusercontent.com/68497389/204107783-766ce5ce-052b-4983-9257-54597e235deb.png)




> Run application

You can run the application by clicking on this button. ![image](https://user-images.githubusercontent.com/68497389/204107262-141bceff-d44a-4308-a14b-a67e862bef96.png)


![image](https://user-images.githubusercontent.com/68497389/204107469-3f4ac728-be98-4536-85bb-d1f61a255eb9.png)
You can see all the data shown in a table, also you can search coins by symbol and switch between pages.
