using System;
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

    // 1. Declare and initialize a new double array with the given length
        double[] result = new double[length];
        // 2. Loop from 0 up to (but not including) the length.
        for (int i = 0; i < length; i++)

        {

            // Remember: Using comments in your program, write down your process for solving this problem
            // step by step before you write the code. The plan should be clear enough that it could
            // be implemented by another person.
            // 3. For each element, assign the multiple by multiplying the number by (i + 1).
            result[i] = number * (i + 1);
        }
        // 4. Return the populated array.
        return result;
        // replace this return statement with your own
    }





    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
    

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        if (data == null || data.Count <= 1 || amount % data.Count == 0)
        {
           return ;

        }

        int effectiveAmount = amount % data.Count;
         // Handle cases with negative 'amount'
        if (effectiveAmount == 0)

        {
            return;
        }

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        int startIndex = data.Count - effectiveAmount;
        int countToMove = effectiveAmount;

        // Get the sublist that needs to be moved to the front
        List<int> movingPart = data.GetRange(startIndex, countToMove);
         
        // Remove the elements from the end of the original list
        data.RemoveRange(startIndex, countToMove);
        
        // Insert the extracted sublist at the beginning
        data.InsertRange(0, movingPart);
    }

}
