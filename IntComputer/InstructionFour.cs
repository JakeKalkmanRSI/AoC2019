using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Days.Day5
{
    public class InstructionFour : Instruction
    {

        public InstructionFour(int[] paramModes, List<int> input, ref int currentInstruction) : base(input)
        {
            GetParameters(paramModes, 1, currentInstruction);
            Execute(ref currentInstruction);
        }


        public override void Execute(ref int currentInstruction, int outputPosition = -1)
        {
            Console.WriteLine(Parameters[0]);
            currentInstruction += 2;
        }
    }
}
