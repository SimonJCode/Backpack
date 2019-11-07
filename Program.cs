using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List for items.
            List<string> items = new List<string>(); 

            while(true){
            //Clear console and print menu.
                Console.Clear();
                Console.WriteLine("Välkommen till Ryggsäcken!\n[1]Lägg till ett föremål.\n[2]Visa innehållet.\n[3]Töm senaste föremålet.\n[4]Töm innehållet.\n[5]Avsluta.");
                string input = Console.ReadLine();

            //If input is "1", Let user type an item to put in the items list.
                if(input == "1"){

                    if(items.Count < 6){
                        Console.WriteLine("Vad vill du lägga till i ryggsäcken?");
                        string add = Console.ReadLine();
                        items.Add(add);
                    }
            //If there is more than 6 items in the list, print this message.        
                    else{
                        Console.WriteLine("Ryggsäcken är full!");
                        Console.ReadKey();
                    }
                }
            //If input is "2", Print the items in the items list.    
                else if(input == "2"){
                    Console.WriteLine("Ryggsäcken innehåller:");

                    for(int i = 0; i < items.Count; i++){
                        Console.WriteLine(items[i]);
                    }

                    Console.ReadKey();
                }
            //If input is "3", remove the last added item in the items list.    
                else if(input == "3"){
                    int itemCount = items.Count - 1;
                    Console.WriteLine($"{items[itemCount]} har plockats ur ryggsäcken.");
                    items.RemoveAt(itemCount);
                    Console.ReadKey();
                }
            //If input is "4", remove all items from the items list.
                else if(input == "4"){
                    items.Clear();
                    Console.WriteLine("Ryggsäcken tömd.");
                    Console.ReadKey();
                }
            //If input is "5", return and exit application.
                else if(input == "5"){
                    Console.WriteLine("Ryggsäcken stängd, avslutar applikationen...");
                    return;
                }
           }
        }
    }
}
