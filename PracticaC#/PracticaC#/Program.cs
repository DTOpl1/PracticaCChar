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
Console.WriteLine(employee1);
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
Console.WriteLine(employee2);