using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.ArrayImplementation
{
    class MergeSortedArrays
    {
        public int[] firstSortedArray ;
        public int[] secondSortedArray;

        public MergeSortedArrays(int[] sortedArrayValueFirst, int[] sortedArrayValueSecond)
        {
            this.firstSortedArray = sortedArrayValueFirst;
            this.secondSortedArray = sortedArrayValueSecond;

        }

        public string getSingleSortedList()
        {
            int firstListLength = firstSortedArray.Length;
            int secondListLength = secondSortedArray.Length;

            int[] returnitem = new int[firstListLength + secondListLength];
            int i = 0, j = 0, k = 0;
            
            while (i < firstListLength && j < secondListLength)
            {
                if (firstSortedArray[i] < secondSortedArray[j]) 
                     returnitem[k++] = firstSortedArray[i++];
                else
                     returnitem[k++] = secondSortedArray[j++];

            }

            while (i < firstListLength)
                returnitem[k++] = firstSortedArray[i++];

            while ( j < secondListLength)
                returnitem[k++] = secondSortedArray[i++];
             
            string returnListItem = "";
            for (int l = 0; l< returnitem.Length; l++)
                returnListItem += returnitem[l] + ",";

            return returnListItem.Trim().Length > 0 ? returnListItem.Remove(returnListItem.LastIndexOf(",")) : "";
        }
    }
}
