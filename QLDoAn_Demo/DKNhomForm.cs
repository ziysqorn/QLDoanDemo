using DatabaseConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoAn_Demo
{
	public partial class DKNhomForm : Form
	{
		public DKDoAnForm DKDoan;
		string MasoDetai;
		string MSSV;
		public DKNhomForm()
		{
			InitializeComponent();
		}

		public DKNhomForm(DKDoAnForm dKDoAnForm, string masoDetai, string mSSV)
		{
			InitializeComponent();
			DKDoan = dKDoAnForm;
			MasoDetai = masoDetai;
			MSSV = mSSV;
		}

		private void btnTaoNhom_Click(object sender, EventArgs e)
		{
			ThemTVForm themTV = new ThemTVForm(this, MasoDetai, MSSV);
			themTV.Show();
			themTV.BringToFront();
		}

		private void DKNhomForm_Load(object sender, EventArgs e)
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllNhom(dbConfig.Connection, lvNhom);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			for(int i= 0; i < lvNhom.Items.Count; ++i)
			{
				if (dbConfig.CheckNhomHaveGV(lvNhom.Items[i].Text, dbConfig.Connection))
				{
					lvNhom.Items[i].SubItems[2].Text = dbConfig.ReadGVHD(lvNhom.Items[i].Text, dbConfig.Connection);
				}
			}
			dbConfig.Connection.Close();
		}

		private void DKNhomForm_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
	}
}
