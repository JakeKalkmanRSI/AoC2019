using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Days.Day5
{
    public class InstructionSeven : Instruction
    {
        
        public InstructionSeven(int[] paramModes, List<int> input, ref int currentInstruction) : base(input)
        {
            GetParameters(paramModes, 2, currentInstruction);
            Execute(ref currentInstruction, input[currentInstruction + 3]);
        }


        public override void Execute(ref int currentInstruction, int outputPosition = -1)
        {
            if(Parameters[0] < Parameters[1])
            {
                Input[outputPosition] = 1;
            }
            else
            {
                Input[outputPosition] = 0;
            }

            currentInstruction += 4;
        }
    }
}
