
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МКПЛаб3
{
    public class Person: Persons
    {
        public int age;
        public string name;
        public double weight, height;
        double def = 50;
        double defh = 165;
        public Person(string str, int age1=18,double w=50, double height1=165)
        {
            name = str;
            age = age1;
            weight = w;
            height = height1;

        }
        public Person()
        {
            name = "Ростовых";
            age = 0;
            weight = 0;
            height = 0;
        }
        public double IMT(double w, double height1)
        {
            if (w > 0 && height1>0)
            {
                return w/(height1*height1/10000);
            }
            else return 0;
        }

        public double IMT()
        {
            return (weight > 0 && height > 0) ? (weight / (height * height / 10000)) : 0;
          
        }
        public int category( int age1, double w, double height1)
        {
            if (age1>0)
            {
                if (w > 0 && height > 0)
                    return (int)Math.Abs(age1 - IMT(w, height1))+1;
                else return (int)(IMT(def, defh)/5)+2;
            }
            else return -1;
        }

        public bool IsCorrect()
        {
            return (name == "" || age < 0 || weight < 0 || height < 0) ? false : true;
        }
        public void FullName()
        {
            if (this.name == "")
            {
                throw new PersonException("Name can't be empty");
            }
            else
            {
                this.name = "Ростовых Александра Дмитриевна";
            }

        }
    }
}
