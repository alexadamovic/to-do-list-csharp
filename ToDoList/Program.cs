using System;
using System.Reflection;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Welcome to the To Do List \nWould you like to add an item to your list or view your list? (Add/View)");
      string userAnswer = Console.ReadLine();
      UserLoop();

      void UserLoop()
      {
        switch (userAnswer)
        {
          case "Add":
            Console.WriteLine("Please enter the description for the new item");
            string userDescription = Console.ReadLine();
            Item newItem = new Item(userDescription);
            Console.WriteLine("\'" + userDescription + "\' has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
            userAnswer = Console.ReadLine();
            break;
            
          case "View":
            List<Item> userList = Item.GetAll();
            foreach (Item x in userList) 
            {
              Console.WriteLine(x.Description);
            }
            Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
            userAnswer = Console.ReadLine();
            break;
        }
        UserLoop();
      }
    }
  }
}

