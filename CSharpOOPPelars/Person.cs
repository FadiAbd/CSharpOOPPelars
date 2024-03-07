using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOPPelars
{
    internal class Person
    {
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Åldern måste vara större än 0.", nameof(Age));
                }
                age = value;
            }
        }

        private string fName;
        //[Required(ErrorMessage = "The property is required.")]

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Efternamnet är obligatorisk",
                        nameof(FName));
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Förnamnet måste vara mellan 2 och 10 tecken långt.", nameof(FName));
                }
                fName = value;


            }
        }
        private string lName;
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Efternamnet är obligatorisk",
                        nameof(LName));
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Förnamnet måste vara mellan 3 och 15 tecken långt.",nameof(LName));
                }
                lName = value;


            }
        }
        private int height;
        private int weight;
        public int Height { get; set; }
        public int Weight { get; set; }

        public Person(int age, string fname, string lname, int height, int weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"\n Name:{FName} {LName},\n Age:{Age},\n Height:{Height},\n Weight:{Weight}";

        }
    }

}

