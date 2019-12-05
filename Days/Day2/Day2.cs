using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Days.Day5;

namespace AdventOfCode.Days.Day2
{
    public class Day2 : Day
    {
        public Day2()
        {
            var computer = new IntComputer(DefaultInput);
            computer.RunProgramDay2Part1();
            computer.RunProgramDay2Part2();
        }    
    }
}
