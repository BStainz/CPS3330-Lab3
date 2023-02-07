using System;
namespace Lab3Lib;
public class Min //last digit of kean ID is 3
    {   
        public static int MinOf2(int a, int b){
            return Math.Min(a,b);
    }
        public static int MinOf3(int a, int b, int c){
            int min = Math.Min(Math.Min(a,b),c);
            return min;
    }
   //Brendan Hannon CPS 3330 SPRING 2023 LAB #3
}
