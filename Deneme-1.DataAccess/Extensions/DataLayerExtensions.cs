using Deneme_1.Core.DataAccess.Abstract;
using Deneme_1.Core.DataAccess.EntityFramework;
using Deneme_1.DataAccess.Abstract;
using Deneme_1.DataAccess.Concrete;
using Deneme_1.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_1.DataAccess.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddDbContext<DataContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("DBConStr"));
			});
			services.AddScoped<IProductDal, EfProductDal>();
			services.AddScoped<ICategoryDal,EfCategoryDal>();
			//services.AddScoped(typeof(IEntityRepository<>), typeof(EfEntityRepositoryBase<>));
			return services;
		}
	}
}
