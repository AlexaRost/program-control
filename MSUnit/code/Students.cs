using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МКПЛаб3
{
    public interface Students
    {
        public double averagescore(int Sum, int count);
        public void Newscore(int score);
        public int ID(int Sum, int count);
        string Name { get; }
        double Score { get; }
    }
}
