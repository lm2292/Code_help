﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"D:\Temp\Test.txt";
            /*
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Sue,Storm,www.stormy.com");

            File.WriteAllLines(filePath,lines);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
            */

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = int.Parse(entries[0]);
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];
                people.Add(newPerson);
                /*
                if (entries.Length == 3)
                {
                    people.Add(newPerson);
                    
                }
                else if (entries.Length != 3)
                {
                    Console.WriteLine("Incorrect Format");
                    break;
                }
                */

            }

            Console.WriteLine("Read from a text file");

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }, { person.Url } ");
            }

            people.Add(new Person { FirstName = 10, LastName = "Jones", Url = "www.GL.com" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{ person.FirstName }, { person.LastName }, { person.Url }");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All Entries Written");

            Console.ReadLine();

        }
    }
}
