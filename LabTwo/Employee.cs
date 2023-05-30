namespace LabThree
{
    public class Employee
    {
        public Person? person;
        public JobVacancy? jobVacancy;

        public Employee() { }
        public Employee(Person person, JobVacancy jobVacancy)
        {
            this.person = person;
            this.jobVacancy = jobVacancy;
        }
    }
}