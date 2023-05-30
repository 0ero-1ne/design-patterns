namespace LabThree
{
    public class Department { }

    public class Faculty : Organization, IStaff
    {
        protected List<Department> departaments = new();
        
        public Faculty() { }
        public Faculty(Faculty faculty) { }
        public Faculty(string name, string shortName, string address) { }

        public int addDepartment(Department department)
        {
            departaments.Add(department);
            return 0;
        }

        public bool delDepartment(int i)
        {
            try
            {
                departaments.RemoveAt(i);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updDepartment(Department department)
        {
            try
            {
                departaments.Add(department);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool verDepartment(int i) { return true; }

        public List<Department> getDepartaments() { return departaments; }

        public void printInfo() { }


        public int addJobTitle(JobTitle jobTitle) { return 0; }

        public bool closeJobVacancy(int i)
        {
            return true;
        }

        public bool delJobTitle(int i)
        {
            JobTitle jobTitle = new();
            return true;
        }

        public bool dismiss(int i, Reason reason)
        {
            return true;
        }

        public List<Employee> getEmployees()
        {
            return new List<Employee> { new Employee()};
        }

        public List<JobTitle> getJobTitles()
        {

            List<JobTitle> some = new() { new JobTitle() };
            return some;
        }

        public List<JobVacancy> getJobVacancies()
        {
            JobVacancy job = new JobVacancy();
            List<JobVacancy> some = new() { job };
            return some;
        }

        public void openJobVacancy(JobVacancy jobVacancy)
        { }

        public string printJobVacancies()
        {
            return "Jobs";
        }

        public Employee recruit(JobVacancy jobVacancy, Person person)
        {
            return new Employee();
        }
    }
}