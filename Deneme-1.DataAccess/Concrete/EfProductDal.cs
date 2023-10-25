using Deneme_1.Core.DataAccess.EntityFramework;
using Deneme_1.DataAccess.Abstract;
using Deneme_1.DataAccess.Context;
using Deneme_1.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_1.DataAccess.Concrete
{
	public class EfProductDal : EfEntityRepositoryBase<Product,DataContext>,IProductDal
	{
		private readonly DataContext _context;
        public EfProductDal(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
