using System;
using System.Text.RegularExpressions;

namespace _3_18_Water_Container
{
    public class OptimalWaterContainer
    {
        public WaterContainer CalculateAreaSlow(int[] heights)
        {
            var maxVolume = new WaterContainer();

            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i + 1; j < heights.Length; j++)
                {
                    var area = CalculateAreaOfContainer(heights[i], heights[j], j - i);
                    if (area > maxVolume.Area)
                    {
                        maxVolume.Area = area;
                        maxVolume.LeftWall = heights[i];
                        maxVolume.RightWall = heights[j];
                    }

                }
            }

            return maxVolume;
        }

        private int CalculateAreaOfContainer(int a, int b, int h)
        {
            var min = Math.Min(a, b);
            return min * h;
        }
    }
}