var employees = new List<Employee>
{
	new( "Jake Smith", "Space Navigation", 25000 ),
	new( "Anna Blake", "Space Navigation", 29000 ),
	new( "Barbara Oak", "Xenobiology", 21500 ),
	new( "Damien Parker", "Xenobiology", 22000 ),
	new( "Nisha Patel", "Mechanics", 21000 ),
	new( "Gustavo Sanchez", "Mechanics", 20000 )
};

var result = CalculateAverageSalaryPerDepartment(employees);

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
	var employeesPerDepartments = new Dictionary<string, List<Employee>>();

	foreach (var employee in employees)
	{
		if (employeesPerDepartments.ContainsKey(employee.Department) is false)
		{
			employeesPerDepartments[employee.Department] = [];
		}

		employeesPerDepartments[employee.Department].Add(employee);
	}

	var result = new Dictionary<string, decimal>();

	foreach (var employeesPerDepartment in employeesPerDepartments)
	{
		decimal sumOfSalaries = 0;

		foreach (var employee in employeesPerDepartment.Value)
		{
			sumOfSalaries += employee.MonthlySalary;
		}

		var average = sumOfSalaries / employeesPerDepartment.Value.Count;
		result[employeesPerDepartment.Key] = average;
	}

	return result;
}

public class Employee(string name, string department, decimal monthlySalary)
{
	public string Name { get; init; } = name;
	public string Department { get; init; } = department;
	public decimal MonthlySalary { get; set; } = monthlySalary;
}