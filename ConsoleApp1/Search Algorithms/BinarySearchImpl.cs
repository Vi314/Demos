using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations {
    public static class BinarySearchImpl {
        public static int BinarySearch(int[] arr, int num) {
            int low = 0;
            int high = arr.Length - 1;
            int middle = 0;
            while(low <= high) {
                middle = ( low + high ) / 2;
                if(arr[middle] > num) {
                    high = middle - 1;
                } else if(arr[middle] < num) {
                    low = middle + 1;
                } else {
                    return middle;
                }
            }
            return 0;
        }
        public static int BinarySearchWithSort(int[] arr, int num) {
            Array.Sort(arr);
            int low = 0;
            int high = arr.Length - 1;
            int middle = 0;
            while(low <= high) {
                middle = ( low + high ) / 2;
                if(arr[middle] > num) {
                    high = middle - 1;
                } else if(arr[middle] < num) {
                    low = middle + 1;
                } else {
                    return middle;
                }
            }
            return 0;
        }
    }
}
