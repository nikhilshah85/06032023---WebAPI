namespace DI_Demo.Model
{
    public class Employee
    {

        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesigantion { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ empNo=101, empName="Karthik", empDesigantion="sales", empIsPermenant=true, empSalary=5000},
            new Employee(){ empNo=102, empName="Arjun", empDesigantion="sales", empIsPermenant=false, empSalary=5000},
            new Employee(){ empNo=103, empName="Vijay", empDesigantion="HR", empIsPermenant=true, empSalary=5000},
            new Employee(){ empNo=104, empName="Mohan", empDesigantion="sales", empIsPermenant=false, empSalary=5000},
            new Employee(){ empNo=105, empName="Rajni", empDesigantion="Accounts", empIsPermenant=true, empSalary=5000},
        };

        public List<Employee> GetAllEmployees()
        {
            return eList;
        }
        


    }
}
