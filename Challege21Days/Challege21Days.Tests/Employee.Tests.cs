namespace Challege21Days.Tests
{
	public class Tests
	{

		[Test]
		public void WhenEmployeeGainedPoints()
		{
			//arrange
			Employee employee = new Employee("Adam", "###", 45);

			//act
			employee.AddScore(4);
			employee.AddScore(5);

			// assert
			Assert.AreEqual(9, employee.Result);
		}

		[Test]
		public void WhenEmployeeLostPoints()
		{
			//arrange
			Employee employee = new Employee("Adam", "###", 45);

			//act
			employee.LostScore(4);
			employee.LostScore(5);

			// assert
			Assert.AreEqual(-9, employee.Result);
		}

		[Test]
		public void WhenEmployeeGainedAndLostPoints()
		{
			//arrange
			Employee employee = new Employee("Adam", "###", 45);

			//act
			employee.AddScore(4);
			employee.AddScore(5);
			employee.LostScore(4);
			employee.LostScore(5);

			// assert
			Assert.AreEqual(0, employee.Result);
		}
	}
}