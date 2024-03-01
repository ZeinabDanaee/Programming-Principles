
namespace DRY_Principle.Data_Duplication
{
    public class EmployeeQueryResult
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int TotalSalary { get; set; }
        // Additional properties optimized for querying and presentation
    }
}