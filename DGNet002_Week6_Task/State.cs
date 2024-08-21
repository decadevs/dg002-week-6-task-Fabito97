using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class State
    {
        static List<string> states = new List<string>()
        {  
           "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", 
            "Benue", "Borno","Cross River", "Delta", "Ebonyi", "Edo", 
            "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", 
            "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", 
            "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", 
            "Sokoto", "Taraba", "Yobe", "Zamfara",
        };
        
        static List<List<string>> groupedStates = GroupStatesInThree();

        static ILookup<char, string> groupedStatesByFirstChar = GroupByFirstCharacter(states);

        public static List<List<string>> GroupStatesInThree()
        {
            groupedStates = new List<List<string>>();
            
            for (int i = 0; i < states.Count; i += 3)
            {
                List<string> group = states.Skip(i).Take(3).ToList();

                groupedStates.Add(group);
            }
            return groupedStates;
        }                

        public static ILookup<char, string> GroupByFirstCharacter(List<string> states)
        {
            var groupedStates = states.ToLookup(state => state[0]);
            return groupedStates;            
        }


        public static void PrintStates()
        {
            Console.WriteLine("\nA Group of states in set of 3:\n");
            Console.WriteLine("--------------------------------");
            foreach (var group in groupedStates)
            {
                Console.WriteLine($"\n{string.Join(", ", group)}");
                Console.WriteLine("\n------------------------------");
            }
        }

        public static void PrintStatesByFirstChar()
        {
            foreach (var group in groupedStatesByFirstChar)
            {
                Console.WriteLine($"\nGroup {group.Key} - {group.Count()}:");
                Console.WriteLine("\n\t------------");
                
                Console.WriteLine($"\n\t{string.Join(", ", group)}");               
            }
        }
    }
}
