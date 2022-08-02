using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void closeprog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point snepoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - snepoint.X;
                this.Top += e.Y - snepoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            snepoint = new Point(e.X, e.Y);
        }

        private void label123_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void name_TextChanged(object sender, EventArgs e)
        { 
        }

        private void name_VisibleChanged(object sender, EventArgs e)
        {
           // StreamReader sr = new StreamReader("sessions.txt");
           // name.Text = "Пользователь: " + sr.ReadLine().ToString();
          //  sr.Close();
          //  if (name.Text == "")
          //  {
          //      MessageBox.Show("Ошибка!! Ник не найден Проверьте txt файл");
          //  }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
