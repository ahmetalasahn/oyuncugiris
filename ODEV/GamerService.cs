using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV
{
    class GamerService : IGamerService
    {
        UserValidationManager _userValidationManager;
        public GamerService(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu!");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi!");
        }
    }
}
