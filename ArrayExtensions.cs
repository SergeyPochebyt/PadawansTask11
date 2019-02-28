using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null) throw new ArgumentNullException();
            if (accuracy <= 0 || accuracy >= 1) throw new ArgumentOutOfRangeException();
            if (array.Length == 0) throw new ArgumentException();
            

            for (int i = 0; i < array.Length; i++)
            {
                decimal sum1 = 0;
                decimal sum2 = 0;

                for (int j = 0; j < i; j++)
                {
                    sum1 = sum1 + array[j];
                }

                for (int j = array.Length - 1; j > i; j--)
                {
                    sum2 = sum2 + array[j];
                }

                if (Math.Abs(sum1 - sum2) < accuracy)
                {
                    return i;
                }
            }
            return null;

        }
    }
}
