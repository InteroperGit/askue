using Askue.Domain.Model.Administration.Dao;
using NUnit.Framework;

namespace Domain.Model.Administration.Dao.Tests
{
	[TestFixture]
	public class UserTests
	{
		#region fields

		private UserDao _user;

		#endregion

		[OneTimeSetUp]
		public void Init()
		{
			_user = new UserDao()
			{
				Name = "Максим",
				LastName = "Матвеев",
				Patronymic = "Евгеньевич"
			};
		}

		[Test]
		public void FullNameTest()
		{
			Assert.That(_user.FullName, 
						Is.EqualTo(string.Format("{0} {1} {2}", _user.LastName, _user.Name, _user.Patronymic).Trim()));
			Assert.Pass("Your first passing test");
		}
	}
}
