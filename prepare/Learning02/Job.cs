public class Job
{
    public string _jobTitle = "";
    public string _companyName="";
    public string _companyYear="";

    

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_companyYear}");
    }
}