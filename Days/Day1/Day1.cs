using System;

namespace AdventOfCode.Days.Day1
{
    public class Day1 : Day
    {
        public int sum = 0;
        public Day1()
        {
            var watch = DateTime.Now;
            foreach(var line in InputIntList)
            {
                var postMass =  line / 3 - 2;
                if(postMass > 0)
                {
                    sum += postMass;
                    recursiveMassCalculation(postMass);
                }
            }
            var time = (DateTime.Now - watch).TotalMilliseconds;
            Console.WriteLine(sum);
            Console.WriteLine($"Solution took: {time} ms");
        }

        public void recursiveMassCalculation(int postMass)
        {
            var postPostMass = postMass / 3 - 2;

            if (postPostMass > 0)
            {
                sum += postPostMass;
                recursiveMassCalculation(postPostMass);
            }
        }
    }
}
