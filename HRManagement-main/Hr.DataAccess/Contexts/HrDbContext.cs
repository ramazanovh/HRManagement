using HrManagment.Entities;

namespace Hr.DataAccess.Contexts;

public static class HRDbContext
{
    public static List<Employee> Employees { get; set; } = new List<Employee>();
    public static List<Department> Departments { get; set; } = new List<Department>();
    public static List<Company> Companies { get; set; } = new List<Company>();
}

    

