using System;
using model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Expense_Tracker.Basic
{
    public class MainUsage
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number to do the operation");
                Console.WriteLine("1:To add an expense");
                Console.WriteLine("2:To view all expenses");
                Console.WriteLine("3:To edit an expense");
                Console.WriteLine("4:To delete an expense");
                int r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Expense.AddExpense();
                        break;
                    case 2:
                        Expense.ViewAllExpenses();
                        break;
                    default:
                        Console.WriteLine("This is a default message");
                        break;
                }
            }
        }
    }
}
