using HrManagment.Entities;

namespace Hr.Business.Interface;

public interface ICompanyServices
{
    void Create(string? name, string description);
    void Delete(string name);
    void Activate(string name);
    void ShowAll();
    void GetCompany(string name);
    void GetDepartmentIncluded(string name);
    Company? FindCompanyByName(string name);

    //----------------------------------------
    bool IsCompanyExist();
}
