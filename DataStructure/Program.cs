﻿using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.ArrayImplementation;
namespace DataStructure
{
    class Program
    {
         
        public readonly string[] nemo = {"nemo","Demo"};
        public string[] nameList = new string[10000];

        Program()
        {       
                for (int i=0; i < nameList.Length; i++){
                    this.nameList[i] = "nemo";
                }
        }

        const string nemo2= "nemo";

        public  void  findNemo(string[] array){
             
             for(int i=0; i < array.Length; i++){
                 if(array[i] == "nemo"){
                     Console.WriteLine("Found Nemo !");
                 }
             }
        }

        public  void  findNemo2(string nemo2){
          
             if(nemo2 == "nemo"){
                     Console.WriteLine("Found Nemo 2 !");
             }

        }

        public void numberTree(int n)
        {
            for(int i=n; i >=1 ; i--)
            {
                for(int j=1; j <=i ; j++)
                {
                   Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        public bool hasNumberWithPairForSortedList(int[] numList, int sum)
        {
            int low = 0;
            int high = numList.Length - 1;

            while(low < high)
            {
                 int sumOfLowHigh = numList[low] + numList[high];

                 if(sumOfLowHigh == sum) 
                 {
                    Console.WriteLine("Pair Element : " + numList[low] + ", " + numList[high]);
                    return true;
                 }
                 else if (sumOfLowHigh > sum) high--;
                 else if (sumOfLowHigh < sum) low++;
                 
            }
            return false;
        }
         public bool hasNumberWithPairForUnsortedList(int[] numList, int sum)
        {
            int low = 0;
            int high = numList.Length - 1;
            SortedList complementList = new SortedList();

            while(low < high)
            {
                 int complementItem = sum - numList[low];

                
                 if(complementList.ContainsKey(numList[low])) 
                 {
                    int complementIndex = (int)complementList[numList[low]];
                    Console.WriteLine("Pair Element : " + numList[low] + ", " + numList[complementIndex]);
                    return true;
                 }
                 complementList.Add(complementItem,low);
                 low++;
                 
            }
            return false;
        }

        public static void Main(string[] args)
        {
            //Program objProgram = new Program();

            // Console.WriteLine("Hello Earth!");
            // objProgram.findNemo(objProgram.nameList);
            // objProgram.findNemo2(Program.nemo2);

            //objProgram.numberTree(3);
            //bool pairExist;
            // pairExist = objProgram.hasNumberWithPairForSortedList(new int[]{-1,1,2,3,4,5,5,6,8,9},7);
            // Console.WriteLine("Pair Exist : "+pairExist);
            // pairExist = objProgram.hasNumberWithPairForUnsortedList(new int[]{-1,1,2,6,5,5,8,9,7,3,4},10);
            // Console.WriteLine("Pair Exist : "+pairExist);

            DynamicArray objArray = new DynamicArray();
            objArray.push(23);
            objArray.push("Hi");
            objArray.push("Hello");
            objArray.push("Bye");
            objArray.push("Love");
            objArray.push("India");
            Console.WriteLine("Length - " + objArray.length);
            Console.WriteLine("Popped Item - " + objArray.pop());
            Console.WriteLine("Popped Item - " + objArray.pop());
            Console.WriteLine("Length - "+ objArray.length);
            Console.WriteLine("delete Item - " + objArray.delete(2));
            Console.WriteLine("delete Item - " + objArray.delete(0));
            Console.WriteLine("Popped Item - " + objArray.pop());
            Console.WriteLine("delete Item - " + objArray.delete(0));
            Console.WriteLine("Length - " + objArray.length);
            Console.WriteLine("Array - " + objArray.toString());

            ReverseString objReverseString = new ReverseString("Hi My Name is Somnath Singh");
            Console.WriteLine("Reverse String : " + objReverseString.reverseString());

            MergeSortedArrays objMergedSortedArray = new MergeSortedArrays(new int[] { 0, 2, 3, 4, 31 }, new int[] { -2, 4, 6, 30 });

            Console.WriteLine("Single Sorted List : " + objMergedSortedArray.getSingleSortedList());
        }
    }
}
