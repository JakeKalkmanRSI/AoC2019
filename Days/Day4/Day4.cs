using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Days.Day4
{
    public class Day4 : Day
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public HashSet<string> validPasswords = new HashSet<string>();
        public Day4()
        {
            var newInput = DefaultInput.Split("-");
            Min = Int32.Parse(newInput[0]);
            Max = Int32.Parse(newInput[1]);

            for (int i = Min; i < Max; i++)
            {
                var iString = i.ToString();

                if (CheckValidPassword(iString))
                {
                    validPasswords.Add(iString);
                }
            }

            Console.WriteLine(validPasswords.Count);
        }


        public bool CheckValidPassword(string password)
        {
            bool digitPair = false;
       

            for (int i = 0; i < password.Length; i++)
            {
                if (i != password.Length - 1)
                {
                    if (password[i] == password[i + 1])
                    {
                        if(password.Count(x => x == password[i]) == 2)
                        {
                            digitPair = true;
                        }              
                    }
                    if (password[i] > password[i + 1])
                    {                      
                        return false;
                    }
                }
            }

            if (digitPair)
            {
                return true;
            }

            return false;
        }
    }
}
