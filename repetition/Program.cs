using System;

namespace repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uppgift 1
            Console.WriteLine("Hello World");
            */

            /* Uppgift 2
            Console.WriteLine("Once upon a time");
            Console.WriteLine("I was falling in love");
            Console.WriteLine("I was falling in love");
            */

            /* Uppgift 3 
            Console.WriteLine(" Once upon a time \n I was falling in loveNow \n I’m only falling apart");
            */

            /* Uppgift 4
            String text = "Live and sleep";
            Console.WriteLine(text
            */

            /* Uppgift 5
            string name = "ada lovlace";
            Console.WriteLine("hej " + name);
            */
            /* Uppgift 6
            Console.WriteLine("Give input");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            */
            /* Uppgift 7
            Console.WriteLine("Give input");
            string input2 = Console.ReadLine();
            Console.WriteLine(input2);
            Console.WriteLine(input2);
            Console.WriteLine(input2);
            */
            /* Uppgift 8
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name + "!");
            */
            /* Uppgift 9
            Console.WriteLine("Hello how are you");
            Console.ReadLine();
            Console.WriteLine("how interesting tell me more");
            Console.ReadLine();
            Console.WriteLine("thank you for sharing");
            */

            /* Uppgift 10
            Console.WriteLine("Tell me a name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Tell me a profession");
            string profession = Console.ReadLine();
            Console.WriteLine("There once was a " + profession + " Named " + name2 + " Who went to the store to buy apples");
            */
            /* Uppgift 11
            int days = 200;
            double hours = 3.5;
            string coding = "Coding is fun";
            Console.WriteLine("Days to summer:");
            Console.WriteLine(days);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hours);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(coding);
            */

            /* Uppgift 12
            Console.WriteLine("Give me a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("you gave " + num);
            */

            /* Uppgift 13
            Console.WriteLine("Give me a number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("you gave " + num2);
            */

            /* Uppgift 14
            Console.WriteLine("give me the truth");
            bool svar = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("svar");
            */

            /* Uppgift 15
            Console.WriteLine("give me a string");
            string word = Console.ReadLine();
            Console.WriteLine("give me a integer");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("give me a double");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("give me an boolean");
            bool answer = bool.Parse(Console.ReadLine());
            Console.WriteLine("Your string " + word);
            Console.WriteLine("your integer " + num);
            Console.WriteLine("your double " + num2);
            Console.WriteLine("your bool " + answer);
            */
            /* Uppgift 16
            Console.WriteLine("How many days");
            int days = int.Parse(Console.ReadLine());
            int seconds = days * 86400;
            Console.WriteLine(seconds);
            */

            /* Uppgift 17
            Console.WriteLine("give me the first number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num + num2;
            Console.WriteLine("the sum is " + sum);
            */

            /* Uppgift 18
            Console.WriteLine("give me the first number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me the third number");
            int num3 = int.Parse(Console.ReadLine());
            int sum = num + num2 + num3;
            Console.WriteLine("the sum is " + sum);
            */
            /* Uppgift 19
            Console.WriteLine("give me the first number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num + num2;
            Console.WriteLine( num + "+" + num2 + "=" + sum);
            */
            /* Uppgift 20
            Console.WriteLine("give me the first number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num*num2;
            Console.WriteLine("the product is " + sum);
            */
            /* Uppgift 21
            Console.WriteLine("give me the first number");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            double num2 = double.Parse(Console.ReadLine());
            double avrage = (num + num2)/2;
            Console.WriteLine("the avrage is " + avrage);
            */
            /* Uppgift 22
            Console.WriteLine("give me the first number");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            double num3 = double.Parse(Console.ReadLine());
            double avrage = (num + num2 + num3) / 3;
            Console.WriteLine("the avrage is " + avrage);
            */
            /* Uppgift 23
            Console.WriteLine("give me the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("give me the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 +num2) );
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            */
            /* Uppgift 24
            int speed = 120;
            Console.WriteLine("your speed");
            int yourspeed = int.Parse(Console.ReadLine());
            if (yourspeed > speed)
            {
                Console.WriteLine("SPEEDING");
            }
            */
            /* Uppgift 25
            Console.WriteLine("give a number");
            int yournum = int.Parse(Console.ReadLine());
            int num = 1984;
            if (yournum == num)
            {
                Console.WriteLine("Orwell");
            }
            */
            /* Uppgift 26
            int birthyear = 1900;
            Console.WriteLine("birthyear");
            int yourbirthyear = int.Parse(Console.ReadLine());
            if (yourbirthyear < birthyear)
            {
                Console.WriteLine("You are old");
            }
            */

            /* Uppgift 27
            Console.WriteLine("give me a number");
            int num = int.Parse(Console.ReadLine());
            if(num >= 0)
            {
                Console.WriteLine("your number is posetive");
            }
            else
            {
                Console.WriteLine("your number is negative");
            }
            */
            /* Uppgift 28
            Console.WriteLine("how old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            if (age < 18)
            {
                Console.WriteLine("You are still a child");
            }
            */
            /* Uppgift 29
            Console.WriteLine("give me a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me a second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("the lager number is" + num1);
            }
            if (num2 > num1)
            {
                Console.WriteLine("the lager number is" + num2);
            }
            if (num1 == num2)
            {
                Console.WriteLine("the numbers are equal");
            }
            */
            /* Uppgift 30
            Console.WriteLine("what is your result?");
            int result = int.Parse(Console.ReadLine());
            if (result > 100)
            {
                Console.WriteLine("outstanding!!");
            }
            else if (result >= 90)
            {
                Console.WriteLine("5");
            }
            else if (result >= 80)
            {
                Console.WriteLine("4");
            }
            else if (result >= 70)
            {
                Console.WriteLine("3");
            }
            else if (result >= 60)
            {
                Console.WriteLine("2");
            }
            else if (result >= 50)
            {
                Console.WriteLine("1");
            }
            else if (result >= 0)
            {
                Console.WriteLine("Fail");
            }
            else if (result < 0)
            {
                Console.WriteLine("Impossible");
            }
            */
            /* Uppgift 31
            Console.WriteLine("give me a number");
            double num1 = double.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
            */
            /* Uppgift 32
            Console.WriteLine("Speak the password and you may enter");
            string password = Console.ReadLine();
            if (password == "Mellon")
            {
                Console.WriteLine("You may enter");
            }
            else
            {
                Console.WriteLine("Get out cave troll!!!");
            }
            */
            /* Uppgift 33
            Console.WriteLine("give me a word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Give me a second word");
            string word2 = Console.ReadLine();
            if (word1 == word2)
            {
                Console.WriteLine("Echo");
            } 
            else
            {
                Console.WriteLine("Nej");
            }
            */
            /* Uppgift 34
            string answer = "ja";
            while (answer == "ja")
            {
                Console.WriteLine("Vill du fortsätta?");
                answer = Console.ReadLine();
            }
            */
            /* Uppgift 35
            int num = 1;
            while (num != 42)
            {
                Console.WriteLine("give me a number");
                num = int.Parse(Console.ReadLine());
            }
            */
            /* Uppgift 36
            Console.WriteLine("give me a number");
            double num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine((num*num));
            }
            if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            */
            /* Uppgift 37
            int num = 1;
            int totalnum = 0;
            while (num != 0)
            {
                Console.WriteLine("write a number");
                num = int.Parse(Console.ReadLine());
                totalnum++;
            }
            Console.WriteLine((totalnum- 1));
            */
            /* Uppgift 38
            int num = 1;
            int negativenum = 0;
            while (num != 0)
            {
                Console.WriteLine("write a number");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    negativenum++;
                }
               
            }
            Console.WriteLine("antal negative nummer "+ negativenum);
            */
            /* Uppgift 39
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                Console.WriteLine("write a number");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            Console.WriteLine("your total sum is " + sum);
            */
            /* Uppgift 40
            int num = 1;
            int sum = 0;
            int totalnum = 0;
            while (num != 0)
            {
                Console.WriteLine("write a number");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
                totalnum++;

            }
            Console.WriteLine("your total sum is " + sum);
            Console.WriteLine("the amount of numbers is " + (totalnum- 1));
            */
            /* Uppgift 41
            Console.WriteLine("write first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("write second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine((num1 + num2)*4);
            }
            */
            /* Uppgift 42
            int num = 63;
            Console.WriteLine("Choose N");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 >= num)
            {
                Console.WriteLine("result " + (num - num2));
            }
            else
            {
                Console.WriteLine("result " + (num - num2)*2);
            }
            */
            /* Uppgift 43
            Console.WriteLine("First number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == 23 || num2 == 23)
            {
                Console.WriteLine("True");
            }
            */
            /* Uppgift 44
            Console.WriteLine("number");
            double num = double.Parse(Console.ReadLine());
            if (num%10 == 0)
            {
                Console.WriteLine("True");
            }
            */
            /* Uppgift 45
            Console.WriteLine("String");
            String word = Console.ReadLine();
            if (word[0] == 'i' && word[1] == 'f')
            {

            }
            else
            {
                word = "if " + word;
            }
            Console.WriteLine(word);
            */
            /* Uppgift 46*/
           
            Console.WriteLine("how many numbers?");
            int numbers = int.Parse(Console.ReadLine());
            int[] arr = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("write number " + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine(arr[numbers - 1]);
        }
    }
}
