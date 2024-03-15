public class Job
{
    public string _jobTitle = "";
    public string _companyName="";
    // public string _companyYear="";
    public int _companyStartYear=2019;
    public int _companyEndYear=2022;


    

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_companyStartYear}-{_companyEndYear}");
    }
}