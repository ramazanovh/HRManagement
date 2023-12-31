﻿using HrManagment.Entities;

namespace Hr.Business.Interface;

public interface IDepartmentServices
{
    void Create (string name, int employeeLimit, string companyName);
    Department? GetById (int id);
    Department? GetByName (string name);
    void Activate(string name);
    void Delete(string name);
    void GetDepartmentEmployee(string name);
    void ShowAll();

    //-----------------------------------------
    bool IsDepartmentExist();
    void moveEmployee(int employeeId);

}
