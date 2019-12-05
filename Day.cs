using AdventOfCode.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class Day
    {
        private readonly string day;
        protected readonly InputParser input;
        protected string DefaultInput { get; set; }
        protected List<string> InputList { get; set; }
        protected List<int> InputIntList { get; set; }

        public Day()
        {
            day = this.GetType().Name.Replace("Day","");
            input = new InputParser(day);

            DefaultInput = input.DefaultInput;
            InputList = input.InputList;
            InputIntList = input.InputIntList;
        }

           
    }
}
