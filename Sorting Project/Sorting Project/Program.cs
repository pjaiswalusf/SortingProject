/*
Author: Pratik Jaiswal -- edited by Arpan Jaiswal
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
    Selection Sort and Bubble Sort Algorithms. No input
    is required for the script. It will execute without 
    input against two pre-populated arrays. 
*/

// We have a static array for our algorithm
int[] randomArray = { 3, 62, 5, 16, 4, 10 };

/* Method which does performs the bubble sort 
    param:
        int[] bs_arr : the int array that has to be sorted
    return:
        void: it performs changes into the param arrray
 */
static void Bubble_Sort(int[] bs_arr)
{
    for (int i = 0; i < bs_arr.Length - 1; i++)
    {
        for (int x = 0; x < bs_arr.Length - i - 1; x++)
        {
            // In each nested for loop iteration check to see if the next element value is lower than the current element value
            // If the next element value is less, then conduct the swap
            if (bs_arr[x] > bs_arr[x + 1])
            {
                // Here you will swap temp and bs_arr[x]
                // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
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
