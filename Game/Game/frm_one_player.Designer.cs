namespace Game
{
    partial class frm_one_player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_my = new System.Windows.Forms.Label();
            this.lab_computer = new System.Windows.Forms.Label();
            this.btn_again = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panal_buttons = new System.Windows.Forms.Panel();
            this.btn_six = new Guna.UI2.WinForms.Guna2Button();
            this.btn_five = new Guna.UI2.WinForms.Guna2Button();
            this.btn_four = new Guna.UI2.WinForms.Guna2Button();
            this.btn_three = new Guna.UI2.WinForms.Guna2Button();
            this.btn_two = new Guna.UI2.WinForms.Guna2Button();
            this.btn_one = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nine = new Guna.UI2.WinForms.Guna2Button();
            this.btn_eight = new Guna.UI2.WinForms.Guna2Button();
            this.btn_seven = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.panal_buttons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(575, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(799, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_my
            // 
            this.lab_my.AutoSize = true;
            this.lab_my.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_my.ForeColor = System.Drawing.Color.Purple;
            this.lab_my.Location = new System.Drawing.Point(658, 359);
            this.lab_my.Name = "lab_my";
            this.lab_my.Size = new System.Drawing.Size(49, 48);
            this.lab_my.TabIndex = 5;
            this.lab_my.Text = "0";
            this.lab_my.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_computer
            // 
            this.lab_computer.AutoSize = true;
            this.lab_computer.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_computer.ForeColor = System.Drawing.Color.White;
            this.lab_computer.Location = new System.Drawing.Point(874, 359);
            this.lab_computer.Name = "lab_computer";
            this.lab_computer.Size = new System.Drawing.Size(49, 48);
            this.lab_computer.TabIndex = 6;
            this.lab_computer.Text = "0";
            this.lab_computer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_again
            // 
            this.btn_again.BorderRadius = 15;
            this.btn_again.BorderThickness = 1;
            this.btn_again.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_again.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_again.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_again.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_again.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_again.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_again.ForeColor = System.Drawing.Color.White;
            this.btn_again.Location = new System.Drawing.Point(601, 516);
            this.btn_again.Name = "btn_again";
            this.btn_again.Size = new System.Drawing.Size(184, 45);
            this.btn_again.TabIndex = 7;
            this.btn_again.Text = "Play Again";
            this.btn_again.Click += new System.EventHandler(this.btn_again_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BorderRadius = 15;
            this.btn_exit.BorderThickness = 1;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(824, 516);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(168, 45);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(791, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 50);
            this.panel1.TabIndex = 9;
            // 
            // panal_buttons
            // 
            this.panal_buttons.Controls.Add(this.panel7);
            this.panal_buttons.Controls.Add(this.panel5);
            this.panal_buttons.Controls.Add(this.panel4);
            this.panal_buttons.Controls.Add(this.panel3);
            this.panal_buttons.Controls.Add(this.btn_one);
            this.panal_buttons.Controls.Add(this.btn_seven);
            this.panal_buttons.Controls.Add(this.btn_four);
            this.panal_buttons.Controls.Add(this.btn_two);
            this.panal_buttons.Controls.Add(this.btn_three);
            this.panal_buttons.Controls.Add(this.btn_eight);
            this.panal_buttons.Controls.Add(this.btn_nine);
            this.panal_buttons.Controls.Add(this.btn_five);
            this.panal_buttons.Controls.Add(this.btn_six);
            this.panal_buttons.Location = new System.Drawing.Point(12, 25);
            this.panal_buttons.Name = "panal_buttons";
            this.panal_buttons.Size = new System.Drawing.Size(523, 460);
            this.panal_buttons.TabIndex = 10;
            this.panal_buttons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_six
            // 
            this.btn_six.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_six.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_six.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_six.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_six.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_six.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_six.Location = new System.Drawing.Point(338, 173);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(120, 111);
            this.btn_six.TabIndex = 0;
            // 
            // btn_five
            // 
            this.btn_five.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_five.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_five.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_five.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_five.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_five.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_five.Location = new System.Drawing.Point(194, 173);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(120, 111);
            this.btn_five.TabIndex = 1;
            // 
            // btn_four
            // 
            this.btn_four.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_four.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_four.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_four.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_four.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_four.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_four.Location = new System.Drawing.Point(51, 173);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(120, 111);
            this.btn_four.TabIndex = 2;
            // 
            // btn_three
            // 
            this.btn_three.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_three.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_three.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_three.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_three.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_three.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_three.Location = new System.Drawing.Point(339, 43);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(120, 111);
            this.btn_three.TabIndex = 0;
            // 
            // btn_two
            // 
            this.btn_two.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_two.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_two.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_two.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_two.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_two.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_two.Location = new System.Drawing.Point(194, 44);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(120, 111);
            this.btn_two.TabIndex = 1;
            // 
            // btn_one
            // 
            this.btn_one.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_one.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_one.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_one.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_one.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_one.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_one.Location = new System.Drawing.Point(51, 43);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(120, 111);
            this.btn_one.TabIndex = 2;
            // 
            // btn_nine
            // 
            this.btn_nine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_nine.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_nine.Location = new System.Drawing.Point(337, 308);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(120, 111);
            this.btn_nine.TabIndex = 0;
            // 
            // btn_eight
            // 
            this.btn_eight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eight.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_eight.Location = new System.Drawing.Point(194, 308);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(120, 111);
            this.btn_eight.TabIndex = 1;
            // 
            // btn_seven
            // 
            this.btn_seven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_seven.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_seven.Location = new System.Drawing.Point(50, 310);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(120, 111);
            this.btn_seven.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(325, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 380);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Location = new System.Drawing.Point(179, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 380);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(48, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 5);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Location = new System.Drawing.Point(0, -133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(473, 5);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Purple;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(47, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(413, 5);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Purple;
            this.panel8.Location = new System.Drawing.Point(0, -133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(473, 5);
            this.panel8.TabIndex = 5;
            // 
            // move
            // 
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // frm_one_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1038, 582);
            this.Controls.Add(this.panal_buttons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_again);
            this.Controls.Add(this.lab_computer);
            this.Controls.Add(this.lab_my);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_one_player";
            this.Text = "frm_one_player";
            this.Load += new System.EventHandler(this.frm_one_player_Load);
            this.panal_buttons.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_my;
        private System.Windows.Forms.Label lab_computer;
        private Guna.UI2.WinForms.Guna2Button btn_again;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panal_buttons;
        private Guna.UI2.WinForms.Guna2Button btn_six;
        private Guna.UI2.WinForms.Guna2Button btn_one;
        private Guna.UI2.WinForms.Guna2Button btn_seven;
        private Guna.UI2.WinForms.Guna2Button btn_four;
        private Guna.UI2.WinForms.Guna2Button btn_two;
        private Guna.UI2.WinForms.Guna2Button btn_three;
        private Guna.UI2.WinForms.Guna2Button btn_eight;
        private Guna.UI2.WinForms.Guna2Button btn_nine;
        private Guna.UI2.WinForms.Guna2Button btn_five;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer move;
    }
}