package Classes;

public class Person {
    public int age;
    public String name;
    public double weight, height;
    double def = 50;
    double defh = 165;
    public Person(String str, int age1,double w, double height1)
    {
        this.name = str;
        this.age = age1;
        this.weight = w;
        this.height = height1;

    }
    public Person()
    {
        this.name = "Ростовых";
        this.age = 0;
        this.weight = 0;
        this.height = 0;
    }
    public String getName() {
        return this.name;
    }

    public double getAge() {
        return this.age;
    }
    public int getNum() {
        return (int)(this.age*Math.abs(this.weight-def)+Math.abs(this.height-defh));
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
                return (int)Math.abs(age1 - IMT(w, height1))+1;
            else return (int)(IMT(def, defh)/5)+2;
        }
        else return -1;
    }

    public boolean IsCorrect()
    {
        return (name == "" || age < 0 || weight < 0 || height < 0) ? false : true;
    }
    public void FullName() throws PersonException {
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
