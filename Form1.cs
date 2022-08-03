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

namespace winBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void showdata()
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.conn))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from 銀行帳戶", cn);
                da.Fill(ds, "銀行帳戶");
                dt = ds.Tables["銀行帳戶"];
                dataGridView1.DataSource = dt;

            }
        }
        DataSet ds = new DataSet();
        DataTable dt;
        void clean()
        {
            tb_account.Text = "";
            tb_myaccount.Text = "";
            tb_money.Text = "";
            ds.Clear();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            dt.Clear();
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.conn))
            {
                cn.Open();
                if (tb_account.Text != "" && tb_myaccount.Text != "" && tb_money.Text != "")
                {
                    SqlDataAdapter dacheck = new SqlDataAdapter($"select * from 銀行帳戶 where 帳號='{tb_myaccount.Text}'",cn);
                    SqlDataAdapter dacheck2= new SqlDataAdapter($"select * from 銀行帳戶 where 帳號='{tb_account.Text}'", cn);
                    dacheck.Fill(ds,"檢查帳號");
                    dacheck2.Fill(ds,"檢查對方帳號");
                    DataTable dtcheck = ds.Tables["檢查帳號"];
                    DataTable dtcheck2 = ds.Tables["檢查對方帳號"];
                    try
                    {
                        if (dtcheck.Rows[0]["帳號"].ToString() != "" && dtcheck2.Rows[0]["帳號"].ToString() != "")
                        {
                            if ((int)dtcheck.Rows[0]["餘額"] >= int.Parse(tb_money.Text))
                            {
                                SqlDataAdapter daoutput = new SqlDataAdapter($"update 銀行帳戶 set 餘額-={tb_money.Text} where 帳號='{tb_myaccount.Text}'", cn);
                                SqlDataAdapter dainput = new SqlDataAdapter($"update 銀行帳戶 set 餘額+={tb_money.Text} where 帳號='{tb_account.Text}'", cn);
                                daoutput.Fill(ds, "轉出");
                                dainput.Fill(ds, "轉入");
                                MessageBox.Show("轉帳成功!!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clean();
                            }
                            else
                            {
                                MessageBox.Show("帳戶餘額不足!!");
                                clean();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("轉帳/目的帳號不存在");
                        clean();
                    }

                }
                else
                {
                    MessageBox.Show("欄位請勿空白!!", "錯誤提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                showdata();
            }

        }
    }
}
