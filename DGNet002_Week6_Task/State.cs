using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class State
    {
        public static List<string> states = new List<string>()
        {  
           "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", 
            "Benue", "Borno","Cross River", "Delta", "Ebonyi", "Edo", 
            "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", 
            "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", 
            "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", 
            "Sokoto", "Taraba", "Yobe", "Zamfara",
        };
        
       

        public static List<List<string>> GroupStatesInThree()
        {
            var groupedStates = new List<List<string>>();
            
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


    }
}
