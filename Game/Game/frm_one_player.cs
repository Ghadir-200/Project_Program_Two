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
    public partial class frm_one_player : Form
    {
        public frm_one_player()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        List<Guna.UI2.WinForms.Guna2Button> buttons;
        Random random= new Random();
        int player1 = 0;
        int player2 = 0;
        public void loadbuttons()
        {
            buttons = new List<Guna.UI2.WinForms.Guna2Button> 
            { 
                btn_one, btn_two, btn_three, btn_four, 
                btn_five, btn_six, btn_seven, btn_eight, btn_nine 
            };
        }

        public void win_change_color(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor=Color.Yellow;
            b2.ForeColor=Color.Yellow;
            b3.ForeColor=Color.Yellow;
            if (b1.Text =="X" )
            {
                player1++;
                    lab_my.Text = player1.ToString();
            }
            else
            {
                player2++;
                lab_computer.Text = player2.ToString();
            }
        }
        bool win= false;
         public void Get_the_winner()
        {
            if (btn_one.Text!=""&&btn_one.Text==btn_two.Text &&btn_one.Text==btn_three.Text)
            {
                win_change_color(btn_one, btn_two, btn_three);
                win=true;
            }
            else if(btn_four.Text!="" && btn_four.Text==btn_five.Text && btn_four.Text==btn_six.Text) 
            {
                win_change_color(btn_four, btn_five, btn_six);
                win=true;
            }
            else if (btn_seven.Text!=""&& btn_seven.Text==btn_eight.Text && btn_seven.Text==btn_nine.Text)
            {
                win_change_color(btn_seven, btn_eight, btn_nine);
                win=true;
            }
            else if(btn_one.Text!=""&& btn_one.Text == btn_four.Text & btn_one == btn_seven)
            {
                win_change_color(btn_one,btn_four,btn_seven);
                win=true;
            }
            else if(btn_two.Text!="" && btn_two.Text == btn_five.Text && btn_two.Text == btn_eight.Text)
            {
                win_change_color(btn_eight,btn_five,btn_two);
            }
            else if (btn_three.Text!="" &&btn_three.Text==btn_six.Text&&btn_three.Text==btn_nine.Text)
            {
                win_change_color(btn_nine, btn_six, btn_three);
                win=true;
            }
            else if(btn_three.Text!="" && btn_three.Text == btn_five.Text && btn_three.Text == btn_seven.Text)
            {
                win_change_color(btn_five,btn_seven,btn_three);
                win=true;
            }
            else if(btn_one.Text!="" && btn_one.Text == btn_five.Text && btn_one.Text == btn_nine.Text)
            {
                win_change_color(btn_nine,btn_one,btn_five);
                win=true;
            }
        }
        private void frm_one_player_Load(object sender, EventArgs e)
        {
            foreach (Control c in panal_buttons.Controls)
            {
                if(c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
            loadbuttons();
        }

        private void btn_click(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if(btn.Text.Equals("")) 
            {
                btn.Text = "X";
                btn.ForeColor = Color.Red;
                buttons.Remove(btn);
                Get_the_winner();
                move.Start();
            }
        }

        private void move_Tick(object sender, EventArgs e)
        {
            if(buttons.Count > 0 && win==false)
            {
                int index=random.Next(buttons.Count);
                if (buttons[index].Text   == "")
                {
                    buttons[index].ForeColor = Color.Lime;
                    buttons[index].Text = "O";
                    buttons.RemoveAt(index);
                    Get_the_winner() ;
                    move.Stop();
                }
            }
        }

        private void btn_again_Click(object sender, EventArgs e)
        {
            loadbuttons();
            win = false;
            foreach (Control c in panal_buttons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }
    }
}
