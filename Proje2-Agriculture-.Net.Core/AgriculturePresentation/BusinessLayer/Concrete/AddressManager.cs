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
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(Address t)
        {
            throw new NotImplementedException();
        }

        public Address TGetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> TGetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void TInsert(Address t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Address t)
        {
            _addressDal.Update(t);
        }
    }
}
