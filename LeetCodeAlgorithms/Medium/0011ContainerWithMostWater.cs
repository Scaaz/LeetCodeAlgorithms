namespace LeetCodeAlgorithms.Medium
{
    internal class _0011ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {


            }

            return maxArea;
        }
        //public int MaxArea(int[] height)
        //{
        //    var maxArea = 0;
        //    var currenArea = 0;
        //    for (int i = 0; i < height.Length; i++)
        //    {                
        //        for (int j = 0; j < height.Length; j++)
        //        {

        //            if (height[i] > height[j])
        //            {
        //                //j mniejsze
        //                currenArea = height[j] * Math.Abs(i - j); 
        //            }
        //            else
        //            {
        //                currenArea = height[i] * Math.Abs(i - j);
        //            }

        //            if(currenArea > maxArea)
        //            {
        //                maxArea = currenArea;
        //            }
        //        }
        //    }
        //    return maxArea;
        //}



        [Test]
        public void TestCase()
        {
            var result = MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            var expectedResult = 49;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = MaxArea([1, 1]);
            var expectedResult = 1;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
