namespace _21_RemoveRepeated
{
    public class Approach1
    {
        public static int[] RemoveRepeated(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return arr;
            }

            List<int> result = new List<int>();
            result.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    result.Add(arr[i]);
                }
            }

            return result.ToArray();
        }
    }
}
