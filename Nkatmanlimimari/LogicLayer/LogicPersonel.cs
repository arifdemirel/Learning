using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layerEntity;
using veriAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<entityPersonel> LLPersonelListesi()
        {
            return dalPersonel.PersonelListesi();
        }

        public static int LLPersonelEkle(entityPersonel p)
        {
            if (p.Ad!="" && p.Soyad!="" && p.Maas>=20000 && p.Sehir!="" && p.Gorev!="")
            {
                return dalPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int per)
        {
            if (per>= 1)
            {
                return dalPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }


        public static bool LLPersonelGuncelle(entityPersonel entgunc)
        {
            if (entgunc.Ad.Length >= 3 && entgunc.Ad != "" && entgunc.Soyad.Length >= 3 && entgunc.Maas >= 4500 && entgunc.Sehir != "" && entgunc.Gorev != "")
            {
                return dalPersonel.PersonelGuncelle(entgunc);
            }
            else
            {
                return false;
            }
                
        }
        
        
    }
}
