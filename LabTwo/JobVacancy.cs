namespace LabThree
{
    public class JobVacancy
    {
        public string? Company { get; set; }
        public JobTitle? JobTitle { get; set; }
        public int Salary { get; set; }
        public int Status { get; set; }

        public JobVacancy() { }
        public JobVacancy(string company, JobTitle jobTitle, int salary, int status)
        {
            Company = company;
            JobTitle = jobTitle;
            Salary = salary;
            Status = status;
        }
    }
}