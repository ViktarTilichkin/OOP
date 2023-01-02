namespace ControlPoint.ModelClasses
{
	public class Student
	{
		public int Number { get; } 
		public string? Name { get; set; }
		public string? FacultyName { get; set; }
		public int Course { get; set; } = 1;

		public Student(int number)
		{
			Number = number;
		}
		public Student(int number, string name, string facultName, int course): this(number)
		{
			Name = name;
			FacultyName = facultName;
			Course = course;  
		}

		public override string ToString()
		{
			return $"#{Number} {Name} фк {FacultyName} курс {Course}"; 
		}
	}
}