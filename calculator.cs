using System.IO;
using System;

namespace calculator
{
  class calculator1
{
    static void Main()
    {
      int num1,num2;
      string ope;
      Console.WriteLine("number1:");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Operand");
      ope = Console.ReadLine();
      Console.WriteLine("number2:");
      num2 = Convert.ToInt32(Console.ReadLine());
       if(ope=="+"){
          Console.WriteLine("Result = "+(num1+num2));
       }
       else if(ope=="-"){
         Console.WriteLine("Result = "+(num1-num2));
       }
       else if(ope == "*"){
         Console.WriteLine("Result = "+(num1*num2));
       }
       else if(ope == "/"){
         Console.WriteLine("Result = "+(num1/num2));
       }
       else{
         Console.WriteLine("Invalid Operand");
       }
     
    }
}  
}