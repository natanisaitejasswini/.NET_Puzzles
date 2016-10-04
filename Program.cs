using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {

       //Find max
        public static void findMax(int[] array)
        {
            int max = array[0];

            foreach (int num in array)
            {
                if ((int)max < (int)num )
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum number in this array is {0}", max);
        }

        //Find min
        public static void findMin(int[] array)
        {
            int min = array[0];

            foreach (int num in array)
            {
                if ((int)min > (int)num )
                {
                    min = num;
                }
            }

            Console.WriteLine("Minimum number in this array is {0}", min);
        }

        //find sum
        public static int sum(int[] array)
        {
            int sum = 0;
            foreach(int num in array)
            {
                sum += num;
            }
            return sum;
        }

        // random array
        public static object randomArr()
        {
            int[] array = new int[10];
            Random rnd1 = new Random();
            // Generating Random Numbers and placing into array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd1.Next(10,25);                
            }
           Console.WriteLine(string.Join(", ", array)); // Prints formed random array
            findMax(array);
            findMin(array);            
            return sum(array);
            
        }

        // Coin Flip Functions Starts
        public static string Toss_Coin()
        {
            string[] coin = new string[2] {"Head","Tail"}; // Coin is defined here
            // Tossing a coin by a random generator so that it may point to 0 or 1
            Random generate_rand = new Random();
            int rand = generate_rand.Next(2);
            return coin[rand];
        }

        // TossMultipleCoins Functions
        public static double TossMultipleCoins(int num)
        {
            string[] game = new string[num];  // Array will be size of passed parameter
            for(int i= 0; i < num; i++)
            {
                game[i] = Toss_Coin();
            }
            Console.WriteLine(string.Join(", ", game));
            int count = 0 ; // To count sides of Head in game array
            foreach(string flip in game)
            {
                if(flip == "Head")
                {
                    count ++;
                }
            }
            double result = count/num;  // Calculating Avg of heads got for num of tosses passed
            Console.WriteLine("Avg No.of Heads are printed below");
            return result;
        }

        // Names Puzzle
        public static string names_puzzle()
        {
            string[] names = new string[5]{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string [] new_names = new string[5];
            Random generate_idx = new Random();  
            int j = names.Length;
            while(j > 0)
            {
                int idx = generate_idx.Next(5); 
                if (!Array.Exists(new_names, element => element == names[idx])) // Checking placed elements in new_names, matches next idx's values
                {
                        new_names[j-1] = names[idx];
                        j--;
                }
            }
             Console.WriteLine("Shuffled Array");
             Console.WriteLine(string.Join(", ", new_names));

             //Return the array that only includes names longer then 5 characters
             int count = 0;
             foreach (string item in new_names)
             {
                 if(item.Length > 5)
                 {
                    count ++ ;
                 }
             }

             // Actual inserting into an array
             string[] result_names = new string[count];
             int k = 0;
             foreach(string item in new_names)
             {
                 if(item.Length>5)
                 {
                     result_names[k] = item;
                     k ++;
                 }
             }
             Console.WriteLine("Below Array returns only the names above 5Chars");
             return string.Join(", ", result_names);
        }
        
        // Invoking Functions
        public static void Main(string[] args)
        {
            //For Random Array
            object Random_Array = randomArr();
            Console.WriteLine(Random_Array);
            // For single flip
            object coin = Toss_Coin();
            Console.WriteLine(coin);
            //For multiple Flips
            object multi_game = TossMultipleCoins(3);
            Console.WriteLine(multi_game);
            // For Names Puzzle
            Console.WriteLine(names_puzzle());
        }
    }
}
