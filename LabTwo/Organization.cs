namespace LabThree
{
    public class Organization : IStaff
    {
        public int id { get; private set; }
        public string name { get; protected set; }
        public Type shortName { get; protected set; }
        public string address { get; protected set; }
        public DateTime timeStamp { get; protected set; }

        public Organization() { }

        public Organization(Organization organization)
        {
            id = organization.id;
            name = organization.name;
            shortName = organization.shortName;
            address = organization.address;
            timeStamp = organization.timeStamp;
        }

        public Organization(int id, string name, Type shortName, string address, DateTime timeStamp)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
            this.address = address;
            this.timeStamp = timeStamp;
        }

        public void printInfo()
        {
            Console.WriteLine(string.Format(
                "ID - {0}\nName - {1}\nShort Name - {2}\nAddress - {3}\nTime Stamp - {4}\n",
                id, name, shortName, address, timeStamp
            ));
        }

        public List<JobVacancy> getJobVacancies()
        {
            throw new NotImplementedException();
        }

        public List<Employee> getEmployees()
        {
            throw new NotImplementedException();
        }

        public List<JobTitle> getJobTitles()
        {
            throw new NotImplementedException();
        }

        public int addJobTitle(JobTitle jobTitle)
        {
            throw new NotImplementedException();
        }

        public string printJobVacancies()
        {
            throw new NotImplementedException();
        }

        public bool delJobTitle(int jobTitle)
        {
            throw new NotImplementedException();
        }

        public void openJobVacancy(JobVacancy jobVacancy)
        {
            throw new NotImplementedException();
        }

        public bool closeJobVacancy(int jobVacancy)
        {
            throw new NotImplementedException();
        }

        public Employee recruit(JobVacancy jobVacancy, Person person)
        {
            throw new NotImplementedException();
        }

        public bool dismiss(int person, Reason reason)
        {
            throw new NotImplementedException();
        }
    }
}