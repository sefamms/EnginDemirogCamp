using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        private readonly IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("doğrulama oldu");
            }
            else
            {
                Console.WriteLine("hata");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("güncellendi");
        }
    }
}
