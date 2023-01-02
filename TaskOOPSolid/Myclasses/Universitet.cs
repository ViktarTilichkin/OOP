using ControlPoint.ModelClasses;

namespace ControlPoint.CoreClasses
{
    public class University
    {
        public Student[] Students;

        public University()
        {
            Students = new Student[10];
            Students[0] = new Student(1);
            Students[1] = new Student(2, "viktor", "FTUG", 5);
        }

        public void ShowAllStudents()
        {
            foreach (Student item in Students)
            {
                if (item == null)
                {
                    continue;
                }
                Console.WriteLine(item);
            }
        }
        public void ShowStudentsByFaculty(params string[] facultyNames)
        {
            int i = 0;
            while (i < facultyNames.Length)
            {
                int j = 0;
                while (j < Students.Length)
                {
                    if (facultyNames[i] == Students[j].FacultyName)
                    {
                        Console.WriteLine(Students[j]);
                    }
                    j++;
                }
                i++;
            }
        }

        public void ShowStudentsByFacultyAndCourse(string facultyName, int course)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FacultyName == facultyName && Students[i].Course == course)
                {
                    Console.WriteLine(Students[i]);
                }
            }
        }

        public void UpdateStudentCourseByNumber(int studentNumber)
        {
            bool student = false;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Number == studentNumber)
                {
                    student = true;
                    Console.WriteLine("Введите номер курса");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int course))
                    {
                        Students[i].Course = course;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("error input");
                    }
                }

            }
            if (!student)
            {
                Console.WriteLine("Студент не найден");
            }
        }
    }
}