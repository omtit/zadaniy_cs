﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "out.txt";
            StreamWriter writer = new StreamWriter(filename);

            Random rnd = new Random();
           
            int n = 100;//размер массива
          
            double circumference = 0;

            int[] arr = new int[n];
            writer.WriteLine("R;C");
            for (int i = 0; i < n; i++ )
            {
                arr[i] = rnd.Next(1, 999);

                circumference = 2*Math.PI* arr[i];
               
                writer.WriteLine(arr[i]+";"+ circumference);


            }
            writer.Close();
        }
        
    }
}
