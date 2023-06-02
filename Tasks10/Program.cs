internal class Program
{
    private static void Main(string[] args)
    {
        //string[] mass = Console.ReadLine().Split(' ');
        //int[] arr = new int[mass.Length];

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = int.Parse(mass[i]);
        //}
        //var array = SelectionSort(arr);
        //foreach (var item in array)
        //{
        //    Console.Write(item+" ");
        //}



        //string[] mass = Console.ReadLine().Split(' ');
        //int[] arr = new int[mass.Length];

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = int.Parse(mass[i]);
        //}
        //var array = BubbleSort(arr);
        //foreach (var item in array)
        //{
        //    Console.Write(item + " ");
        //}


        string[] mass = Console.ReadLine().Split(' ');
        int[] arr = new int[mass.Length];

        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = int.Parse(mass[i]);
        }
        var array = InsertionSort(arr);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.ReadLine();
    }
    public static int[] SelectionSort(int[] array)
    {
        int minindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            minindex = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[minindex])
                {
                    minindex= j;
                }
            }
            int swap = array[i];
            array[i] = array[minindex];
            array[minindex] = swap;
        }

        return array;
    }

    public static int[] BubbleSort(int[] array)
    {
        int swap = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    swap = array[i];
                    array[i] = array[j];
                    array[j] = swap;
                }
            }
        }

        return array;
    }

    public static int[] InsertionSort(int[] array)
    {
        int key,j;

        for (int i = 0; i < array.Length; i++)
        {
            key = array[i];
            j = i - 1;

            while (j>=0 && array[j]>key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }

        return array;
    }
}