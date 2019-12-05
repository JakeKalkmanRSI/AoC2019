using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode.Days.Day5
{
    public class IntComputer
    {
        public int Noun { get; set; }
        public int Verb { get; set; }
        public string DefaultInput { get; set; }
        public List<int> Input { get; set; }
        public int Output { get; set; }

        public int expectedOutputDay2Part2 = 19690720;
        public int currentInstruction = 0;

        public IntComputer(string defaultInput)
        {
            DefaultInput = defaultInput;
            ResetInput();
        }

        public void RunProgramDay2Part1()
        {
            Verb = 2;
            Noun = 12;

            SetProgramsVerbNoun();

            while (currentInstruction < Input.Count())
            {
                var result = RunInstruction();
                Output = Input[0];

                if (!result)
                {
                    ResetInput();
                    break;
                }
            }

            Console.WriteLine($"Part 1 Solution: {Output}");
        }

        public void RunProgramDay2Part2()
        {
            Verb = 0;
            Noun = 0;

            while (true)
            {
                while (currentInstruction < Input.Count())
                {
                    SetProgramsVerbNoun();
                    var result = RunInstruction();
                    Output = Input[0];
                    if (!result)
                    {
                        break;
                    }
                }

                if (Output == expectedOutputDay2Part2)
                {
                    Console.WriteLine($"Part 2 Solution: {100 * Noun + Verb}");
                    break;
                }
                else
                {
                    ResetInput();
                    IncrementVerbNoun();
                }
            }
        }

        public void RunProgramDay5()
        {
            while (currentInstruction < Input.Count())
            {
                var result = RunInstruction();
                Output = Input[0];

                if (!result)
                {
                    ResetInput();
                    break;
                }
            }
        }

        public void ResetInput()
        {
            Input = DefaultInput.Split(",").Select(x => Int32.Parse(x)).ToList();
            currentInstruction = 0;
        }

        public void SetProgramsVerbNoun()
        {
            Input[1] = Noun;
            Input[2] = Verb;
        }

        public void IncrementVerbNoun()
        {
            if (Verb < 99)
            {
                Verb++;
            }
            if (Verb == 99)
            {
                Verb = 0;
                Noun++;
            }
        }

        public bool RunInstruction()
        {
            var opcode = new Opcode(Input[currentInstruction]);

            if (opcode.Instruction == 99)
            {
                return false;
            }

            switch (opcode.Instruction)
            {
                case 1:
                    new InstructionOne(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 2:
                    new InstructionTwo(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 3:
                    new InstructionThree(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 4:
                    new InstructionFour(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 5:
                    new InstructionFive(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 6:
                    new InstructionSix(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 7:
                    new InstructionSeven(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                case 8:
                    new InstructionEight(opcode.ParameterModes, Input, ref currentInstruction);
                    break;
                default:
                    break;
            }

            return true;
        }




        public class Opcode
        {
            public int[] ParameterModes { get; set; }
            public int Instruction { get; set; }

            public Opcode(int unparsedOpcode)
            {
                var stringOpcode = unparsedOpcode.ToString();

                Instruction = unparsedOpcode % 100;

                if (stringOpcode.Length <= 2)
                {
                    ParameterModes = new int[0];
                }

                else
                {
                    var paramModeString = stringOpcode.Substring(0, stringOpcode.Length - 2).Reverse();

                    ParameterModes = paramModeString.Select(x => Int32.Parse(x.ToString())).ToArray();
                }

            }

        }
    }
}
