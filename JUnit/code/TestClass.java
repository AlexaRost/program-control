import Classes.Person;
import Classes.PersonException;
import org.junit.jupiter.api.*;

import static org.junit.jupiter.api.Assertions.*;
//import static org.junit.jupiter.api.Assertions.assertTrue;
import Classes.Student;
import Classes.Person;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.ValueSource;

import java.util.concurrent.TimeUnit;

/**
 * Класс для тестирование банковского аккаунта
 */
public class TestClass {

    private Person person;

    @BeforeEach
    void setUp() {
        this.person = new Person("Rostovykh", 20, 50, 156);
    }

    @AfterEach
    void tearDown() {
        this.person = null;
    }
    @Test
    void TestMethod1()
    {
        Assertions.assertEquals(27.0, this.person.IMT(),1.0);
        Assertions.assertTrue(this.person.IsCorrect());
        Assertions.assertNotNull(this.person.name);
    }
    @Test
    void TestMethod2()
    {
        Person person2 = new Person(null, 21, 54, 172);
        Assertions.assertEquals(25.0, person2.IMT(100,200) );
        Assertions.assertFalse(person2.IsCorrect());
        Assertions.assertNotEquals(0.0, this.person.IMT()+2);
    }
    //@Test(expected = PersonException.class)
    @Test
    void TestMethod3() throws PersonException {
        Person person2 = new Person(null, 17, 49, 163);
        try {
            person2.FullName();
        } catch (PersonException thrown) {
            Assertions.assertNotNull(thrown.getMessage());
        }
        Assertions.assertEquals(1, this.person.category(18, 50, 170));
    }
   /** @Test
    void TestMethod3() throws PersonException {
        Person person2 = new Person("", 17, 49, 163);
        Throwable thrown = assertThrows(PersonException.class, () -> {
            person2.FullName();
        });
        Assertions.assertNotNull(thrown.getMessage());
        Assertions.assertEquals(1, this.person.category(18, 50, 170));
    }*/

    @Test
    void TestMethod4() throws PersonException {
        this.person.FullName();
        Assertions.assertEquals(9, this.person.getNum());
    }

    @Test
    void TestMethod5() {
        Assertions.assertNotNull(this.person.getName());
        Assertions.assertEquals(20, this.person.getAge());
        Person person2 = new Person("null", 17, 49, 163);
        Assertions.assertNull(person2.getName());
    }
    @Test
    void TestMethod6() {
        Student student = new Student("Rostovykh", 21);
        Assertions.assertEquals(5.25, student.averagescore(student.Sum,4));
        Assertions.assertNotNull(student.getName());
        Assertions.assertNotNull(student.getScore());
        Assertions.assertEquals(student.getScore()-1, this.person.getAge());
    }

    @Test
    void TestMethod7() {
        int count = 9;
        Student student = new Student("Alexandra", 40);
        Assertions.assertFalse(4.5 == student.averagescore(student.Sum, count));
        student.Newscore(3);
        count += 1;
        Assertions.assertTrue(4.5 == student.averagescore(student.Sum, count));
        Assertions.assertNotNull(student.getScore());
    }

    @ParameterizedTest
    @ValueSource(ints = { 0, 5, 14, 32, 15, 3})
    void parameterTest(int Score) {
        Student student = new Student("Rostovykh", 21);
        student.Newscore(Score);
        int expected=21+Score;
        Assertions.assertEquals(expected-3, student.getScore());
    }
    @Test
    @Timeout(value=90, unit= TimeUnit.MILLISECONDS) // в JUnit4 написали бы @Test(timeout = 100), где 100 - время в миллисекундах
    void TestTime() throws InterruptedException {
        //TimeUnit.SECONDS.sleep(10);
        Student student = new Student("Rostovykh", 21);
        student.Newscore(10);
        int expected=21+10;
        Assertions.assertEquals(expected, student.getScore());
    }
    /**
     * Тест с ограничением на время выполнения (если раскомментировать 1 строку - тест упадет)
     * @throws InterruptedException
     */
    /**@Test
    @Timeout(value=1, unit=TimeUnit.SECONDS) // в JUnit4 написали бы @Test(timeout = 100), где 100 - время в миллисекундах
    void timeTest() throws InterruptedException {
        // TimeUnit.SECONDS.sleep(10);
        this.person.deposit(0.0);
        Assertions.assertEquals(777.0, this.person.getBalance());
    }*/

}

