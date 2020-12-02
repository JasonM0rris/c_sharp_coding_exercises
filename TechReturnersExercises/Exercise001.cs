using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            string capitalizedWord = word.ToUpper();
            return capitalizedWord;
            
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            string firstNameInitial = firstName.Substring(0, 1);
            string lastNameInitial = lastName.Substring(0, 1);

            string nameInitials = firstNameInitial.ToUpper() + " " + lastNameInitial.ToUpper();
            return nameInitials;
        
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            double priceIncludingVAT = originalPrice + originalPrice * vatRate;
            return priceIncludingVAT;
          
        }

        public static String Reverse(String sentence) 
        {
            string reversedString = string.Empty;
            for (int cnt = sentence.Length - 1; cnt >= 0; cnt--)
            {
                reversedString += sentence[cnt];
            }
            return reversedString;
           
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int userCount = users.Count;
            return userCount;
           
        }
    }
    // public class User
    // {
    //     public string Name { get; set; }
    // }
}
