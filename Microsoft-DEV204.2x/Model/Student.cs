namespace Model
{
    public class Student : Person
    {
        public static int count;

        public Student()
        {
            count++;
        }

        public void TakeTest() { }
    }
}
