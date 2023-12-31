using Hr.Business.Interface;
using Hr.Business.Services;
using Hr.Business.Utilities.Helpers;
using Hr.DataAccess.Contexts;
using System;

Console.WriteLine("HR App Start");
CompanyServices companyServices = new();
EmployeeServices employeeServices = new();
DepartmentServices departmentServices = new();
bool isContinue = true;
while (isContinue)
{
    Console.WriteLine("___________________________________________________________________");
    Console.WriteLine("Choose the option:");
    Console.WriteLine("-- Company--\n" +
                      "1 - Create Company \n" +
                      "2 - Show All Company \n" +
                      "3 - Activate Company \n" +
                      "4 - Delete Company \n" +
                      "5 - Get Company Department\n" +

                      "-- Department--\n" +
                      "6 - Create Department \n" +
                      "7 - Show All Department \n" +
                      "8 - Activate Department \n" +
                      "9 - Delete Department \n" +
                      "10 - Get Department Employee \n" +

                      "-- Employee--\n" +
                      "11 - Create Employee \n" +
                      "12 - Show All Employee \n" +


                      "13 - Get Company \n" +
                      "14 - Move Employee \n" +
                      "0 - Exit");
    Console.WriteLine("--------------------------------------------------------------------");
    string? option = Console.ReadLine();
    int optionNumber;
    bool isInt = int.TryParse(option, out optionNumber);
    if (isInt)
    {
        if (optionNumber >= 0 && optionNumber <= 15)
        {
            switch (optionNumber)
            {
                case (int)Menu.Exit:
                    Environment.Exit(0);
                    break;
                case (int)Menu.CreateCompany:
                    try
                    {
                        Console.WriteLine("Enter Company Name:");
                        string? companyName = Console.ReadLine();
                        Console.WriteLine("Enter Company Description:");
                        string? companyDescription = Console.ReadLine();
                        companyServices.Create(companyName, companyDescription);
                        Console.WriteLine("Created");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto case (int)Menu.CreateCompany;
                    }
                    break;

                case (int)Menu.ShowAllCompany:

                    Console.WriteLine("All company:");
                    if (companyServices.IsCompanyExist() == false)
                    {
                        Console.WriteLine("Company is missing:");
                    }
                    companyServices.ShowAll();
                    break;
                case (int)Menu.ActivateCompany:
                    if (companyServices.IsCompanyExist() == false) Console.WriteLine("Company is missing:");
                    try
                    {
                        Console.WriteLine("Enter company name:");
                        string? companyName = Console.ReadLine();
                        companyServices.Activate(companyName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.DeleteCompany:
                    if (companyServices.IsCompanyExist() == false) Console.WriteLine("Company is missing:");
                    try
                    {
                        Console.WriteLine("Enter company name:");
                        string? companyName = Console.ReadLine();
                        companyServices.Delete(companyName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.GetByNameCompany:
                    try
                    {
                        Console.WriteLine("Enter company name:");
                        string? companyName = Console.ReadLine();
                        companyServices.GetCompany(companyName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                //----------------------Company Menu Finish------------------------



                case (int)Menu.CreateDepartment:
                    if (companyServices.IsCompanyExist() == false)
                    {
                        Console.WriteLine("You should create a company:");
                        goto case (int)Menu.CreateCompany;
                    }
                    try
                    {
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        Console.WriteLine("Enter department employee limit:");
                        int employeeLimit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------");
                        companyServices.ShowAll();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Enter company name:");
                        string? companyName2 = Console.ReadLine();
                        departmentServices.Create(departmentName, employeeLimit, companyName2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto case 3;
                    }
                    break;
                case (int)Menu.ShowAllDepartment:
                    if (departmentServices.IsDepartmentExist() == false)
                    {
                        Console.WriteLine("Department is missing:");
                        goto case (int)Menu.CreateDepartment;
                    }
                    Console.WriteLine("All department:");
                    departmentServices.ShowAll();
                    break;
                case (int)Menu.ActivateDepartment:
                    try
                    {
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        departmentServices.Activate(departmentName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.DeleteDepartment:
                    try
                    {
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        departmentServices.Delete(departmentName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.GetDepartmentEmployee:
                    try
                    {
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        departmentServices.GetDepartmentEmployee(departmentName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                //----------------------Department Menu Finish------------------------

                case (int)Menu.CreateEmployee:
                    try
                    {
                        Console.WriteLine("Enter employee name:");
                        string? employeetName = Console.ReadLine();
                        Console.WriteLine("Enter employee surname:");
                        string? employeeSurname = Console.ReadLine();
                        Console.WriteLine("Enter employee email:");
                        string? employeeEmail = Console.ReadLine();
                        Console.WriteLine("Enter employee password:");
                        string? employeePassword = Console.ReadLine();
                        Console.WriteLine("Enter employee salary:");
                        decimal employeeSalary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------------");
                        departmentServices.ShowAll();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        employeeServices.Create(employeetName, employeeSurname, employeeEmail, employeePassword,
                            employeeSalary, departmentName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.ShowAllEmployee:
                    Console.WriteLine("All Employee:");
                    employeeServices.ShowAll();
                    break;
                case (int)Menu.getCompany:
                    try
                    {
                        Console.WriteLine("Enter company name:");
                        string? companyName = Console.ReadLine();
                        companyServices.GetCompany(companyName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case (int)Menu.moveEmployee:
                    try
                    {
                        Console.WriteLine("----------employees-------------");
                        employeeServices.ShowAll();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Enter employee ID");
                        int employeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------departments------------");
                        departmentServices.ShowAll();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Enter department name:");
                        string? departmentName = Console.ReadLine();
                        employeeServices.ChangeDepartment(employeeId, departmentName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    isContinue = false;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter correct option number!");
        }
    }
    else
    {
        Console.WriteLine("Please enter correct format!");
    }
}
