using Deneme_1.Core.DataAccess.Abstract;
using Deneme_1.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_1.DataAccess.Abstract
{
	public interface ICategoryDal : IEntityRepository<Category>
	{
	}
}
