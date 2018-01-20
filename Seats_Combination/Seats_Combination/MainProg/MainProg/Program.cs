using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputString; 
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool IsError=false;

            LabelAgain: 

            Console.WriteLine("Please Enter Input: ");
            InputString=Console.ReadLine();

            IsError = InputString.Any(char.IsDigit);  
        
            if (InputString.Length >= 2 && !IsError )       
            { 
                Policy1(InputString.ToUpper());    
                Policy2(InputString.ToUpper());    
                Policy3(InputString.ToUpper());     
            }
            else 
            {
                Console.WriteLine("Please Enter Valid Input Or Input String Must be greater than one digit!!!\n");
                goto LabelAgain; 
            
            }
            Console.Read();
        }

        static void Policy1(string Input) 
        {
            int Count = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                       if (i == 0)
                        continue;
                       if (Input[0] == 'U')
                       {
                           if (Input[i] == 'D')
                           {
                               Count += 2;
                           }
                       }
                       else
                       {
                           if (i == 1)
                           {
                               Count++;
                               continue;
                           }
                           if (Input[i] == 'D')
                           {
                               Count += 2;
                           }
                       }
            }
            Console.WriteLine("The total number of seat adjustments for policy#1: " + Count);
        }

        static void Policy2(string Input)   
        {
             int Count = 0;
             for (int i = 0; i < Input.Length; i++)
             {
                 if (i == 0)
                     continue;
                 if (Input[0] == 'D')
                 {
                     if (Input[i] == 'U')
                     {
                         Count += 2;
                     }
                 }
                 else
                 {
                     if (i == 1)
                     {
                         Count++;
                         continue;
                     }
                     if (Input[i] == 'U')
                     {
                         Count += 2;
                     }
                 }
             }
             Console.WriteLine("\nThe total number of seat adjustments for policy#2: " + Count);
           }
      
        static void Policy3(string Input)           
        {
             int Count = 0;
             for (int i = 0; i < Input.Length-1; i++)
             {
                 if (Input[i] != Input[i + 1])
                 {
                     Count++;
                 }
             }
             Console.WriteLine("\nThe total number of seat adjustments for policy#3: " + Count);
        }
    }

}
