using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode.Days.Day5
{
    public class Day5 : Day
    {
        public Day5()
        {
            var computer = new IntComputer(DefaultInput);

            computer.RunProgramDay2Part1();
        }
    }
}
