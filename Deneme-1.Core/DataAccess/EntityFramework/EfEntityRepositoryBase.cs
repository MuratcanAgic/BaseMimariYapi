using Deneme_1.Core.DataAccess.Abstract;
using Deneme_1.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_1.Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T> where T : class, IEntityBase, new() where TContext : DbContext, new()
	{
		private readonly DbContext _dbContext;
		public EfEntityRepositoryBase(DbContext context)
		{
			_dbContext = context;
		}

		public void Add(T entity)
		{

			var addedEntity = _dbContext.Entry(entity);
			addedEntity.State = EntityState.Added;
			_dbContext.SaveChanges();
		}
		public void Delete(T entity)
		{
			var deletedEntity = _dbContext.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			_dbContext.SaveChanges();

		}

		public T Get(Expression<Func<T, bool>> filter)
		{
			return _dbContext.Set<T>().SingleOrDefault(filter);

		}

		public List<T> GetAll(Expression<Func<T, bool>> filter = null)
		{
			return filter == null ? _dbContext.Set<T>().ToList() : _dbContext.Set<T>().Where(filter).ToList();

		}

		public void Update(T entity)
		{

			var updatedEntity = _dbContext.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			_dbContext.SaveChanges();
		}
	}
}
