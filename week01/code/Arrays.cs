public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //new array variable to return at end
        double[] multipleArray = new double[length];

        //new variable to hold multipliers in loop, starts at 1, named 'newMultiple'
        double newMultiple = 1;

        //new variable to act as loop counter named 'loopCount'
        int loopCount = 1;

        //while loop that ends when 'length' variable is reached
        while (loopCount <= length)
        {

            //inside loop, start with 1 multiplied by 'number'
            //inside loop, replace 'newMultiple' for next time through loop
            newMultiple = loopCount * number;

            //get index
            int index = loopCount - 1;

            //inside loop, add newMultiple to array
            multipleArray[index] = newMultiple;

            //inside loop, add 1 to 'loopCount'
            loopCount++;

        }

        return multipleArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //add counter to iterate loop until 'amount' is reached
        int loopCount = 1;

        //get index of last value in array
        int lastIndex = data.Count - 1;

        //while loop, iterates until 'amount' is reached
        while (loopCount <= amount)
        {

            //get value of last in array
            int value = data[lastIndex];

            //remove last value
            data.RemoveAt(lastIndex);

            //add the value that was just removed to beginning of array
            data.Insert(0, value);

            //add to loop counter
            loopCount++;

        }
    }
}
