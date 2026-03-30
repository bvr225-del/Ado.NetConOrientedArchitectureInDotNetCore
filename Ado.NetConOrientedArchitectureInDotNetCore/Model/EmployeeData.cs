namespace Ado.NetConOrientedArchitectureInDotNetCore.Model
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<string> Skills { get; set; }

    }
}
