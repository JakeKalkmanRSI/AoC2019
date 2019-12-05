using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Days.Day5
{
    public abstract class Instruction
    {
        protected int[] Parameters { get; set; }
        protected List<int> Input { get; set; }
        public Instruction(List<int> input)
        {
            Input = input;
        }

        protected void GetParameters(int[] parameterModes, int paramNumber, int currentInstruction)
        {           
            Parameters = new int[paramNumber];
            
            for (int i = 0; i < paramNumber; i++)
            {
                Parameters[i] = parameterModes.Length > i && parameterModes[i] != 0 ? Input[currentInstruction + i + 1] : Input[Input[currentInstruction + i + 1]];
            }
        }
        public abstract void Execute(ref int currentInstruction, int outputPosition = -1);
    }
}
