

namespace Challege21Days.Tests
{
	public class EmployeeTests
	{
		private Employee emp;

		[SetUp]
		public void SetUpEmployee()
		{
			emp = new Employee("Palwol", "TestUser");
		}

		[Test]
		public void CheckCorrectMaxValueGrade()
		{
			emp.AddGrade(3);
			emp.AddGrade("A");
			emp.AddGrade(6);

			
			Assert.IsNotNull(emp.Statistics);
			Assert.AreEqual(100, emp.Statistics.Max);
		}
		
		[Test]
		public void CheckCorrectMinValueGrade()
		{
			emp.AddGrade(3);
			emp.AddGrade("t");
			emp.AddGrade(6);

			
			Assert.IsNotNull(emp.Statistics);
			Assert.AreEqual(3, emp.Statistics.Min);
		}

		[Test]
		public void CheckCorrectAverageValueGrade()
		{
			emp.AddGrade(3);
			emp.AddGrade("J");
			emp.AddGrade(6);

			
			Assert.IsNotNull(emp.Statistics);
			Assert.AreEqual((float)19 / (float)3.0, emp.Statistics.Average);
		}

		[Test]
		public void CheckCorrectNoteToLetter()
		{
			emp.AddGrade((float)57.6);

			Assert.IsNotNull(emp.Statistics);
			Assert.AreEqual('E', Employee.ConvertGradeToLetter(emp.Statistics.Max));
		}
	}
}