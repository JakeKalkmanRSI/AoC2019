using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Days.Day5
{
    public class InstructionThree : Instruction
    {

        public InstructionThree(int[] paramModes, List<int> input, ref int currentInstruction) : base(input)
        {
            GetParameters(paramModes, 0, currentInstruction);
            Execute(ref currentInstruction, input[currentInstruction + 1]);
        }


        public override void Execute(ref int currentInstruction, int outputPosition = -1)
        {
            Input[outputPosition] = Int32.Parse(Console.ReadLine());
            currentInstruction += 2;
        }
    }
}
