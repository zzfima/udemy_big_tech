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
                    var area = CalculateAreaOfTrapezoid(heights[i], heights[j], j - i);
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

        private int CalculateAreaOfTrapezoid(int a, int b, int h) => (a + b) * h / 2;
    }

    public class WaterContainer
    {
        public int LeftWall { get; set; }
        public int RightWall { get; set; }
        public int Area { get; set; }
    }
}
