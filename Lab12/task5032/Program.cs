﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.task5032;

namespace task5032
{
    class Program
    {
        static void Main(string[] args)
        { Rectangle r = new Rectangle (100, 100, 100, 100);

            string textIndex = Console.ReadLine();//ввели № 
            string textName = "test" + textIndex + ".csv";//узнали название фаила
            if (!File.Exists(textName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(textName);
            string line;
            int i = 0;
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                reader.Close();
                return;
            }

      
            try
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();//читает строку до первого /n
                    i++;
                    string[] arr = line.Split(';');
                    if(arr.Length<2||arr.Length>2)
                    {
                        Console.WriteLine("Некорректный формат");
                        reader.Close();
                        return;
                    }
                    if (arr[0].Equals("shiftX"))
                    {
                        r.shiftX(arr[1]);
                    }
                   else if (arr[0].Equals("shiftY"))
                    {
                        r.shiftY(arr[1]);
                    }
                    else if(arr[0].Equals("stretchX"))
                    {
                        r.stretchX(arr[1]);
                    }
                    else if(arr[0].Equals("stretchY"))
                    {
                        r.stretchY(arr[1]);
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: "+arr[0]);
                        reader.Close();
                        return;
                    }

                }

                Console.Write ("действий:" + i+ " " + r);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
           
            reader.Close();
        }
    }
}
