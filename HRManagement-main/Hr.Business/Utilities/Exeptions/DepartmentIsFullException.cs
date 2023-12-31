namespace Hr.Business.Utilities.Exeptions;

public class DepartmentIsFullException: Exception
{
    public DepartmentIsFullException(string message) : base(message) { }
}
