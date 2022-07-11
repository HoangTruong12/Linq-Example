using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13, 34, 11, 12 };
            // IList<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13, 34, 11, 12 };

            // - Lấy ds các phần tử có số > 7 theo 2 cách sử dụng Linq

            // Query syntax
            //var listNumBigger7 = from n in numList
            //                     where n > 7
            //                     select n;
            //Console.WriteLine("DS cac phan tu lon hon 7:");
            //foreach (int l in listNumBigger7)
            //{
            //    Console.WriteLine(l);
            //}

            // Method syntax
            /* var listNumBigger7 = numList.Where(n => n > 7);

            Console.WriteLine("DS cac phan tu lon hon 7:");
            foreach (int l in listNumBigger7)
            {
                Console.WriteLine(l);
            } */

            // - tính tổng các phần tử > 3 và < 12 theo 2 cách.

            // Query syntax
            /* var sumListNumBigger3AndSmaller12 = (from n in numList
                                                where n > 3 && n < 12
                                                select n).Sum();

            Console.WriteLine("Tong cac phan tu > 3 và < 12: {0}", sumListNumBigger3AndSmaller12); */

            // Method syntax
            //var sumListNumBigger3AndSmaller12 = numList.Sum(s => (s > 3 && s < 12) ? s : 0);

            //Console.WriteLine("Tong cac phan tu > 3 và < 12: {0}", sumListNumBigger3AndSmaller12);

            // - Lấy số lớn nhất/bé nhất trong mảng trên

            // Query syntax

            /* var maxArray = (from n in numList
                           select n).Max();

            var minArray = (from n in numList
                            select n).Min();

            Console.WriteLine("So lon nhat trong mang la: {0}", maxArray);
            Console.WriteLine("So be nhat trong mang la: {0}", minArray); */

            // Method syntax 
            /* var maxArray = numList.Max();
            var minArray = numList.Min();

            Console.WriteLine("So lon nhat trong mang la: {0}", maxArray);
            Console.WriteLine("So be nhat trong mang la: {0}", minArray); */

            // - Lấy 5 phần tử đầu tiên

            // Query syntax
            /* var takeFirstElement5 = (from n in numList
                                     select n).Take(5);
            Console.WriteLine("5 phan tu dau tien: ");
            foreach (int t in takeFirstElement5)
            {
                Console.Write(t + " ");
            } */

            // Method syntax
            /* var takeFirstElement5 = numList.Take(5);
            Console.WriteLine("5 phan tu dau tien: ");
            foreach (int t in takeFirstElement5)
            {
                Console.Write(t + " ");

            } */

            // - Sắp xếp mảng theo tứ tự tăng/giảm dần

            // Query syntax
            /* var arraySortAsc = from n in numList
                               orderby n 
                               select n;
            Console.WriteLine("Mang sau khi sap xep theo thu tu tang dan: ");
            foreach (int a in arraySortAsc)
            {
                Console.Write(a + " ");

            }
            var arraySortDes = from n in numList
                               orderby n descending
                               select n;
            Console.WriteLine("\nMang sau khi sap xep theo thu tu giam dan: ");
            foreach (int a in arraySortDes)
            {
                Console.Write(a + " ");

            } */

            // Method syntax
            /* var arraySortAsc = numList.OrderBy(n => n);
            Console.WriteLine("Mang sau khi sap xep theo thu tu tang dan: ");
            foreach (int a in arraySortAsc)
            {
                Console.Write(a + " ");

            }

            var arraySortDes = numList.OrderByDescending(n => n);
            Console.WriteLine("\nMang sau khi sap xep theo thu tu giam dan: ");
            foreach (int a in arraySortDes)
            {
                Console.Write(a + " ");

            } */
            Console.ReadLine();
        }
    }
}
