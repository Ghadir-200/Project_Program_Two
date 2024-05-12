using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_one_player_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_one_player frm_One_Player = new frm_one_player();
            frm_One_Player.Show();
        }

        private void btn_two_player_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_two_player frm_Two_Player = new frm_two_player();
            frm_Two_Player.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
