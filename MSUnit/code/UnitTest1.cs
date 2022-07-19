using Microsoft.VisualStudio.TestTools.UnitTesting;
using МКПЛаб3;
using Moq;
    namespace TestProject1
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                Person person = new Person();
                Assert.AreEqual(17.0, person.IMT());
                Assert.IsTrue(person.IsCorrect());
                Assert.IsNotNull(person.name);
            }
        [TestMethod]
        public void TestMethod2()
        {
            Person person = new Person("", 21, 54, 172);
            Assert.AreEqual(25.0, person.IMT(80,200));
            Assert.IsFalse(person.IsCorrect());
            Assert.AreNotEqual(0.0, person.IMT());
        }

        [TestMethod]

        public void TestMethod3()
        {
            Person person = new Person("", 20);
            int age2 = 20;
            try
            {
                person.FullName();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            Assert.IsFalse(age2 != person.age);
        }
        [TestMethod]
        [ExpectedException(typeof(PersonException))]
        public void TestMethod4()
        {
            Person person = new Person("name", 23, 55);
            person.FullName();
            Assert.AreEqual(1, person.category(18, 50, 170));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Student student = new Student("Ростовых", 20);
            Assert.AreEqual(5.0, student.averagescore(student.Sum,4));
            Assert.IsNotNull(student.Name);
            Assert.IsNotNull(student.Score);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int count = 9;
            Student student = new Student("Александра", 40);
            Assert.IsFalse(4.5 == student.averagescore(student.Sum, count));
            student.Newscore(3);
            count += 1;
            Assert.IsTrue(4.5 == student.averagescore(student.Sum, count));
            Assert.IsNotNull(student.Score);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Mock<Students> mock = new Mock<Students>();
            mock.Setup(m => m.Name).Returns("Александра");
            Students m = mock.Object;
            Assert.IsNotNull(m.Name);
            Assert.IsTrue("Александра" == m.Name);
        }

        [TestMethod]
        public void TestMethod8()
        {
           int i = 5;
            Mock<Students> mock = new Mock<Students>();
            mock.Setup(m => m.Score).Returns(i);
            Students m = mock.Object;
            Assert.AreEqual(0, m.Score);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Mock<Persons> mock = new Mock<Persons>();
            mock.Setup(m => m.IMT(50,167)).Returns(18);
            Persons m = mock.Object;
            Assert.AreEqual(17, m.IMT(50,167));
            Assert.AreNotEqual(18, m.IMT(50, 167));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Mock<Persons> mock = new Mock<Persons>();
            mock.Setup(m => m.IsCorrect()).Returns(true);
            Persons m = mock.Object;
            Assert.IsTrue(m.IsCorrect());
        }


    }
    }

