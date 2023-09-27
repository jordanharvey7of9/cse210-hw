public class Resume

{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //Job is the object, and job the variable that stands for each item in the list, and _jobs is the name of the list
        foreach (Job job in _jobs)
        {
            job.Display();
        }



    }

}