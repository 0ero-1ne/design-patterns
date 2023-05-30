namespace LabThree
{
    interface IStaff
    {
        List<JobVacancy> getJobVacancies();
        List<Employee> getEmployees();
        List<JobTitle> getJobTitles();
        int addJobTitle(JobTitle jobTitle);
        string printJobVacancies();
        bool delJobTitle(int jobTitle);
        void openJobVacancy(JobVacancy jobVacancy);
        bool closeJobVacancy(int jobVacancy);
        Employee recruit(JobVacancy jobVacancy, Person person);
        bool dismiss(int person, Reason reason);
    }
}