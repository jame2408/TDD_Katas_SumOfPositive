using System.Linq;

namespace TestSumOfPositive
{
    public class SumOfPositive
    {
        public int AddPositive(int[] ints)
        {
            return ints.Where(x => x >= 0).Sum();
        }
    }
}