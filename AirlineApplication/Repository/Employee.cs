﻿namespace Repository
{
    public class Employee
   {
       private string employeeId;
       private string name;
       private string username;
       private string email;
       private string password;
       private string gender;
       private int age;
       private string address;
       private string question;

       public string EmployeeID
       {
           get { return employeeId; }
           set { employeeId = value; }
       }
       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       public string Username
       {
           get { return username; }
           set { username = value; }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }
       public string Password
       {
           get { return password; }
           set { password = value; }
       }
       public string Gender
       {
           get { return gender; }
           set { gender = value; }
       }
       public int Age
       {
           get { return age; }
           set { age = value; }
       }
       
       public string Address
       {
           get { return address; }
           set { address = value; }
       }
       public string Question
       {
           get { return question; }
           set { question = value; }
       }
       
      

    }
}