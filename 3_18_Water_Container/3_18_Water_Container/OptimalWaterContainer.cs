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
                        maxVolume.LeftWallHeigth = heights[i];
                        maxVolume.RightWallHeigth = heights[j];
                    }

                }
            }

            return maxVolume;
        }

        public WaterContainer CalculateAreaFast(int[] heights)
        {
            //Init
            var maxVolume = new WaterContainer();

            if (heights.Length < 2)
                return maxVolume;

            int a = 0;
            int b = heights.Length - 1;
            maxVolume.Area = CalculateAreaOfContainer(heights[a], heights[b], b);
            maxVolume.LeftWallHeigth = heights[a];
            maxVolume.RightWallHeigth = heights[b];

            //walk
            while (a < b)
            {
                if (heights[a] < heights[b])
                    a++;

                else
                    b--;

                var s = CalculateAreaOfContainer(heights[a], heights[b], b - a);
                if (s > maxVolume.Area)
                {
                    maxVolume.Area = s;
                    maxVolume.LeftWallHeigth = heights[a];
                    maxVolume.RightWallHeigth = heights[b];
                }
            }

            return maxVolume;
        }

        private int CalculateAreaOfContainer(int leftWallHeight, int rightWalHeight, int distanceBetweenWalls)
        {
            var min = Math.Min(leftWallHeight, rightWalHeight);
            return min * distanceBetweenWalls;
        }
    }
}