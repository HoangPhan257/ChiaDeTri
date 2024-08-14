using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] A = { 2, 5, 8, 12, 16, 72, 91 };
        int n = A.Length;
        int key = 16;

        int result = Binary_Search(A, n, key);

        if (result == -1)
        {
            Console.WriteLine("Không tìm thấy {0} trong mảng", key);
        }
        else
        {
            Console.WriteLine("Vị trí của {0} trong mảng là: {1}", key, result);
        }
        Console.ReadLine();

    }
    static int Binary_Search(int[] A, int n, int key)
    {
        int left = 0;
        int right = n - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (A[mid] == key)
            {
                return mid;
            }
            else if (key < A[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1; // Không tìm thấy key trong mảng
    }

}