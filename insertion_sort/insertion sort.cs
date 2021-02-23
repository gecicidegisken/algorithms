class Program
{
    static void Main(string[] args)
    {
        // example array
        int[] array = { 0, 12, 1, 6, 5, 4, 30 };

        //call the function
        Sort(array);

        //show results
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


        Console.ReadLine();
    }


    //sorting function

    public static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++) // traverse through the array
        {
            int key = array[i];   // key element
            int pre = i - 1;      //pre is the one before key

            while (pre >= 0 && key < array[pre]) //go to the very beginning of the array( pre=0) and sort if the key is smaller
            {
                array[pre + 1] = array[pre]; //pre moves to the next index
                pre = pre - 1;              // and new pre is the one before
                                            // loop goes on if the conditions are hold
            }
            array[pre + 1] = key;  //now key moves to its place
        }
    }

}

