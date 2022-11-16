using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class entityPersonel
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private string _sehir;
        private string _gorev;
        private short _maas;

        public int Id { get => _id; set => _id = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string Sehir { get => _sehir; set => _sehir = value; }
        public string Gorev { get => _gorev; set => _gorev = value; }
        public short Maas { get => _maas; set => _maas = value; }
    }
}
