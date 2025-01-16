// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler





using System;
using System.Collections.Generic;
// Add an expense (date, category, amount, description).
// View all recorded expenses.
// Calculate the total expense.
// Filter expenses by category or date dynamically.
namespace model
{ 
public class Expense
{
       // date, category, amount, description.
       private DateTime date;
       private string category;
       private double amount;
       private string description;
       public DateTime _date
       {
           get
           {
               return date;
           }
           set{
               date=value;
           }
       }
       public Expense(DateTime date,string category,double amount,string description)
       {
           this.date=date;
           this.category=category;
           this.amount=amount;
           this.description=description;
       }
       public static List<Expense> l=new List<Expense>();
       public static void AddExpense()
       {
        Console.WriteLine("Enter the date (yyyy-MM-dd):");
        DateTime date = Convert.ToDateTime(Console.ReadLine());



        Console.WriteLine("Enter the category:");
        string category = Console.ReadLine();



        Console.WriteLine("Enter the amount:");
        double amount = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("Enter the description:");
        string description = Console.ReadLine();
        
         Expense AddExpense=new Expense(date,category,amount,description);
         l.Add(AddExpense);
       }
       //To view all expenses
       public static void ViewAllExpenses()
       {
         foreach(Expense i in l)
         {
           Console.WriteLine(i);
         }
       }
       public override string ToString()
       {
           return $"Date: {date.ToShortDateString()}, Category: {category}, Amount: ${amount:F2}, Description: {description}";
       }
        }
   }    