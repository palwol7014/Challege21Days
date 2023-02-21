namespace Challege21Days.Tests
{
	public class EmployeeTests
	{
		[Test]
		public void CheckCorrectMaxValueGrade()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade(3);
			emp.AddGrade(4);
			emp.AddGrade(6);
			var stat = emp.GetStatistics();

			//assert
			Assert.AreEqual(6, stat.Max);
		}
		
		[Test]
		public void CheckCorrectMinValueGrade()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade(3);
			emp.AddGrade(4);
			emp.AddGrade(6);
			var stat = emp.GetStatistics();

			//assert
			Assert.AreEqual(3, stat.Min);
		}

		[Test]
		public void CheckCorrectAverageValueGrade()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade(3);
			emp.AddGrade(4);
			emp.AddGrade(6);
			var stat = emp.GetStatistics();

			/* 
			 * assert
			 * Must be cast to float, default is double
			 */

			Assert.AreEqual((float)13.0 / (float)3.0, stat.Average);
		}

		[Test]
		public void CheckCorrectMaxValueGradeForString()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade("3");
			emp.AddGrade("4");
			emp.AddGrade("6");
			var stat = emp.GetStatistics();

			//assert
			Assert.AreEqual(6, stat.Max);
		}

		[Test]
		public void CheckCorrectMinValueGradeForString()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade("3");
			emp.AddGrade("4");
			emp.AddGrade("6");
			var stat = emp.GetStatistics();

			//assert
			Assert.AreEqual(3, stat.Min);
		}

		[Test]
		public void CheckCorrectAverageValueGradeForString()
		{
			//arrange
			var emp = new Employee("Palwol", "TestUser");

			//act
			emp.AddGrade("3");
			emp.AddGrade("4");
			emp.AddGrade("6");
			var stat = emp.GetStatistics();

			/* 
			 * assert
			 * Must be cast to float, default is double
			 */

			Assert.AreEqual((float)13.0 / (float)3.0, stat.Average);
		}
	}
}