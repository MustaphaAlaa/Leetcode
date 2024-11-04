namespace Problem_Solving.BinarySearch;

public class BinarySearch_74
{
    public static bool BinarySearch(int[] arr, int target)

    {
        if (arr.Length == 0)
            return false;

        int start = 0, end = arr.Length - 1;
        int mid = start + (end - start) / 2;
        int operationCount = 0;
        while (start <= end)
        {
            operationCount++;
            if (arr[mid] == target)
                return true;
            else if (arr[mid] < target)
            {
                start = mid + 1;
                mid = start + (end - start) / 2;
            }
            else
            {
                end = mid - 1;
                mid = start + (end - start) / 2;
            }
        }

        return false;

    }



    public static bool SearchMatrix(int[][] matrix, int target)

    {
        if (matrix.Length == 0)
            return false;

        int start = 0, end = matrix.Length - 1;
        int mid = start + (end - start) / 2;
        int operationCount = 0;
        while (start <= end)
        {
            operationCount++;
            if (matrix[mid][0] == target)
                return true;
            else if (matrix[mid][0] < target)
            {


                if (target >= matrix[mid][0] &&
                    target <= matrix[mid][matrix[mid].Length - 1])
                
                   return BinarySearch(matrix[mid], target);

               
               



                start = mid + 1;
                mid = start + (end - start) / 2;
            }
            else
            {
                end = mid - 1;
                mid = start + (end - start) / 2;
            }
        }

        return false;

    }



}