using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МКПЛаб3
{
    public class Student: Students
    {
        public string name;
        public int score;
        public int Sum;
        public string Name => this.name;
        public double Score => this.score;
        public Student(string name, int score = 0)

        {
            this.name = name;
            this.score = score;
            this.Sum = score;
        }
        public void Newscore(int score)
        {
            this.score += score;
            this.Sum += score;
        }
        public double averagescore(int Sum, int count)
        {
            return (double)Sum / count;
        }

        public int ID(int Sum, int count)
        {
            return (int)(averagescore(Sum, count)/5+this.score*234-this.Sum);
        }
    }
}
