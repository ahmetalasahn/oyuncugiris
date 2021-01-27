using System;

namespace ODEV
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerService gamerService = new GamerService(new UserValidationManager());
            gamerService.Add(new Gamer { Id=1,BirthYear=1985,FirstName="Ahmet",LastName="Alaşahin",IdentityNumber=12345678911});
        }
    }
}
