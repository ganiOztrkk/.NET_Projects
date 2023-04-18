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
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _imageDal = ımageDal;
        }

        public void TDelete(Image t)
        {
            _imageDal.Delete(t);
        }

        public Image TGetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public List<Image> TGetListAll()
        {
            return _imageDal.GetListAll();
        }

        public void TInsert(Image t)
        {
            _imageDal.Insert(t);
        }

        public void TUpdate(Image t)
        {
            _imageDal.Update(t);
        }
    }
}
