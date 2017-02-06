namespace Askue.Infrastructure.Domain.Model.Shared
{
	/// <summary>
	/// Базовая DAO-сущность
	/// </summary>
	/// <typeparam name="T">Тип ключа сущности</typeparam>
	public abstract class EntityDao<T>
	{
		#region properties

		public virtual T Id { get; set; }

		#endregion

		#region methods

		#endregion
	}
}