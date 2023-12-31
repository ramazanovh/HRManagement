namespace Hr.Business.Interface;

public interface IEmployeeServices
{
    void Create(string name, string surname, string email, 
        string password, decimal Salary, string departmentName);
    void Delete(int Id);
    void ChangeDepartment(int employeeId, string newDepartmentName);
    void ShowAll();
}
