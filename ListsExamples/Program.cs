using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExamples
{
    class Program
    {
        static void Main(string[] args)
        {   //.Length for Arrays
            //.Count for Lists
            //{} when we know the ccontents of our list
            //() when we don't know the contents
            List<int> favNumbers = new List<int>();
            favNumbers.Add(7);
            favNumbers.Add(25);
            favNumbers.Add(30);

            foreach(int number in favNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(favNumbers.Count);
            List<string> books = new List<string> { "Cat in the hat", "Toad and frog", "Green eggs and ham" };
            Console.WriteLine(books[0]);
            //.Insert will insert at the current postion, moving the previous element down one
            books.Insert(0, "Horton hears a Who");
            Console.WriteLine(books[0]);
            //Create a List and add 5 animals using the .Add()
            //Print each animal in the list

            List<string> animals = new List<string> { "Leopard", "Cheetah", "Jaguar", "Lion", "Tiger" };
                     
            foreach(string animal in animals)
            {
                Console.WriteLine(animal);
            }
            List<bool> trueFalse = new List<bool> { true, false, false, true, false };
            foreach(bool items in trueFalse)
            {
                if (items == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today enjoy the sun");
                }
            }
            List<string> favFoods = new List<string> { "steak", "fish", "katsudon", "ice cream", "nachos" };
            if (favFoods.Contains("fish"))
            {
                Console.WriteLine("fish is awesome!");
            }
            else
            {
                Console.WriteLine("go home");
            }

            //create a list with the following numbers : 1, 23, 9, 77, 922, 6, 32, 63, 12, 5
            //use the contains method with the following values :23, 77, 15
            //Remove these elements:23 77 32 6 Look up the remove method
            //use Contains() again on these values: 23, 77, 15
            //My Version
            List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 12, 5 };
            if (numbers.Contains(23, 77, 32,6))
            {
                Console.WriteLine(numbers.Remove(23));
                Console.WriteLine(numbers.Remove(77));
                Console.WriteLine(numbers.Remove(32));
                Console.WriteLine(numbers.Remove(6));

                Console.WriteLine(numbers.Contains(23));
                Console.WriteLine(numbers.Contains(77));
                Console.WriteLine(numbers.Contains(15));
                Console.WriteLine(numbers);
            }
            //Jordan's Version
            List<int> numbas = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 12, 5 };
            numbas.Contains(23);
            numbas.Contains(77);
            numbers.Contains(15);
            numbers.Remove(23);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));
            Console.WriteLine(numbers);
            //Remove at allows you to remove at a specific index
            //.remove you have to do one at a time

            //Ask the user for a movie 
            //If movie isn't in list add it
            //Inform user that movie has been added
            //If movie is in list tell user movie is on its way

            //If user enters quit program should quit
            //loop needed
            //User should be able to add as many movies as they want
            //loop needed
            //When user quits show the, all of the movies that are being ordered
            //cw the list
            Console.WriteLine("Please enter in the name of movie: ");
            string userMovie = Console.ReadLine();
            List<string> movies = new List<string> {"Goose Gander", "The Life of Henry VII","The Grand Hotel", "39 Steps", "Charade"};
            if(!movies.Contains(userMovie))
            {
                movies.Add(userMovie);
            }
            else
            {
                Console.WriteLine("Your movie is on it's way!");
            }

            Console.WriteLine(movies);
         }
    }
}
