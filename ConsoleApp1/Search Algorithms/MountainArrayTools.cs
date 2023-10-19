using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations {
    internal class MountainArrayTools {
        public static int PeakIndex(int[] arr) {
            int high = arr.Length - 1;
            int low = 0;
            while(low <= high) {
                int midPoint = ( low + high ) / 2;
                int point = arr[midPoint];
                int nextElement = arr[midPoint + 1];
                if(point > nextElement) {
                    int prevElement = arr[midPoint - 1];
                    if(point > prevElement) {
                        return midPoint;
                    }
                    high = midPoint - 1;
                } else if(point < nextElement) {
                    low = midPoint + 1;
                } else {
                    return 0;
                }
            }
            return 0;
        }
        public static int ReverseBinarySearch(int target, int[] arr, int peak) {
            int high = peak + 1;
            int low = arr.Length - 1;
            while(low >= high && high > peak) {
                int midPoint = ( low + high ) / 2;
                int point = arr[midPoint];
                if(point > target) {
                    high = midPoint + 1;
                } else if(point < target) {
                    low = midPoint - 1;
                } else {
                    return midPoint;
                }
            }
            return -1;
        }
    }
}
