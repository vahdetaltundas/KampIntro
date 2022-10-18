using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService Mernis, json, api yapısını araştır.
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamers gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
            
        }

        public void Delete(Gamers gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamers gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
