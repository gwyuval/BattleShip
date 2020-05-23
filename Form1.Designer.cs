namespace zilelot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_curturn = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.b_right = new System.Windows.Forms.Button();
            this.b_down = new System.Windows.Forms.Button();
            this.lb_myships = new System.Windows.Forms.ListBox();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_set = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_opoships = new System.Windows.Forms.TableLayoutPanel();
            this.t_myships = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_right2 = new System.Windows.Forms.Button();
            this.b_down2 = new System.Windows.Forms.Button();
            this.lb_myships2 = new System.Windows.Forms.ListBox();
            this.b_reset2 = new System.Windows.Forms.Button();
            this.b_set2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.t_opoships2 = new System.Windows.Forms.TableLayoutPanel();
            this.t_myships2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(564, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "waiting for";
            // 
            // lbl_curturn
            // 
            this.lbl_curturn.AutoSize = true;
            this.lbl_curturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_curturn.Location = new System.Drawing.Point(574, 87);
            this.lbl_curturn.Name = "lbl_curturn";
            this.lbl_curturn.Size = new System.Drawing.Size(44, 29);
            this.lbl_curturn.TabIndex = 15;
            this.lbl_curturn.Text = "P1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 730);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.b_right);
            this.tabPage1.Controls.Add(this.b_down);
            this.tabPage1.Controls.Add(this.lb_myships);
            this.tabPage1.Controls.Add(this.b_reset);
            this.tabPage1.Controls.Add(this.b_set);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.t_opoships);
            this.tabPage1.Controls.Add(this.t_myships);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player 1";
            // 
            // b_right
            // 
            this.b_right.Image = ((System.Drawing.Image)(resources.GetObject("b_right.Image")));
            this.b_right.Location = new System.Drawing.Point(444, 80);
            this.b_right.Name = "b_right";
            this.b_right.Size = new System.Drawing.Size(60, 60);
            this.b_right.TabIndex = 30;
            this.b_right.UseVisualStyleBackColor = true;
            this.b_right.Click += new System.EventHandler(this.B_right_Click);
            // 
            // b_down
            // 
            this.b_down.Image = ((System.Drawing.Image)(resources.GetObject("b_down.Image")));
            this.b_down.Location = new System.Drawing.Point(444, 146);
            this.b_down.Name = "b_down";
            this.b_down.Size = new System.Drawing.Size(61, 57);
            this.b_down.TabIndex = 29;
            this.b_down.UseVisualStyleBackColor = true;
            this.b_down.Click += new System.EventHandler(this.B_down_Click);
            // 
            // lb_myships
            // 
            this.lb_myships.FormattingEnabled = true;
            this.lb_myships.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lb_myships.Location = new System.Drawing.Point(444, 8);
            this.lb_myships.Name = "lb_myships";
            this.lb_myships.Size = new System.Drawing.Size(72, 69);
            this.lb_myships.TabIndex = 28;
            this.lb_myships.SelectedIndexChanged += new System.EventHandler(this.Lb_myships_SelectedIndexChanged);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(444, 271);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 23;
            this.b_reset.Text = "RESET";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.B_reset_Click);
            // 
            // b_set
            // 
            this.b_set.Location = new System.Drawing.Point(444, 226);
            this.b_set.Name = "b_set";
            this.b_set.Size = new System.Drawing.Size(75, 23);
            this.b_set.TabIndex = 22;
            this.b_set.Text = "SET";
            this.b_set.UseVisualStyleBackColor = true;
            this.b_set.Click += new System.EventHandler(this.B_set_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oponent ships";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "My ships";
            // 
            // t_opoships
            // 
            this.t_opoships.BackColor = System.Drawing.Color.White;
            this.t_opoships.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.t_opoships.ColumnCount = 11;
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.t_opoships.Location = new System.Drawing.Point(104, 300);
            this.t_opoships.Name = "t_opoships";
            this.t_opoships.RowCount = 11;
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships.Size = new System.Drawing.Size(290, 287);
            this.t_opoships.TabIndex = 15;
            // 
            // t_myships
            // 
            this.t_myships.AllowDrop = true;
            this.t_myships.BackColor = System.Drawing.SystemColors.Control;
            this.t_myships.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_myships.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.t_myships.ColumnCount = 11;
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.t_myships.Location = new System.Drawing.Point(104, 8);
            this.t_myships.Name = "t_myships";
            this.t_myships.RowCount = 11;
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships.Size = new System.Drawing.Size(293, 286);
            this.t_myships.TabIndex = 14;
            this.t_myships.DragDrop += new System.Windows.Forms.DragEventHandler(this.T_myships_DragDrop);
            this.t_myships.DragEnter += new System.Windows.Forms.DragEventHandler(this.T_myships_DragEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.b_right2);
            this.tabPage2.Controls.Add(this.b_down2);
            this.tabPage2.Controls.Add(this.lb_myships2);
            this.tabPage2.Controls.Add(this.b_reset2);
            this.tabPage2.Controls.Add(this.b_set2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.t_opoships2);
            this.tabPage2.Controls.Add(this.t_myships2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player 2";
            // 
            // b_right2
            // 
            this.b_right2.Image = ((System.Drawing.Image)(resources.GetObject("b_right2.Image")));
            this.b_right2.Location = new System.Drawing.Point(459, 98);
            this.b_right2.Name = "b_right2";
            this.b_right2.Size = new System.Drawing.Size(60, 60);
            this.b_right2.TabIndex = 35;
            this.b_right2.UseVisualStyleBackColor = true;
            this.b_right2.Click += new System.EventHandler(this.B_right2_Click);
            // 
            // b_down2
            // 
            this.b_down2.Image = ((System.Drawing.Image)(resources.GetObject("b_down2.Image")));
            this.b_down2.Location = new System.Drawing.Point(459, 164);
            this.b_down2.Name = "b_down2";
            this.b_down2.Size = new System.Drawing.Size(60, 60);
            this.b_down2.TabIndex = 34;
            this.b_down2.UseVisualStyleBackColor = true;
            this.b_down2.Click += new System.EventHandler(this.B_down2_Click);
            // 
            // lb_myships2
            // 
            this.lb_myships2.FormattingEnabled = true;
            this.lb_myships2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lb_myships2.Location = new System.Drawing.Point(459, 11);
            this.lb_myships2.Name = "lb_myships2";
            this.lb_myships2.Size = new System.Drawing.Size(72, 69);
            this.lb_myships2.TabIndex = 33;
            this.lb_myships2.SelectedIndexChanged += new System.EventHandler(this.Lb_myships2_SelectedIndexChanged);
            // 
            // b_reset2
            // 
            this.b_reset2.Location = new System.Drawing.Point(456, 273);
            this.b_reset2.Name = "b_reset2";
            this.b_reset2.Size = new System.Drawing.Size(75, 23);
            this.b_reset2.TabIndex = 23;
            this.b_reset2.Text = "RESET";
            this.b_reset2.UseVisualStyleBackColor = true;
            this.b_reset2.Click += new System.EventHandler(this.B_reset2_Click);
            // 
            // b_set2
            // 
            this.b_set2.Location = new System.Drawing.Point(457, 243);
            this.b_set2.Name = "b_set2";
            this.b_set2.Size = new System.Drawing.Size(75, 23);
            this.b_set2.TabIndex = 22;
            this.b_set2.Text = "SET";
            this.b_set2.UseVisualStyleBackColor = true;
            this.b_set2.Click += new System.EventHandler(this.B_set2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Oponent ships";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "My ships";
            // 
            // t_opoships2
            // 
            this.t_opoships2.BackColor = System.Drawing.Color.Azure;
            this.t_opoships2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.t_opoships2.ColumnCount = 11;
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.t_opoships2.Location = new System.Drawing.Point(87, 313);
            this.t_opoships2.Name = "t_opoships2";
            this.t_opoships2.RowCount = 11;
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_opoships2.Size = new System.Drawing.Size(290, 287);
            this.t_opoships2.TabIndex = 15;
            // 
            // t_myships2
            // 
            this.t_myships2.AllowDrop = true;
            this.t_myships2.BackColor = System.Drawing.SystemColors.Control;
            this.t_myships2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_myships2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.t_myships2.ColumnCount = 11;
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.t_myships2.Location = new System.Drawing.Point(82, 11);
            this.t_myships2.Name = "t_myships2";
            this.t_myships2.RowCount = 11;
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.t_myships2.Size = new System.Drawing.Size(293, 285);
            this.t_myships2.TabIndex = 14;
            this.t_myships2.DragDrop += new System.Windows.Forms.DragEventHandler(this.T_myships2_DragDrop);
            this.t_myships2.DragEnter += new System.Windows.Forms.DragEventHandler(this.T_myships2_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 73);
            this.button1.TabIndex = 17;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_curturn);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_curturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button b_set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel t_opoships;
        private System.Windows.Forms.TableLayoutPanel t_myships;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button b_reset2;
        private System.Windows.Forms.Button b_set2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel t_opoships2;
        private System.Windows.Forms.TableLayoutPanel t_myships2;
        private System.Windows.Forms.Button b_right;
        private System.Windows.Forms.Button b_down;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_right2;
        private System.Windows.Forms.Button b_down2;
        private System.Windows.Forms.ListBox lb_myships2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_myships;
    }
}

