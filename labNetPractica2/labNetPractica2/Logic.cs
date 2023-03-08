﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Logic
    {
        // punto 3
        public static void CapturarExcepcion()
        {
           
                var list = new List<int>() { 10, 20, 30 };
                foreach (int value in list)
                {
                    Console.WriteLine("ELEMENT: {0}", value);
                    list.Remove(value);
                }
        }
        //punto 4
        public static void ThrowCustomException(string std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(std))
            {
                throw new CustomException(std);
            }
                

        }
    }
}
