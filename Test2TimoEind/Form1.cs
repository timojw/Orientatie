using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2TimoEind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Scores.Add(new PScore() { PlayerName = "babs", Punten = points });
            ScoreBoard.DataSource = Scores;
        }
        #region Variabelen

        PictureBox[] Obj = new PictureBox[10];
        PictureBox[] Point = new PictureBox[10];
        List<PScore> Scores = new List<PScore>();

        int babs = 9;
        int points = 0;
        int lengte = 50;
        int Gravity = 20;
        int Force = 0;
        int Speed_Movement = 3;
        int Speed_Jump = 3;
        int Speed_Fall = 3;
        Boolean Player_Jump = false;
        Boolean Player_Left = false;
        Boolean Player_Right = false;
        bool LastDirLeft = false;
        bool GameOn = true;
        bool gecroucht = false;


        #endregion
        #region LeesKeyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    if (GameOn)
                    {
                        GameOn = false;
                        label_Dead.Visible = true;
                        groupBox1.Visible = true;
                    }
                    else
                    {
                        GameOn = true;
                        label_Dead.Visible = false;
                        groupBox1.Visible = false;
                    }
                    break;
                case Keys.A:
                    Player_Left = true;
                    break;
                case Keys.D:
                    Player_Right = true;
                    break;
                case Keys.ShiftKey:
                    if (!gecroucht)
                    {
                        pb_Player.Height = pb_Player.Height - 15;
                        pb_Player.Top = pb_Player.Top + 15;
                        Speed_Movement = 1;
                        Speed_Jump = 3;
                        Speed_Fall = 10;
                        gecroucht = true;
                    }
                    break;
                case Keys.Space:
                    if (!Player_Jump)
                    {
                        pb_Player.Top -= Speed_Jump;
                        Force = Gravity;
                        Player_Jump = true;
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        Player_Left = false;
                        break;
                    case Keys.D:
                        Player_Right = false;
                        break;
                    case Keys.ShiftKey:
                        pb_Player.Top = pb_Player.Top - lengte + pb_Player.Height;
                        pb_Player.Height = lengte;
                        Speed_Movement = 3;
                        Speed_Jump = 3;
                        Speed_Fall = 3;
                        gecroucht = false;
                        break;
                }
            }
        }      
        #endregion
        #region TimerTicks
        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            Collision_Punt(pb_Player);
            if (pb_Player.Bottom > this.ClientRectangle.Bottom)
            {
                pb_Player.Top = this.ClientRectangle.Bottom - pb_Player.Height;
            }
            if (GameOn)
            {
                if (Player_Right && pb_Player.Right < this.ClientRectangle.Right && !Collision_Links(pb_Player))
                { 
                    pb_Player.Left += Speed_Movement; //Beweeg naar rechts
                    LastDirLeft = false;
                }
                if (Player_Left && pb_Player.Left > this.ClientRectangle.Left && !Collision_Rechts(pb_Player))
                { 
                    pb_Player.Left -= Speed_Movement; //Beweeg naar links
                    LastDirLeft = true;
                }
            }
            else
            {
                Player_Right = false;
                Player_Left = false;
            }
            if (Force > 0)
            {   
                if (Collision_Onder(pb_Player))
                { 
                Force = 0;
                }
                else
                {
                Force--;
                pb_Player.Top -= Speed_Jump;
                }
            }
            else
            {   
                Player_Jump = false;
            }
        }
        private void timer_Gravity_Tick(object sender, EventArgs e)
        {
            if (!Player_Jump && pb_Player.Bottom < this.ClientRectangle.Bottom + 2 && !Collision_Top(pb_Player))
            {   
                pb_Player.Top += Speed_Fall; //Speler valt
            }
            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height > this.ClientRectangle.Height - 1)
            {   
                pb_Player.Top--;
            }
        }
        #endregion
        #region checkFuncties
        public void Collision_Punt(PictureBox player)
        {
            foreach (PictureBox ob in Point)
            {
                if (ob != null)
                {
                    if (player.Bounds.IntersectsWith(ob.Bounds))
                    {
                        label1.Text = "babs";
                        points++;
                        Scores.RemoveAt(0);
                        Scores.Add(new PScore() { PlayerName = "babs", Punten = points });
                    }
                }
            }
        }
        public Boolean Collision_Top(PictureBox player)
        {
            foreach (PictureBox ob in Obj)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (player.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Onder(PictureBox player)
        {
            foreach (PictureBox ob in Obj)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (player.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Links(PictureBox player)
        {
            foreach (PictureBox ob in Obj)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (player.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Rechts(PictureBox player)
        {
            foreach (PictureBox ob in Obj)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (player.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        #endregion
        #region rest
        private void Form1_Load(object sender, EventArgs e)
        {
            Obj[0] = pb_box1;
            Obj[1] = pb_box2;
            Obj[2] = pb_box3;
            Obj[3] = pb_box4;
            Obj[4] = pb_box5;
            Obj[5] = pb_box6;
            Point[0] = pointBox1;
            Point[1] = pointBox2;
            Point[2] = pointBox3;
            Point[3] = pointBox4;
        }
        #endregion
    }
}
