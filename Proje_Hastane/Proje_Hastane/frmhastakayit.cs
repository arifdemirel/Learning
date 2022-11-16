using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class frmhastakayit : Form
    {
        public frmhastakayit()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();

        private void btnkayityap_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into tbl_Hasta(Hastatc,Hastaad,Hastasoyad,Hastatelefon,Hastasifre,Hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)" ,bgl._conn_());
            command.Parameters.AddWithValue("@p1", msktc.Text);
            command.Parameters.AddWithValue("@p2", txtad.Text);
            command.Parameters.AddWithValue("@p3", txtsoyad.Text);
            command.Parameters.AddWithValue("@p4", msktelefon.Text);
            command.Parameters.AddWithValue("@p5", txtsifre.Text);
            command.Parameters.AddWithValue("@p6", cboxcinsiyet.Text);
            command.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir, Şifreniz:" + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
