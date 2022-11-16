using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1Praktik
{
    internal class Sort
    {
        public void SortInsertion(int[] a)
        {
            int tmp = a[0];
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {
                int j = i - 1;
                while (j >= 0 && tmp < a[j])
                    a[j + 1] = a[j--];
                a[j + 1] = tmp;
            }
        }
        public void SortBinInsert(int[] a)
        {
            int N = a.Length;
            for (int i = 1; i <= N - 1; i++)
            {
                int tmp = a[i], left = 1, right = i - 1;
                while (left <= right)
                {
                    int m = (left + right) / 2;

                    if (tmp < a[m])
                        right = m - 1;
                    else left = m + 1;
                }
                for (int j = i - 1; j >= 0; j--)
                    a[j + 1] = a[j];
                a[left] = tmp;
            }
        }
    }
}
