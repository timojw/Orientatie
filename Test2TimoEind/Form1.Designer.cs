namespace Test2TimoEind
{
    partial class Form1
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
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.label_Dead = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScoreBoard = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonChangePause = new System.Windows.Forms.Button();
            this.buttonChangeBackward = new System.Windows.Forms.Button();
            this.buttonChangeForward = new System.Windows.Forms.Button();
            this.buttonChangeCrouch = new System.Windows.Forms.Button();
            this.buttonChangeJump = new System.Windows.Forms.Button();
            this.pb_box2 = new System.Windows.Forms.PictureBox();
            this.pb_box1 = new System.Windows.Forms.PictureBox();
            this.pb_box3 = new System.Windows.Forms.PictureBox();
            this.pb_box4 = new System.Windows.Forms.PictureBox();
            this.pb_box6 = new System.Windows.Forms.PictureBox();
            this.pb_box5 = new System.Windows.Forms.PictureBox();
            this.pointBox1 = new System.Windows.Forms.PictureBox();
            this.pointBox2 = new System.Windows.Forms.PictureBox();
            this.pointBox3 = new System.Windows.Forms.PictureBox();
            this.pointBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_Player.Location = new System.Drawing.Point(344, 325);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(25, 50);
            this.pb_Player.TabIndex = 2;
            this.pb_Player.TabStop = false;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(3, -5);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(432, 51);
            this.label_Dead.TabIndex = 3;
            this.label_Dead.Text = "Game staat op pauze";
            this.label_Dead.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScoreBoard);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.buttonChangePause);
            this.groupBox1.Controls.Add(this.buttonChangeBackward);
            this.groupBox1.Controls.Add(this.buttonChangeForward);
            this.groupBox1.Controls.Add(this.buttonChangeCrouch);
            this.groupBox1.Controls.Add(this.buttonChangeJump);
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 366);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pause";
            this.groupBox1.Visible = false;
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.FormattingEnabled = true;
            this.ScoreBoard.Location = new System.Drawing.Point(275, 19);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(393, 329);
            this.ScoreBoard.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sprint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pause";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Crouch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jump";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(52, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "wip";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonChangePause
            // 
            this.buttonChangePause.Enabled = false;
            this.buttonChangePause.Location = new System.Drawing.Point(52, 156);
            this.buttonChangePause.Name = "buttonChangePause";
            this.buttonChangePause.Size = new System.Drawing.Size(166, 23);
            this.buttonChangePause.TabIndex = 7;
            this.buttonChangePause.Text = "P";
            this.buttonChangePause.UseVisualStyleBackColor = true;
            // 
            // buttonChangeBackward
            // 
            this.buttonChangeBackward.Enabled = false;
            this.buttonChangeBackward.Location = new System.Drawing.Point(52, 77);
            this.buttonChangeBackward.Name = "buttonChangeBackward";
            this.buttonChangeBackward.Size = new System.Drawing.Size(166, 23);
            this.buttonChangeBackward.TabIndex = 6;
            this.buttonChangeBackward.Text = "D";
            this.buttonChangeBackward.UseVisualStyleBackColor = true;
            // 
            // buttonChangeForward
            // 
            this.buttonChangeForward.Enabled = false;
            this.buttonChangeForward.Location = new System.Drawing.Point(52, 106);
            this.buttonChangeForward.Name = "buttonChangeForward";
            this.buttonChangeForward.Size = new System.Drawing.Size(166, 23);
            this.buttonChangeForward.TabIndex = 5;
            this.buttonChangeForward.Text = "A";
            this.buttonChangeForward.UseVisualStyleBackColor = true;
            // 
            // buttonChangeCrouch
            // 
            this.buttonChangeCrouch.Enabled = false;
            this.buttonChangeCrouch.Location = new System.Drawing.Point(52, 48);
            this.buttonChangeCrouch.Name = "buttonChangeCrouch";
            this.buttonChangeCrouch.Size = new System.Drawing.Size(166, 23);
            this.buttonChangeCrouch.TabIndex = 4;
            this.buttonChangeCrouch.Text = "Shift";
            this.buttonChangeCrouch.UseVisualStyleBackColor = true;
            // 
            // buttonChangeJump
            // 
            this.buttonChangeJump.Enabled = false;
            this.buttonChangeJump.Location = new System.Drawing.Point(52, 19);
            this.buttonChangeJump.Name = "buttonChangeJump";
            this.buttonChangeJump.Size = new System.Drawing.Size(166, 23);
            this.buttonChangeJump.TabIndex = 3;
            this.buttonChangeJump.Text = "Space";
            this.buttonChangeJump.UseVisualStyleBackColor = true;
            // 
            // pb_box2
            // 
            this.pb_box2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box2.Location = new System.Drawing.Point(539, 321);
            this.pb_box2.Name = "pb_box2";
            this.pb_box2.Size = new System.Drawing.Size(100, 50);
            this.pb_box2.TabIndex = 12;
            this.pb_box2.TabStop = false;
            // 
            // pb_box1
            // 
            this.pb_box1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box1.Location = new System.Drawing.Point(135, 381);
            this.pb_box1.Name = "pb_box1";
            this.pb_box1.Size = new System.Drawing.Size(341, 50);
            this.pb_box1.TabIndex = 10;
            this.pb_box1.TabStop = false;
            // 
            // pb_box3
            // 
            this.pb_box3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box3.Location = new System.Drawing.Point(0, 321);
            this.pb_box3.Name = "pb_box3";
            this.pb_box3.Size = new System.Drawing.Size(84, 110);
            this.pb_box3.TabIndex = 14;
            this.pb_box3.TabStop = false;
            // 
            // pb_box4
            // 
            this.pb_box4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box4.Location = new System.Drawing.Point(135, 247);
            this.pb_box4.Name = "pb_box4";
            this.pb_box4.Size = new System.Drawing.Size(197, 38);
            this.pb_box4.TabIndex = 15;
            this.pb_box4.TabStop = false;
            // 
            // pb_box6
            // 
            this.pb_box6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box6.Location = new System.Drawing.Point(375, 205);
            this.pb_box6.Name = "pb_box6";
            this.pb_box6.Size = new System.Drawing.Size(60, 131);
            this.pb_box6.TabIndex = 16;
            this.pb_box6.TabStop = false;
            // 
            // pb_box5
            // 
            this.pb_box5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_box5.Location = new System.Drawing.Point(481, 144);
            this.pb_box5.Name = "pb_box5";
            this.pb_box5.Size = new System.Drawing.Size(119, 79);
            this.pb_box5.TabIndex = 17;
            this.pb_box5.TabStop = false;
            // 
            // pointBox1
            // 
            this.pointBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointBox1.Location = new System.Drawing.Point(144, 353);
            this.pointBox1.Name = "pointBox1";
            this.pointBox1.Size = new System.Drawing.Size(18, 17);
            this.pointBox1.TabIndex = 18;
            this.pointBox1.TabStop = false;
            // 
            // pointBox2
            // 
            this.pointBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointBox2.Location = new System.Drawing.Point(556, 121);
            this.pointBox2.Name = "pointBox2";
            this.pointBox2.Size = new System.Drawing.Size(18, 17);
            this.pointBox2.TabIndex = 19;
            this.pointBox2.TabStop = false;
            // 
            // pointBox3
            // 
            this.pointBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointBox3.Location = new System.Drawing.Point(221, 161);
            this.pointBox3.Name = "pointBox3";
            this.pointBox3.Size = new System.Drawing.Size(18, 17);
            this.pointBox3.TabIndex = 20;
            this.pointBox3.TabStop = false;
            // 
            // pointBox4
            // 
            this.pointBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointBox4.Location = new System.Drawing.Point(399, 358);
            this.pointBox4.Name = "pointBox4";
            this.pointBox4.Size = new System.Drawing.Size(18, 17);
            this.pointBox4.TabIndex = 21;
            this.pointBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointBox4);
            this.Controls.Add(this.pointBox3);
            this.Controls.Add(this.pointBox2);
            this.Controls.Add(this.pointBox1);
            this.Controls.Add(this.pb_box5);
            this.Controls.Add(this.pb_box6);
            this.Controls.Add(this.pb_box4);
            this.Controls.Add(this.pb_box3);
            this.Controls.Add(this.pb_box2);
            this.Controls.Add(this.pb_box1);
            this.Controls.Add(this.label_Dead);
            this.Controls.Add(this.pb_Player);
            this.Name = "Form1";
            this.Text = "Timo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonChangePause;
        private System.Windows.Forms.Button buttonChangeBackward;
        private System.Windows.Forms.Button buttonChangeForward;
        private System.Windows.Forms.Button buttonChangeCrouch;
        public System.Windows.Forms.Button buttonChangeJump;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_box1;
        private System.Windows.Forms.PictureBox pb_box2;
        private System.Windows.Forms.PictureBox pb_box3;
        private System.Windows.Forms.PictureBox pb_box4;
        private System.Windows.Forms.PictureBox pb_box6;
        private System.Windows.Forms.PictureBox pb_box5;
        private System.Windows.Forms.ListBox ScoreBoard;
        private System.Windows.Forms.PictureBox pointBox1;
        private System.Windows.Forms.PictureBox pointBox2;
        private System.Windows.Forms.PictureBox pointBox3;
        private System.Windows.Forms.PictureBox pointBox4;
        private System.Windows.Forms.Label label1;
    }
}

