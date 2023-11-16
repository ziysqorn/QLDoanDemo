using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConfig;

namespace QLDoAn_Demo
{
	public partial class DKDoAnForm : Form
	{
		public LoginForm Loginform;
		string MSSV;
		public DKDoAnForm()
		{
			InitializeComponent();
		}
		public DKDoAnForm(LoginForm loginForm, string mSSV)
		{
			InitializeComponent();
			Loginform = loginForm;
			MSSV = mSSV;
		}

		private void DKDoAnForm_Load(object sender, EventArgs e)
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllDeTai(dbConfig.Connection, lvDSDetai);
			dbConfig.Connection.Close();
		}

		private void DKDoAnForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Loginform.Show();
			Loginform.BringToFront();
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			if(lvDSDetai.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn đề tài !");
			}
			else
			{
				string MaloaiDoan = lvDSDetai.SelectedItems[0].SubItems[3].Text;
				if (MaloaiDoan != "LDA3")
				{
					DKNhomForm dKNhomForm = new DKNhomForm(this, lvDSDetai.SelectedItems[0].Text, MSSV);
					dKNhomForm.Show();
					dKNhomForm.BringToFront();
				}
				else
				{
					DbConfig dbConfig = new DbConfig();
					dbConfig.Connection.Open();
					if (dbConfig.CheckSVXuatSac(MSSV, dbConfig.Connection))
					{
						DKNhomForm dKNhomForm = new DKNhomForm(this, lvDSDetai.SelectedItems[0].Text, MSSV);
						dKNhomForm.Show();
						dKNhomForm.BringToFront();
					}
					else
					{
						MessageBox.Show("Sinh viên không xuất sắc không được chọn loại đồ án 3 !");
					}
					dbConfig.Connection.Close();
				}
			}
		}
	}
}
