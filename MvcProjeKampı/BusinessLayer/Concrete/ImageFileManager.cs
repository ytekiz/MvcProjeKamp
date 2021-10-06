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
 public   class ImageFileManager : IImageFileService
    {
        IImageFileDal ımageFileDal;

        public ImageFileManager(IImageFileDal ımageFileDal)
        {
            this.ımageFileDal = ımageFileDal;
        }

        public List<ImageFile> GetList()
        {
            return ımageFileDal.List();
        }
    }
}
