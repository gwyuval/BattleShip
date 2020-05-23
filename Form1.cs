using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zilelot
{
    public partial class Form1 : Form
    {

        //TO DO: whene press some where in the table paint the squre in diffren color acorrding to cheack status black in pgiaa and gray in miss.
        //TO DO: check if ship die
        //TO DO: fanction that check status (if anybody won)
        //TO DO: culc score and prosent the winner
        //TO DO: ask in the end if wanna play again
        
        static int ship_lg= 0;
        string direc = "right";
        static int[] shipCount1 = { 0, 0, 0, 0, 0 };
        static int[] shipCount2 = { 0, 0, 0, 0, 0 };
        static int setstatus = 0;
        static int turn = 2;
        static Dictionary<int, List<Point?>> player1ships = new Dictionary<int, List<Point?>>();
        static Dictionary<int, List<Point?>> player2ships = new Dictionary<int, List<Point?>>();

        TableLayoutPanelCellPosition hitguess;
        public Form1()
        {
            InitializeComponent();
            
        }

        /**********************COMMON  AREA*************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            TableSet();
            button1.Enabled = false;
            t_opoships.Enabled = false;
            t_opoships2.Enabled = false;
            foreach (Control space in this.t_myships.Controls)
            {
              //space.MouseClick += new MouseEventHandler(clickOnButton);
              space.MouseEnter += new System.EventHandler(button_mouseenter);
              space.MouseLeave += new System.EventHandler(button_mouseleave);
            }

            foreach (Control space in this.t_opoships.Controls)
            {
                space.Click +=new System.EventHandler(this.button_Clicked);
                space.MouseUp += new MouseEventHandler(this.button_MouseUp);
            }
            foreach (Control space in this.t_opoships2.Controls)
            {
                space.Click += new System.EventHandler(this.button_Clicked);
                space.MouseUp += new MouseEventHandler(this.button_MouseUp);
            }

        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (b.Text == "X")
                {
                    b.Text = "";
                }
                else
                 b.Text = "X";
            }
        }

        private void button_mouseleave(object sender, EventArgs e)
        {
          //  Button b = (Button)sender;
          //  b.BackColor = Color.LightGray;
        }

        private void button_mouseenter(object sender, EventArgs e)
        {
           // Button b = (Button) sender;
           // b.BackColor = Color.Aqua;
        }
        
        private void button_mouseclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "x";
        }

        private void TableSet()
        {
            t_myships.Controls.Add(new Label { Text = "" , BackColor = System.Drawing.Color.Aqua }, 0, 0);
            t_myships2.Controls.Add(new Label { Text = "", BackColor = System.Drawing.Color.Aqua }, 0, 0);
            t_opoships.Controls.Add(new Label { Text = "", BackColor = System.Drawing.Color.Blue }, 0, 0);
            t_opoships2.Controls.Add(new Label { Text = "", BackColor = System.Drawing.Color.Blue }, 0, 0);

            for (int i = 1; i <= 10; i++)
            {
                t_myships.Controls.Add(new Label { Text = i.ToString() }, i, 0);
                t_myships2.Controls.Add(new Label { Text = i.ToString() }, i, 0);
                t_opoships.Controls.Add(new Label { Text = i.ToString() }, i, 0);
                t_opoships2.Controls.Add(new Label { Text = i.ToString() },i,0);
            }

            for (int j= 1; j <= 10; j++)
            {
                char c = Convert.ToChar(64 + j);
                t_myships.Controls.Add(new Label { Text = c.ToString() }, 0, j) ;
                t_myships2.Controls.Add(new Label { Text = c.ToString() }, 0, j);
                t_opoships.Controls.Add(new Label { Text = c.ToString() }, 0, j);
                t_opoships2.Controls.Add(new Label { Text = c.ToString() }, 0, j);
                for (int k = 1; k <= 10; k++)
                {
                    t_myships.Controls.Add(new Button  {Text =" " }, j, k);
                    t_myships2.Controls.Add(new Button { Text = " " }, j, k);
                    t_opoships.Controls.Add(new Button { Text = " " }, j, k);
                    t_opoships2.Controls.Add(new Button { Text = " " }, j, k);
                }
            }
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            TableLayoutPanelCellPosition cp;
            if (turn==1)
                cp =  t_opoships.GetPositionFromControl(b);
           else
                cp = t_opoships2.GetPositionFromControl(b);

            
            //MessageBox.Show(cp.Column.ToString() + " " + cp.Row.ToString());
            hitguess = cp;

            b.Text = "O";

            b.ForeColor = Color.Black;
        }

        private bool inBound(Point? cellPos, int ship_lg,string direc)
        {
            int ROW = cellPos.Value.Y;
            int COL = cellPos.Value.X;
            int STARPOINT = 0;
            int ENDPOINT = 0;

            if (direc == "" || direc == "right")
            {
                 STARPOINT = COL;
                 ENDPOINT = COL + ship_lg-1;
            }
            else
            {

                STARPOINT = COL;
                ENDPOINT = ROW+ ship_lg-1;

            }

            if (ROW < 1 || ROW > 10) return false;
            if (COL < 1 || COL > 10) return false;
            if (STARPOINT < 1 || STARPOINT > 10) return false;
            if (ENDPOINT < 1 || ENDPOINT > 10) return false;

            return true;
        }

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void StartGame()
        {
            if (setstatus == 2)
            {
                MessageBox.Show("Game start!!!, may the best player win");
                button1.Enabled = true;
                SwitchTurn();
            }
            else
                MessageBox.Show("Waiting for the other player to set");
        }

        private void SwitchTurn()
        {  
            if (turn==1)
            {
                turn = 2;
                t_opoships.Enabled = false;
                t_opoships2.Enabled = true;
                tabControl1.SelectTab(tabControl1.TabPages[1]); 
            }
            else
            {
                turn = 1;
                t_opoships2.Enabled = false;
                t_opoships.Enabled = true;
                tabControl1.SelectTab(tabControl1.TabPages[0]);
            }
            lbl_curturn.Text = "P" + turn.ToString();
        }


        /*************************************************************/
        /*************************************************************/
        /********************************SPECIFIC*********************/
        /*************************************************************/
        //SHIPS1

        private void T_myships_DragEnter(object sender, DragEventArgs e)
        {
            ShipDragDropEnter(t_myships, sender, e);
        }

        private void T_myships_DragDrop(object sender, DragEventArgs e)
        {
            ShipDragDrop(t_myships,1, sender, e);

        }

        private void Lb_myships_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox Lb_myships = (ListBox)sender;
            ship_lg = Lb_myships.SelectedIndex + 1;
            Lb_myships.DoDragDrop(Lb_myships.Text, DragDropEffects.Copy |
            DragDropEffects.Move);
        }

        private bool CheckShipLoc(TableLayoutPanel t_myships, Point? cellPos, int ship_lg, string direc)
        {
            int r = 0;
            int l = 0;
            int t = 0;
            int b = 0;
            int ROW = cellPos.Value.Y;
            int COL = cellPos.Value.X;
            int side = 0;
            Button bs;
            if (direc == "" || direc == "right")
            {
                r = COL + ship_lg;
                l = COL - 1;
                side = ship_lg + 2;
                if (r >= 1 && r <= 10 && ROW >= 1 && ROW <= 10)//right most
                {
                    bs = (Button)t_myships.GetControlFromPosition(r, ROW);
                    //bs.BackColor = Color.Yellow;
                    if (bs.Text == "O")
                    {
                        return false;
                    }
                }

                if (l >= 1 && l <= 10 && ROW >= 1 && ROW <= 10)//left most
                {
                    bs = (Button)t_myships.GetControlFromPosition(l, ROW);
                    //bs.BackColor = Color.Yellow;
                    if (bs.Text == "O")
                    {
                        return false;
                    }
                }

                for (int i = 0; i < side; i++)//row above
                {
                    if (ROW - 1 >= 1 && ROW - 1 <= 10 && COL - 1 + i >= 1 && COL - 1 + i <= 10)
                    {
                        bs = (Button)t_myships.GetControlFromPosition(COL - 1 + i, ROW - 1);
                        //bs.BackColor = Color.Yellow;
                        if (bs.Text == "O")
                        {
                            return false;
                        }
                    }
                }

                for (int i = 0; i < side; i++)//row below
                {
                    if (ROW + 1 >= 1 && ROW + 1 <= 10 && COL - 1 + i >= 1 && COL - 1 + i <= 10)
                    {
                        bs = (Button)t_myships.GetControlFromPosition(COL - 1 + i, ROW + 1);
                        //bs.BackColor = Color.Yellow;
                        if (bs.Text == "O")
                        {
                            return false;
                        }
                    }
                }
            }
            else//down
            {
                t = ROW - 1;
                b = ROW + ship_lg;
                side = ship_lg + 2;

                if (t >= 1 && t <= 10)
                {
                    bs = (Button)t_myships.GetControlFromPosition(COL, t);
                    //bs.BackColor = Color.Yellow;
                    if (bs.Text == "O")
                    {
                        return false;
                    }

                }


                if (b >= 1 && b <= 10)
                {
                    bs = (Button)t_myships.GetControlFromPosition(COL, b);
                    //bs.BackColor = Color.Yellow;
                    if (bs.Text == "O")
                    {
                        return false;
                    }
                }

                for (int i = 0; i < side; i++)
                {
                    if (COL - 1 >= 1 && COL - 1 <= 10 && ROW - 1 + i >= 1 && ROW - 1 + i <= 10)
                    {
                        bs = (Button)t_myships.GetControlFromPosition(COL - 1, ROW - 1 + i);
                        //bs.BackColor = Color.Yellow;
                        if (bs.Text == "O")
                        {
                            return false;
                        }
                    }
                }

                for (int i = 0; i < side; i++)
                {
                    if (COL + 1 >= 1 && COL + 1 <= 10 && ROW - 1 + i >= 1 && ROW - 1 + i <= 10)
                    {
                        bs = (Button)t_myships.GetControlFromPosition(COL + 1, ROW - 1 + i);
                        //bs.BackColor = Color.Yellow;
                        if (bs.Text == "O")
                        {
                            return false;
                        }
                    }
                }

            }
            return true;
        }

        private void B_right_Click(object sender, EventArgs e)
        {
            direc = "right";
        }
        private void B_down_Click(object sender, EventArgs e)
        {
            direc = "down";
        }
        private void B_reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void B_set_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < shipCount1.Length; i++)
            {
                if (shipCount1[i] != 1)
                {
                    MessageBox.Show("set all ships");
                    return;
                }
            }
            t_myships.Enabled = false; 
            setstatus++;
            tabControl1.SelectTab(tabControl1.TabPages[1]);
            StartGame();
        }

        //SHIPS 2
        private void T_myships2_DragEnter(object sender, DragEventArgs e)
        {
            ShipDragDropEnter(t_myships2, sender, e);
        }

        private void T_myships2_DragDrop(object sender, DragEventArgs e)
        {
            ShipDragDrop(t_myships2,2, sender, e);
        }

        private void Lb_myships2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox Lb_myships2 = (ListBox)sender;
            ship_lg = Lb_myships2.SelectedIndex + 1;
            Lb_myships2.DoDragDrop(Lb_myships2.Text, DragDropEffects.Copy |
            DragDropEffects.Move);
           // shipCount[ship_lg - 1] = 1;
        }

        private void B_right2_Click(object sender, EventArgs e)
        {
            direc = "right";
        }

        private void B_down2_Click(object sender, EventArgs e)
        {
            direc = "down";
        }

        private void B_set2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < shipCount2.Length; i++)
            {
                if (shipCount2[i]!=1)
                {
                    MessageBox.Show("set all ships");
                    return;
                }
            }

            t_myships2.Enabled = false;
            setstatus++;
            tabControl1.SelectTab(tabControl1.TabPages[0]);
            StartGame();
        }

        private void B_reset2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /*************************************************************/
        /*************************************************************/
        /********************  COMMON FUNCTIONS***********************/
        /*************************************************************/
        private void ShipDragDropEnter(TableLayoutPanel t_myships, object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ShipDragDrop(TableLayoutPanel t_myships,int shipcount, object sender, DragEventArgs e)
        {

            var cellPos = GetRowColIndex(t_myships, t_myships.PointToClient(Cursor.Position));

            if (cellPos == null)//out of range
            {
                MessageBox.Show("out of range");
                return;
            }
            if (shipcount==1)
            {
                if (shipCount1[ship_lg - 1] == 1)
                {
                    MessageBox.Show("Ship already used!");
                    return;
                }
            }
            else
            {
                if (shipCount2[ship_lg - 1] == 1)
                {
                    MessageBox.Show("Ship already used!");
                    return;
                }
            }
            if (cellPos != null && inBound(cellPos, ship_lg, direc) && CheckShipLoc(t_myships , cellPos, ship_lg, direc))
            {
                if (direc == "" || direc == "right")
                {

                    for (int r = 0; r < ship_lg; r++)
                    {
                        Button b = (Button)t_myships.GetControlFromPosition(cellPos.Value.X + r, cellPos.Value.Y);
                        b.Text = "O";         
                    }
                }
                else
                {
                    for (int r = 0; r < ship_lg; r++)
                    {
                        Button b = (Button)t_myships.GetControlFromPosition(cellPos.Value.X, cellPos.Value.Y + r);
                        b.Text = "O";

                    }
                }

                //TO DO :SAVE TO LOC ARRAY 
                if (shipcount == 1)
                {
                    shipCount1[ship_lg - 1] = 1;
                }
                else
                {
                    shipCount2[ship_lg - 1] = 1;
                }
                //TO DO : REMOVE ITEM FROM LIST

            }
            else
            {
             MessageBox.Show("relocate ship");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckBoard();
            SwitchTurn();
        }

        private void CheckBoard()
        {
            if (turn==1)
            {
                Button b_turn =  (Button)t_opoships.GetControlFromPosition(hitguess.Column, hitguess.Row);
                Button b = (Button)t_myships2.GetControlFromPosition(hitguess.Column, hitguess.Row);
                if (b.Text == "O")
                {
                    b_turn.BackColor = Color.Red;
                    b.BackColor = Color.Red;
                }
            }
            else
            {
                Button b_turn = (Button)t_opoships2.GetControlFromPosition(hitguess.Column, hitguess.Row);
                Button b = (Button)t_myships.GetControlFromPosition(hitguess.Column, hitguess.Row);
                if (b.Text == "O")
                {
                    b_turn.BackColor = Color.Red;
                    b.BackColor = Color.Red;
                }
            }
        }

        

        /*************************************************************/
        /*************************************************************/
        /*************************************************************/
        /*************************************************************/
    }

}
