using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statements cs = new Conditional_Statements();
            cs.RunExercise();

            Comparison_Operators co = new Comparison_Operators();
            co.RunExercise();

            IO_Operators ioo = new IO_Operators();
            ioo.RunExercise();

            Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
            Modulus_Operator mo = new Modulus_Operator();
            mo.RunExercise();

            Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            ftc.RunExercise();
        }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }


    class IO_Operators
    {
        public void RunExercise()
        {
            int x;
            int y;
            Console.WriteLine("Please enter a value for x: ");
            Int32.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Please enter a value for y: ");
            Int32.TryParse(Console.ReadLine(), out y);
            if (y - x == 5)
                Console.WriteLine(x + " and " + y + " are within 5 integers of each other");
            else
                Console.WriteLine("These two integers are NOT within 5 integers of each other");

            Console.WriteLine("\nProgram OVER!\n");
        }
    }

    class Conditional_Methods
    {
        public void UsingIf()
        {
            Console.WriteLine("This is If statements only");
            Console.WriteLine("Please select an integer betweeen 0-10");
            int userInput;
            Int32.TryParse(Console.ReadLine(), out userInput);
            if (userInput == 0)
                Console.WriteLine("You need to talk to the professor immediately!");
            if (userInput == 1)
                Console.WriteLine("You need to study a lot more!");
            if (userInput > 1 && userInput < 5)
                Console.WriteLine("If you keep working at this, you'll do better!");
            if (userInput == 5 || userInput == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            if (userInput == 7 || userInput == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
            if (userInput == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            if (userInput == 10)
                Console.WriteLine("Perfect!");

            Console.WriteLine("\nSegment Over!\n");


        }

        public void UsingIfElse()
        {
         Console.WriteLine("This is If and Else statements");
         Console.WriteLine("Please select an integer betweeen 0-10");

            int userInput;
            Int32.TryParse(Console.ReadLine(), out userInput);
            if (userInput == 0)
                Console.WriteLine("You need to talk to the professor immediately!");
           else if (userInput == 1)
                Console.WriteLine("You need to study a lot more!");
           else if (userInput > 1 && userInput < 5)
                Console.WriteLine("If you keep working at this, you'll do better!");
           else if (userInput == 5 || userInput == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
           else if (userInput == 7 || userInput == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
           else if (userInput == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            else if (userInput == 10)
                Console.WriteLine("Perfect!");
           
            Console.WriteLine("\nSegment Over!\n");
        }
        public void UsingSwitch()
        {
         Console.WriteLine("This is Switch statements only");
         Console.WriteLine("Please select an integer betweeen 0-10");
            int userInput;
            Int32.TryParse(Console.ReadLine(), out userInput);
            switch(userInput)
            { 
                case 0:
                    Console.WriteLine("You need to talk to the professor immediately!");
                    break;
                case 1:
                    Console.WriteLine("You need to study a lot more!");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 9:
                    Console.WriteLine("Very nice job - keep up the good work!");
                    break;
                case 10:
                    Console.WriteLine("Perfect!");
                    break;

                    


            }
            Console.WriteLine("\nProgram.....OVER!\n");
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
            Console.WriteLine(6 / 3);   //If we were to try and compile 7/3 it would recognize those two numbers
            double x = 7.0 / 3.0;      //as integers because: there is no f for floating point or decimal point, which would compile as an integer (or 0), leaving out the remainder
            float y = (7.0f / 3.0f);   //The reason for this is that the compiler is now accepting the full decision rather than just integers.
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
            int x = 10;
            int y = 100;
            int result = y / x;
            int scarn = x % y;
            Console.WriteLine(result);
            Console.WriteLine(scarn);

            int a;
            int b;
            Console.WriteLine("Please enter a value for a: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please enter a value for b: ");
            Int32.TryParse(Console.ReadLine(), out b);
            int divide = a / b;
            int modulus = a % b;
            Console.WriteLine("The two numbers you selected divided is: " + divide);
            Console.WriteLine("The two numbers you selected has a remainder of: " + modulus);


        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
            double f;
            Console.WriteLine("Please enter a farenheit value: ");
            double.TryParse(Console.ReadLine(), out f);
            double celcius = (5.0 / 9.0) * (f - 32);
            Console.WriteLine("The celcius of " + f + " degrees " + "is " + celcius + " degrees celcius.");
        }
    }

    class Logical_Operators
    {
        // Your answer goes here,in a comment like this one
//        int y = 5 ;
//        int x = 2 ;
//        int z = 10 ;

//        1.	y< 1 || y> 2
//              a.  if y is an integer(any integer, not just 2), can you find a better way to express the above?
//                  when looking for a different/better way to express this, think when the expression will be true, and when it won't.  once you've got that figured out, think about how you might explain it to a friend – what's a quick, 1 sentence summary of when the expression evaluates to true?  lastly, think about how you would write that in c#.
//                  when handing your answer to this part, put in something that clearly states what your new, simplified expression(in c# is)
//              5<1 || 5>2
//            False || True  Result is true, because one of the expressions was true
//              
//
//        2.	y< 2 || x> 4
//              5<2  || 2>4
//             False || False  Result is False, because neither expression was true.
//                   
//           
//        3.	z > 8 || y< 3
//             10 > 8 || 5 < 3
//              True  || False  Result is true, 
//
//        4.	!(z > 8)
//              !(10 > 8)
//              !(True)
//
//
//        5.	!( z > 8 || y< 3)
//              !(10 > 8 || 5< 3)
//              !(True   || False)
//              !(True)
//              False
//
//        6.	!( z > 4 && y == 2) || (z ==10 && y <= 3)
//              !(10 > 4 && 5 == 2) || (10 ==10&& 5 <= 3)
//              !(True   && False ) || (True   && False )
//              !(False)            || (False)
//              True                || False             This breaks down to True or false  
//
//        7.	y<z ^ z<x
//              5<10^ 10<2
//              True^ False
//              True
//
//        8.	z<x ^ y<z
//              10<2^ 2<10
//             False^ True
//             True
//
//        9.	10 < 20 ^ 20 < 30
//              True    ^   True
//              False, since ^ stands for mutually exclusive, if both are true the statement is false.   
//
//         10.	20 == 10 ^ 20 < 10
//              False    ^ False
//              False, since both are false the statement will result in false
//

        // Side-Note: Notice that this class has NO methods, and that it still compiles :)
    }
}