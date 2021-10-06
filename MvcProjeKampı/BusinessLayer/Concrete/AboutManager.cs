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
   public class AboutManager:IAboutService
    {
        IAboutDal _aboutdal;

        public void AboutAdd(About about)
        {
            _aboutdal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _aboutdal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutdal.Update(about);
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
