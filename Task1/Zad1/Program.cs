using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\input.txt";

            if (File.Exists(path))
            {
                try
                {
                    string jsonFile;
                    using (var reader = new StreamReader(path))
                    {
                        jsonFile = reader.ReadToEnd();
                    }

                    var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(jsonFile);
                    foreach (var item in movieStars)
                    {
                        Console.WriteLine(item.ToString()); 

                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                Console.WriteLine("File doesnt exist");
            }

        }
    }
}
