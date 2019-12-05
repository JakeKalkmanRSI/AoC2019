using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Days.Day5
{
    public class InstructionFive : Instruction
    {
        
        public InstructionFive(int[] paramModes, List<int> input, ref int currentInstruction) : base(input)
        {
            GetParameters(paramModes, 2, currentInstruction);
            Execute(ref currentInstruction);
        }


        public override void Execute(ref int currentInstruction, int outputPosition = -1)
        {
            if(Parameters[0] != 0)
            {
                currentInstruction = Parameters[1];
            }
            else
            {
                currentInstruction += 3;
            }
        }
    }
}
