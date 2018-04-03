using System;
using System.Collections.Generic;

namespace Model
{
    public class Course
    {
        public readonly string Title;
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Course(string title)
        {
            Title = title;
        }

        public void AddTeacher(Teacher teacher)
        {
            try
            {
                if (teacher == null)
                    Teachers = new List<Teacher>();
                Teachers.Add(teacher);
            }
            catch (Exception) { throw; }
        }

        public void AddStudent(Student student)
        {
            try
            {
                if (student == null)
                    Students = new List<Student>();
                Students.Add(student);
            }
            catch (Exception) { throw; }
        }
    }
}
