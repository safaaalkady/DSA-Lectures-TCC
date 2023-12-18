using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            
            
            while (end >= start)
            {
                int m1 = start + (end - start) / 3;
                int m2 = end - (end - start) / 3;

                if (key == arr[m1]) return m1;
                if (key == arr[m2]) return m2;
                if (key < arr[m1]) return TernarySearch(arr, key, start, m1 - 1);
                if (key > arr[m2]) return TernarySearch(arr, key, m2 + 1, end);
                else
                    return TernarySearch(arr, key, m1 + 1, m2 - 1);
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
                   int r = -1;
        
            while (end>=start)
            {
                int mid = start+ (end - start) / 2;
                if (arr[mid]==key)
                {
                    r = mid;
                    
                    if (is_first)
                    {
                        end = mid - 1;
                       
                    }
                    else
                    {
                        start = mid + 1;
                        
                    } 
                }
                else
                if (arr[mid]<key)
                {
                    start = mid + 1;
                   
                }
                else
                {
                    end = mid -1;
                   
                }
             
                if (is_first && mid == arr.Length - 1)
                {
                    break;
                }
            }
            return r;

        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
             int f = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length);
            int l = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);
            if (f==-1&&l==-1)
            {
                return 0;
            }
            int count = 0;
            for (int i = f; i < l; i++)
            
                if (key == arr[i])
                {
                    count++;
                }
             
          

            if (count > 0)
            {
                return count;
            }
            else return 0;
        }
    }
}
