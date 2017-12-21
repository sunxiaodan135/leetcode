using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaisupaisu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 49, 50,51,2,1};
            Quicksort(b, 0, b.Length - 1);
            shuchu(b, "最终");
            Console.ReadKey();
        }
        public static int   QSort(int[] a, int low, int high)
        {
            //ChoosePivotkey(a, low, high);

            int p = a[low];
           if (low < high)
            {
               
                while (low < high && a[high] >= p)  high--;
		        shuchu(a, "a[high] = a[low]之前");
                a[low] = a[high];
                shuchu(a, "a[high] = a[low]之后");

                while (low < high && a[low] <= p) low++;
                
                a[high] = a[low];


            }
           
            a[low] = p;
            shuchu(a,"此次结束");
            return low ;

        }
        public static  void Quicksort(int[] a, int low, int high)
        {
            if (low < high)
            {
                
                int pp = QSort(a, low ,high);
                Quicksort(a, low , pp-1);
                Quicksort(a,pp+1, high);

            }


        }
        public static void swap(int[] a, int low, int high) {
            int temp = a[low];
            a[low] = a[high];
            a[high] = temp; 


        }
        public static void shuchu(int []a,string s) {
            Console.Write(s + ": ");
            foreach (int i in a)
            {

                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void ChoosePivotkey(int[] arr, int low, int high)
        {
            int mid = low + (int)(high - low) / 2;
            if (arr[low] > arr[high])
            {//保证左端较小
                swap(arr, low, high);
            }
            if (arr[mid] > arr[high])
            {//保证中间较小
                swap(arr, mid, high);
            }
            //此时最大值在最右边
            if (arr[mid] > arr[low])
            {//保证中间较小
                swap(arr, mid, low);
            }
        }
    }
}
