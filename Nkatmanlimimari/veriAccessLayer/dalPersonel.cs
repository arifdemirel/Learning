using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layerEntity;
using System.Data;

namespace veriAccessLayer
{
    public class dalPersonel
    {
        public static List<entityPersonel> PersonelListesi()
        {
            List<entityPersonel> degerler = new List<entityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_bilgi", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                entityPersonel entper = new entityPersonel();
                entper.Id = int.Parse(dr["ID"].ToString());
                entper.Ad = dr["AD"].ToString();
                entper.Soyad = dr["SOYAD"].ToString();
                entper.Gorev = dr["GOREV"].ToString();
                entper.Maas = short.Parse(dr["MAAS"].ToString());
                entper.Sehir = dr["SEHIR"].ToString();
                degerler.Add(entper);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(entityPersonel p)
        {

            SqlCommand command2 = new SqlCommand("INSERT INTO tbl_bilgi (AD,SOYAD,GOREV,SEHIR,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)", Baglanti.bgl);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }


            command2.Parameters.AddWithValue("@P1", p.Ad);
            command2.Parameters.AddWithValue("@P2", p.Soyad);
            command2.Parameters.AddWithValue("@p3", p.Gorev);
            command2.Parameters.AddWithValue("@p4", p.Sehir);
            command2.Parameters.AddWithValue("@p5", p.Maas);
            return command2.ExecuteNonQuery();


        }

        public static bool PersonelSil(int p)
        {
            SqlCommand command3 = new SqlCommand("DELETE FROM tbl_bilgi WHERE ID=@P1", Baglanti.bgl);



            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1", p);
            return command3.ExecuteNonQuery() > 0;
        }


        public static bool PersonelGuncelle(entityPersonel entguncelle)
        {
            SqlCommand command4 = new SqlCommand("UPDATE tbl_bilgi SET AD=@P1, SOYAD=@P2, MAAS=@P3, SEHIR=@P4, GOREV=@P5 WHERE ID=@P6", Baglanti.bgl);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();

            }
            command4.Parameters.AddWithValue("@p1",entguncelle.Ad);
            command4.Parameters.AddWithValue("@p2", entguncelle.Soyad);
            command4.Parameters.AddWithValue("@p3", entguncelle.Maas);
            command4.Parameters.AddWithValue("@p4", entguncelle.Sehir);
            command4.Parameters.AddWithValue("@p5", entguncelle.Gorev);
            command4.Parameters.AddWithValue("@p6", entguncelle.Id);
            return command4.ExecuteNonQuery() > 0;
        }
    }
}
