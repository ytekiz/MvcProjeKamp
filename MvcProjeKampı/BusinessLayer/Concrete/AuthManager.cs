using System;
using BusinessLayer.Abstract;
using BusinessLayer.Utilities.Security.Hashing;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthManager : IAuthService
    {
      
        IWriterService _writerService;

        public AuthManager( IWriterService writerService)
        {
           
            _writerService = writerService;
        }

        

       
        public bool WriterLogin(WriterLoginDto writerLoginDto)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var writer = _writerService.GetList();
                foreach (var item in writer)
                {
                    if (HashingHelper.WriterVerifyPasswordHash(writerLoginDto.WriterPassword))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void WriterRegister(string mail, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.WriterCreatePasswordHash(password, out passwordHash, out passwordSalt);
            var writer = new Writer
            {
                WriterMail = mail,
                WriterPassword = password,
               
            };
            _writerService.WriterAdd(writer);
        }



    }
}
