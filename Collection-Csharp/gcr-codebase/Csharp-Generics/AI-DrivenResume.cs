abstract class JobRole
{
    public string RoleName { get; set; }
    public abstract void Screen();
}

class SoftwareEngineer : JobRole
{
    public override void Screen()
    {
        Console.WriteLine("Screening Software Engineer Resume");
    }
}

class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T role)
    {
        resumes.Add(role);
    }

    public void ProcessAll()
    {
        foreach (T r in resumes)
        {
            r.Screen();
        }
    }
}
