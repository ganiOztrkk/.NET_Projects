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
	public class AdminManager : IAdminService
	{
        private readonly IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void TDelete(Admin t)
		{
			_adminDal.Delete(t);
		}

		public Admin TGetById(int id)
		{
			return _adminDal.GetById(id);
		}

		public List<Admin> TGetListAll()
		{
			return _adminDal.GetListAll();
		}

		public void TInsert(Admin t)
		{
			_adminDal.Insert(t);
		}

		public void TUpdate(Admin t)
		{
			_adminDal.Update(t);
		}
	}
}
