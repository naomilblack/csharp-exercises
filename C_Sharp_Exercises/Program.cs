using System;
using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.w3resource.com/csharp-exercises/array/index.php
           Plant bigSnake = new Plant("mother", "green", 3);

            bigSnake.age = 2;
            bigSnake.indoor = true;
            bigSnake.name = "Long Legs";
            bigSnake.discount = .10M;
            bigSnake.price = 20;
            bigSnake.tax = .06M;

            Console.WriteLine(bigSnake.getPrice()); //math is off shows a decimal. need to fix method.

            Console.WriteLine(bigSnake.getBasicInfo());

            Plant rattleSnake = new Plant("succulent", "lightgreen", 2);
            Console.WriteLine(rattleSnake.getBasicInfo());
//remember index out of bounds means that you created an index or array line number that shouldn't be there!
            string[] birds = new string[3];

            birds[0] = "red";
            birds[1] = "yellow and gold";
            birds[2] = "grey and white";

            for (int i = 0; i< birds.Length; i++)
            {
                    // Console.WriteLine(birds);
                    Console.WriteLine(String.Join("\n",birds));
            }

            int[] dino ={12, 3, 4, 6, 2};
            dino[0] = 2;
            Console.WriteLine(dino[0] + dino[2]);
            //return dino[0];

            //think of it as replacing the middle operator or joining two together.
            int k = 5;
            k +=2;
            Console.WriteLine(k);
            // Output: 14

            string[] curtains =  {"hey"};

            Console.WriteLine(curtains[0]);

            //stores items in an array.
            List<int> coats = new List<int>() {1, 10, 100};
            Console.WriteLine(String.Join("\n",coats));
            Console.WriteLine(String.Join("",coats[0]," ",coats[1]," ",coats[2]));

            string[] doors = {"hi", "red", "yellow", "green"};

            for(int i = 0; i< doors.Length; i++)
            {
                Console.WriteLine(String.Join("",doors[i]));
                // Console.WriteLine();
            }


            int[] backyard = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            for(int i=0; i<backyard.Length; i++)
            {
            // int tree;
            // tree = Convert.ToInt32(Console.ReadLine());

            if(backyard[i]< 100)
            {
            Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Nope");
            }
            // Console.WriteLine(String.Join("",backyard[i]));
            }



            int a = 5;
            int b = 7;
            int c = 20;

            if (a > c )
            {
                Console.WriteLine($"{a} is greater than{c}.");
            }
            else if(b >a)
            {
                Console.WriteLine($"{b} is greater than {a}.");
            }
            else if (c > 100)
            {
                Console.WriteLine($"{c} is greater than 100.");
            }

            else
            {
                Console.WriteLine($"Here are your numbers{a}, {b}, {c}.");
            }

            string name;
            Console.WriteLine("Tell me your name");

            name = Console.ReadLine();

            Console.WriteLine($"Hello {name} let's do a few loops");

            Console.WriteLine(new int[] {100, 330, 22, 4}.Sum());



            List <int> chairs = new List<int>() {1, 22, 3};


            Console.WriteLine(new int[] {22, 33, 33333, 5}.Sum());

            List<int> chocoloate = new List<int>(){};

            int[] laps ={2, 2, 2, };

            for(int i =0; i< laps.Length; i++)
            {
                    Console.WriteLine(String.Join("", laps[i]));
            }
        }
    }
}
