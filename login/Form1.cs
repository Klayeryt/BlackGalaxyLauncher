using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginField.Text = "Логин";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String host = System.Net.Dns.GetHostName();
            System.Net.IPAddress ipsec = System.Net.Dns.GetHostByName(host).AddressList[0];
            string ip = ipsec.ToString();
            string sessionnum = "Авторизован: ";
            int sesid = 0;
            int sesh = sesid + 1;
            string id = "";
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            dbmysqlcon db = new dbmysqlcon();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sessionName = loginUser;

        MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP AND `ipuser` = @iU", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@iU", MySqlDbType.VarChar).Value = ip;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
               // Чтение TXT файла == Логин в админ-панели.
               System.IO.File.Create("session.txt");
               StreamWriter sw = new StreamWriter("sessions.txt");
               sw.WriteLine(sessionnum + loginField.Text);
               sw.Close();
               MessageBox.Show("Вы успешно авторизовались!");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

            if (table.Rows.Count > 0)
            {
                Form f41 = new main();
                this.Visible = false;
                f41.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Point onePoint;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onePoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - onePoint.X;
                this.Top += e.Y - onePoint.Y;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form f2 = new Register();
            this.Visible = false;
            f2.Show();
        }

        private void passField_Click(object sender, EventArgs e)
        {

        }

        private void passField_Leave(object sender, EventArgs e)
        {

        }

        private void passField_Enter(object sender, EventArgs e)
        {
        }

        private void loginField_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.FromArgb(78, 184, 206);
            }
        }

        private void label123_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void on_Click(object sender, EventArgs e)
        {

        }

        private void off_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/sinitskiy2k19");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/WEF3QMjwsE");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Klayeryt");
        }
    }
}
