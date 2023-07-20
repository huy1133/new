using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bài_tập__Xây_dựng_lớp_StopWatch
{
    class time
    {
        private DateTime starTime;
        private DateTime endTime;

        public DateTime StarTime{
            get => starTime;
        }
        public DateTime EndTime
        {
            get => endTime;
        }
        public time()
        {
            starTime = DateTime.Now;
        }
        public void Star_Time()
        {
            this.starTime = DateTime.Now;
        }
        public void End_Time()
        {
            this.endTime = DateTime.Now;
        }
        public TimeSpan GetElapsedTime()
        {
            return this.endTime - this.starTime;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 100000;
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = rnd.Next(1,1000);
            }
            time tgian = new time();
            tgian.Star_Time();
            for(int i=0; i< arr.Length-1; i++)
            {
                int min = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            tgian.End_Time();
            Console.WriteLine("thoi gian thuc hien thuat toan selection sort: " + tgian.GetElapsedTime());
        }
    }
}
