using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    internal class entityDepartman
    {
        private int _id;
        private string _ad;
        private string _aciklama;

        public int Id { get => _id; set => _id = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
    }
}
