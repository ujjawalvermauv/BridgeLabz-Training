abstract class CourseType
{
    public string CourseName { get; set; }
    public abstract void Evaluate();
}

class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated via Exam");
    }
}

class AssignmentCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated via Assignment");
    }
}

class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void EvaluateAll()
    {
        foreach (T c in courses)
        {
            c.Evaluate();
        }
    }
}
