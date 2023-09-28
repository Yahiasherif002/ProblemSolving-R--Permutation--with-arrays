internal class Program
{
    static bool permutationArray(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;   
        int n2 = arr2.Length;
        if (n1 != n2)
        {
            return false;
        }
        Array.Sort(arr1);
        Array.Sort(arr2);
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }

        }
        return true;
    }
    static void arrRead(int[] arr,int n1)
    {
        string[] input1 = Console.ReadLine().Split(' ');
        for (int i = 0; i < n1; i++)
        {
            arr[i] = int.Parse(input1[i]);
        }
    }
    private static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        int[] arr2 = new int[n1];
        arrRead(arr1, n1);
        arrRead(arr2, n1);
        if (permutationArray(arr1, arr2))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
       



    }
}