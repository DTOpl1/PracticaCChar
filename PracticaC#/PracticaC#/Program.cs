using PracticaC_;

Console.WriteLine("Hello, World!");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 6),
    HiringDate = new Date(2010, 3, 12),
    IsActive = true,
    Salary = 1234567.45M

};
//Console.WriteLine(employee1);
Employee employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Felipe",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 16),
    HiringDate = new Date(2015, 12, 12),
    IsActive = true,
    Sales =320000000M,
    CommisionPercentaje=0.03F

};
//Console.WriteLine(employee2);
Employee employee3 = new HourlyEmployee()
{
    Id = 156,
    FirstName = "Felipe",
    LastName = "perez",
    BirthDate = new Date(1995, 5, 16),
    HiringDate = new Date(2015, 12, 12),
    IsActive = true,
    HourValue=12353.56M,
    Hours= 124.5F  
};
//Console.WriteLine(employee3);
Employee employee4 = new BaseCommissionEmployee()
{
    Id = 462,
    FirstName = "jazmin",
    LastName = "salazar",
    BirthDate = new Date(1995, 5, 16),
    HiringDate = new Date(2015, 12, 12),
    IsActive = true,
    Base =  8604343.45M,
    Sales = 58000000M,
    CommisionPercentaje= 0.015F

};
//Console.WriteLine(employee4);
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("             ==================");
Console.WriteLine($"TOTAL NOMINA    {$"{payroll:C2}",15}");


Invoice invoice1 = new Invoice()
{
    Description = "IPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);