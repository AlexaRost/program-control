using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МКПЛаб3
{
    public interface Persons
    {
        public double IMT(double w, double height1);
        public double IMT();
        public int category(int age1, double w, double height1);
        public bool IsCorrect();
        public void FullName();
    }
}
