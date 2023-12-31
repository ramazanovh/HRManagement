using HrManagment.Interface;

namespace HrManagment.Entities;

public class Company : IEntity
{
    public int Id { get; }
    public string Name { get; set; }
    public string Description {  get; set; }
    public bool IsActive { get; set; }
    private static int _id;
    public Company(string name, string description)
    {
        Id = _id++;
        Name = name;
        Description = description;
    }
}

