// Create a list of Employees
List<Employee> employees = new List<Employee>();

// Create different kinds of employees and add them to the same list
employees.add(new Employee());
employees.add(new HourlyEmployee());

// Get a custom calculation for each one
foreach(Employee employee in employees)
{
  float pay = employee.CalculatePay();
  Console.WriteLine(pay);
}