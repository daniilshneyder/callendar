using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callendar
{
    public partial class cal : Form
    {
        private Point last;

        public cal()
        {
            InitializeComponent();

            this.pass.AutoSize = false;

            this.pass.Size = new Size(this.pass.Size.Width, 25);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last.X;
                this.Top += e.Y - last.Y;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Silver;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            String LoginUser = log.Text;
            String PassUser = pass.Text;

            bd db = new bd();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `reg` WRERE  'log' = @UL AND 'pass' = @UP", db.getConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
               MessageBox.Show("Yes");
            else
               MessageBox.Show("YNo");


        }
    }
}
