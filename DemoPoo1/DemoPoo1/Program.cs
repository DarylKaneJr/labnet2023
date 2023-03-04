﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animales = new List<Animal>
            {
            new Persona(2),
            new Perro(4)
            };

            foreach (var item in Animales)
            {
                Console.WriteLine(item.Caminar());
               
            }
            Console.ReadLine();
        }
    }
 }

