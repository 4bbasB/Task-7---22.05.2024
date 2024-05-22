namespace Task_7___22._05._2024
{
    public class ArrayResize
    {
        public static void Resize(ref int[] arr, int newSize)
        {
            if (newSize < 0)
            {
                Console.WriteLine("Arrayin uzunlugu menfi ola bilmez!");
                newSize = 0;
            }

            int[] newArr = new int[newSize];
            
            if (arr.Length != newSize)
            {
                for (int i = 0; i < newSize && i < arr.Length; i++)
                    newArr[i] = arr[i];
                arr = newArr;
            }

            foreach (int i in arr)
                Console.Write(i + " ");

        }
    }
}
