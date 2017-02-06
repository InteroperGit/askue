using Askue.Infrastructure.Domain.Model.Shared;

namespace Askue.Domain.Model.Administration.Dao
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class UserDao : EntityDao<int>
	{
		#region properties

		/// <summary>
		/// Имя
		/// </summary>
		public virtual string Name { get; set; }

		/// <summary>
		/// Фамилия
		/// </summary>
		public virtual string LastName { get; set; }

		/// <summary>
		/// Отчество
		/// </summary>
		public virtual string Patronymic { get; set; }

		/// <summary>
		/// Полное имя
		/// </summary>
		public virtual string FullName
		{
			get { return string.Format("{0} {1} {2}", LastName, Name, Patronymic).Trim(); }
		}

		#endregion

		#region methods

		#region protected

		protected bool Equals(UserDao other)
		{
			return Id.Equals(other.Id)
			       && Name.Equals(other.Name)
			       && LastName.Equals(other.LastName)
			       && Patronymic.Equals(other.Patronymic);
		}

		#endregion

		#region override

		#endregion

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((UserDao)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = Id.GetHashCode();
				hashCode = (hashCode * 397) ^ Name.GetHashCode();
				hashCode = (hashCode * 397) ^ LastName.GetHashCode();
				hashCode = (hashCode * 397) ^ Patronymic.GetHashCode();
				return hashCode;
			}
		}

		#endregion
	}
}