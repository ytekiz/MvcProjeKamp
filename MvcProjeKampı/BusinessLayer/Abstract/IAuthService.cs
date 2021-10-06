using System;
using EntityLayer.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuthService
    {
      
        bool WriterLogin(WriterLoginDto writerLoginDto);
        void WriterRegister(string mail, string password);

    }
}
