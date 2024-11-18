namespace Assignment_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] arrayInput = { 0, 2, 1, 1, 9, 1, 1 };
			int[] array = {0, 2, 1, 1, 9, 1, 1 };

			Console.WriteLine("Original array:");
			Console.WriteLine($"[" + string.Join(", ", arrayInput) + "]");

			Console.WriteLine("Array changing the first occurrence of 2 consecutive 1s and changing their value to 0:");
			ChangeOnesToZeros(array); 
			Console.WriteLine($"[" + string.Join(", ",array) + "]");
		}
		static void ChangeOnesToZeros(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i] == 1 && array[i + 1] == 1)
				{
					array[i] = 0;
					array[i + 1] = 0; 
					break;
				} 
			}				
		}
    }
}
