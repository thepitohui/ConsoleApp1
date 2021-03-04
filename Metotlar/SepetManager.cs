using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        List<Urun> sepet = new List<Urun>();


        public void Ekle(Urun urun)
        {
            sepet.Add(urun);            
            Console.WriteLine(urun.Adi + " sepete eklendi.");
        }

        public void Listele()
        {
            Console.WriteLine();
        }
    }
}
