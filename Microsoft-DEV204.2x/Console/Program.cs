using Model;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var uProgram = new UProgram("Information Technology")
            {
                Degree = new Degree("Bachelor")
                {
                    Course = new Course("Programming with C#")
                }
            };

            uProgram.Degree.Course.AddStudent(new Student());
            uProgram.Degree.Course.AddStudent(new Student());
            uProgram.Degree.Course.AddStudent(new Student());

            System.Console.WriteLine($"{uProgram.Title}, {uProgram.Degree.Title}, {uProgram.Degree.Course.Title}, {uProgram.Degree.Course.Students.Count}");
        }
    }
}
