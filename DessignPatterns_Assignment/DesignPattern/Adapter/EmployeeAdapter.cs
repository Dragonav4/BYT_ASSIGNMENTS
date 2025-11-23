// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var list = new List<Employee>();
            var rows = employeesArray.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                var emp = new Employee
                (
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    int.Parse(employeesArray[i, 3])
                );
                list.Add(emp);
            }
            
            _thirdPartyBillingSystem.ProcessSalary(list);
        }
    }
}
