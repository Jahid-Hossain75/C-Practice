using System;
namespace my_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // double pi = 3.1416;
            // double r, Area;
            // Console.WriteLine("Enter Radius: ");
            // r = Convert.ToDouble(Console.ReadLine());
            // Area = pi*r*r;
            // Console.WriteLine("The circle area is: "+ Area);
            // int a=5;
            // Console.WriteLine(a<<2);
            // char ch;

            // Console.WriteLine("Enter an alphabet:");

            // ch =Convert.ToChar(Console.ReadLine());

            // switch(Char.ToLower(ch))
            // {

            //     case 'a':
            //     Console.WriteLine("Vowel");
            //     break;
            //     case 'e':
            //     Console.WriteLine("Vowel");
            //     break;
            //     case 'i':
            //     Console.WriteLine("Vowel");
            //     break;
            //     case 'o':
            //     Console.WriteLine("Vowel");
            //     break;
            //     case 'u':
            //     Console.WriteLine("Vowel");
            //     break;
            //     default:
            //     Console.WriteLine("Not a Vowel");
            //     break;
            // }

        // int i;

        // for(i=0;i<=100;i=i+1){

        //        if(i==4){
        //            continue;
        //        }
        //        Console.WriteLine(i); 
        // }


        // Nullable <int> n= null;

        // Console.WriteLine(n.GetValueOrDefault());

        // 

        int number = 3;

        // if(number%2==0){

        //     Console.WriteLine("Even");
        // }
        // else{
        //     Console.WriteLine("Odd");
        // }

        String value = (number%2==0)? "Even":"Odd";
        Console.WriteLine(value);

        }
    }
}
