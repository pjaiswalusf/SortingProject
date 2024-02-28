int[] randomArray = { 3, 62, 5, 16, 4, 10 };


static void Bubble_Sort(int[] bs_arr)
{
    for (int i = 0; i < bs_arr.Length - 1; i++)
    {
        for (int x = 0; x < bs_arr.Length - i - 1; x++)
        {
            if (bs_arr[x] > bs_arr[x + 1])
            {
                int temp = bs_arr[x];
                bs_arr[x] = bs_arr[x + 1];
                bs_arr[x + 1] = temp;
            }
        } 
    } 
}

Bubble_Sort(randomArray);

Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");

for (int i = 0; i < randomArray.Length; i++)
{
    Console.Write("  " + randomArray[i]);
}
Console.WriteLine("");
