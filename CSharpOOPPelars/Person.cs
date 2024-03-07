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
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age canno't be 0");
            }
        }

        private string fName;
        [Required(ErrorMessage = "The property is required.")]

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
                    throw new ArgumentException("Name cannot be empty or null");
                }
                if (value.Length > 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("Name must have min 2 letters and max 10 ");
                }

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
                    throw new ArgumentException("Name cannot be empty or null");
                }
                if (value.Length > 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Name must have min 3 letters and max 15 ");
                }

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

        public override string ToString()
        {
            return $"\n Name:{FName} {LName},\n Age:{Age},\n Height:{Height},\n Weight:{Weight}";
            
        }
    }

}

