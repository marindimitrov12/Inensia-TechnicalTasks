using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Zad1
{
    public class MovieStar
    {
        

        [JsonProperty]
        public DateTime DateOfBirth { get; private set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Sex { get; set; }
        public string Nationality { get; set; }

        public string CalculateAge()
        {
            var age = new DateTime(DateTime.Now.Subtract(DateOfBirth).Ticks).Year-1;
            return $"{age} years old";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name+" "+Surname);
            sb.AppendLine(Sex);
            sb.AppendLine(Nationality);
            sb.AppendLine(CalculateAge());
            return sb.ToString();
        }
    }
}
