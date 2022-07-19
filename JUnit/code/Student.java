package Classes;

public class Student 
{
    public String name;
    public int score;
    public int Sum;

    public Student(String name, int score)

    {
        this.name = name;
        this.score = score;
        this.Sum = score;
    }
    public String getName() {
        return this.name;
    }

    public double getScore() {
        return this.score;
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
