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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		private bool ContainsBlankSpace(string text)
		{
			if(text.Contains(" "))
			{
				return true;
			}
			return false;
		}
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text != "")
			{
				if (ContainsBlankSpace(txtUsername.Text))
				{
					MessageBox.Show("Username không được tồn tại khoảng trống !");
				}
				else
				{
						if (rdioSinhVien.Checked)
						{
							DbConfig dbConfig = new DbConfig();
							dbConfig.Connection.Open();
							if (dbConfig.ContainsData(string.Format("Select * from SinhVien where MSSV = '{0}'", txtUsername.Text.ToString()), dbConfig.Connection))
							{
								MessageBox.Show("Đăng nhập thành công !");
								dbConfig.Connection.Close();
								dbConfig.Connection.Open();
								int manhom = dbConfig.ReadNhomOfSV(txtUsername.Text, dbConfig.Connection);
								if (manhom != -1)
								{
									this.Hide();
									TrangchuSVForm trangchu = new TrangchuSVForm(manhom.ToString(), this);
									trangchu.Show();
									trangchu.BringToFront();
								}
								else
								{
									this.Hide();
									DKDoAnForm dKDoAnForm = new DKDoAnForm(this, txtUsername.Text);
									dKDoAnForm.Show();
									dKDoAnForm.BringToFront();
								}
								dbConfig.Connection.Close();
							}
							else { 
								MessageBox.Show("Sai Username sinh viên !");
								dbConfig.Connection.Close();
							}
						}
						else if(rdioGiaoVien.Checked) 
						{
							DbConfig dbConfig = new DbConfig();
							dbConfig.Connection.Open();
							if (dbConfig.ContainsData(string.Format("Select * from GiaoVien where MaGV = '{0}'", txtUsername.Text.ToString()), dbConfig.Connection))
							{
								MessageBox.Show("Đăng nhập thành công !");
								dbConfig.Connection.Close();
								this.Hide();
								TrangchuGV raDetaiForm = new TrangchuGV(this, txtUsername.Text);
								raDetaiForm.Show();
								raDetaiForm.BringToFront();
							}
							else { MessageBox.Show("Sai Username giáo viên !"); }
							dbConfig.Connection.Close();
						}
						else if(rdioBoMon.Checked)
						{
							DbConfig dbConfig = new DbConfig();
							string code = txtUsername.Text[0].ToString() +txtUsername.Text[1].ToString();
							if (code == "BM")
							{
								MessageBox.Show("Đăng nhập thành công !");
								dbConfig.Connection.Close();
								this.Hide();
								QLDetaiForm qLDetaiForm = new QLDetaiForm(this);
								qLDetaiForm.Show();
								qLDetaiForm.BringToFront();
							}
							else 
							{
								MessageBox.Show("Sai Username bộ môn !");
								dbConfig.Connection.Close();
							}
						}
						else
						{
							MessageBox.Show("Chưa chọn vai trò !");
						}
				}
			}
			else
			{
				MessageBox.Show("Không được để trống Username !");
			}
		}
	}
}
