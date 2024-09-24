namespace MyProductAPI.Entity
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = null!;
		public string Lastname { get; set; } = null!;
		public string Position { get; set; } = null!;
		public decimal Salary { get; set; } 
	}
}
