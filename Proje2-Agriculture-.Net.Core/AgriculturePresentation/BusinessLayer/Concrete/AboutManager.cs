using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TDelete(About t)
		{
			throw new NotImplementedException();
		}

		public About TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> TGetListAll()
		{
			return _aboutDal.GetListAll();
		}

		public void TInsert(About t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(About t)
		{
			throw new NotImplementedException();
		}
	}
}
