using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace AdventOfCode.Utilities
{
    public class InputParser
    {
        private readonly string session = "53616c7465645f5f86f1db235ba72cc4d7cc5dc40ddab07ed4a8fe0495c75192e5665176091b8f9b2213a982c9ca3e69";
        private readonly string year = "2019";

        public string DefaultInput { get; set; }
        public List<string> InputList { get; set; }
        public List<int> InputIntList { get; set; }

        public string Day { get; set; }
        public InputParser(string day)
        {
            Day = day;
            ParseDefaultInput();
            ParseInputIntList();
            ParseInputList();
        }


        public void ParseDefaultInput()
        {
            var client = new HttpClient();
            var baseAddress = "https://adventofcode.com";

            client.DefaultRequestHeaders.Add("Cookie", $"session={session}");
            var requestUri = new Uri($"{baseAddress}/{year}/day/{Day}/input");

            DefaultInput = client.GetAsync(requestUri).
                Result.
                Content.
                ReadAsStringAsync().
                Result.
                Trim();
        }

        public void ParseInputList()
        {
            try
            {
                InputList = DefaultInput.
                    Trim().
                    Split("\n").
                    ToList();
            }
            catch (Exception ex)
            {
                var exception = ex;
            }
        }

        public void ParseInputIntList()
        {
            try
            {
                InputIntList = DefaultInput.
                    Trim().
                    Split("\n").
                    Select(x => Int32.Parse(x)).
                    ToList();
            }
            catch(Exception ex)
            {
                var exception = ex;
            }
        }

    }
}
