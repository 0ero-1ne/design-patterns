namespace LabThree
{
    public class University : Organization, IStaff
    {
        public string _shortName { get; set; }

        protected List<Faculty> faculties = new List<Faculty>();

        public University() { }

        public University(University university)
        {
            name = university.name;
            _shortName = university._shortName;
            address = university.address;
        }

        public University(string name, string shortName, string address)
        {
            this.name = name;
            _shortName = shortName;
            this.address = address;
        }

        public int addFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
            return faculties.Count;
        }

        public bool delFaculty(int index)
        {
            faculties.RemoveAt(index);
            return true;
        }

        public bool updFaculty(Faculty faculty)
        {
            return true;
        }
        
        private bool verFaculty(int index)
        {
            if (index < faculties.Count && index >= 0)
            {
                return true;
            }

            return false;
        }

        public List<Faculty> getFaculties()
        {
            return faculties;
        }

        public void printInfo() => Console.WriteLine("Info");

        public List<JobVacancy> getJobVacancies()
        {
            return new List<JobVacancy>() { new JobVacancy() };
        }

        public int addJobTitle(JobTitle jobTitle)
        {
            return 1;
        }

        public bool delJobTitle(int index)
        {
            return true;
        }

        public int openJobVacancy(JobVacancy jobVacancy)
        {
            Console.WriteLine("Opened");
            return 1;
        }

        public bool closeJobVacancy(int index)
        {
            Console.WriteLine("Closed");
            return true;
        }

        public Employee recruit(JobVacancy jobVacancy, Person person)
        {
            return new Employee();
        }

        public bool dismiss(int index, Reason reason)
        {
            return true;
        } 
    }
}