using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;

namespace AdventOfCode.Days.Day3
{
    public class Day3 : Day
    {
        public List<List<Point>> wires = new List<List<Point>>();


        public Day3()
        {

            foreach (var line in InputList)
            {
                var listOfDirections = line.Split(",");
                List<Point> wire = new List<Point>();
                wire.Add(new Point(0, 0));

                foreach (var direction in listOfDirections)
                {
                    var currentPoint = wire.Last();
                    var heading = direction[0];
                    var steps = Int32.Parse(direction.Remove(0, 1));

                    switch (heading)
                    {
                        case 'R':
                            for (int i = 0; i < steps; i++)
                            {
                                currentPoint = new Point(currentPoint.X + 1, currentPoint.Y);
                                wire.Add(currentPoint);
                            }
                            break;
                        case 'U':
                            for (int i = 0; i < steps; i++)
                            {
                                currentPoint = new Point(currentPoint.X, currentPoint.Y + 1);
                                wire.Add(currentPoint);
                            }
                            break;
                        case 'D':
                            for (int i = 0; i < steps; i++)
                            {
                                currentPoint = new Point(currentPoint.X, currentPoint.Y - 1);
                                wire.Add(currentPoint);
                            }
                            break;
                        case 'L':
                            for (int i = 0; i < steps; i++)
                            {
                                currentPoint = new Point(currentPoint.X - 1, currentPoint.Y);
                                wire.Add(currentPoint);
                            }
                            break;
                        default:
                            break;

                    }
                }

                wires.Add(wire);
            }
            var intersections = wires[0].Intersect(wires[1]);


            var part1 = wires[0].Intersect(wires[1]).Select(c => Math.Abs(c.X) + Math.Abs(c.Y)).Where(x => x != 0).Min();
            var part2 = wires[0].Intersect(wires[1]).Where(p => p.X != 0 && p.Y != 0).Select(p => wires[0].IndexOf(p) + wires[1].IndexOf(p)).OrderBy(i => i).First();

            Console.WriteLine($"Part 1 Solution: {part1}");
            Console.WriteLine($"Part 2 Solution: {part2}");

        }


        

       
    }
}
