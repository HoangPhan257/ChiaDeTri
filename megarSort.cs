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
        int[] A = { 5, 2, 4, 6, 1, 3, 24, 9, 41 };
        int n = A.Length;

        Console.WriteLine("Mảng ban đầu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }

        MergeSort(A, 0, n - 1);

        Console.WriteLine("\nMảng sau khi sắp xếp:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.ReadLine();
    }
    static void MergeSort(int[] A, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(A, left, mid);
            MergeSort(A, mid + 1, right);
            Merge(A, left, mid, right);
        }
    }

    static void Merge(int[] A, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            L[i] = A[left + i];
        }

        for (int j = 0; j < n2; j++)
        {
            R[j] = A[mid + j + 1];
        }

        int i2 = 0, j2 = 0, k = left;

        while (i2 < n1 && j2 < n2)
        {
            if (L[i2] <= R[j2])
            {
                A[k] = L[i2];
                i2++;
            }
            else
            {
                A[k] = R[j2];
                j2++;
            }
            k++;
        }

        while (i2 < n1)
        {
            A[k] = L[i2];
            i2++;
            k++;
        }

        while (j2 < n2)
        {
            A[k] = R[j2];
            j2++;
            k++;
        }
    }
}