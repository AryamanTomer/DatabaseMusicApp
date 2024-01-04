

namespace DatabaseMusicApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            Edit = new CheckBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Add = new Button();
            Txt_Description = new TextBox();
            Txt_Artist = new TextBox();
            Txt_Year = new TextBox();
            Txt_ImageURL = new TextBox();
            Txt_AlbumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            groupBox3 = new GroupBox();
            Edit2 = new CheckBox();
            Add2 = new Button();
            Txt_Number = new TextBox();
            Txt_VideoURL = new TextBox();
            Txt_Lyrics = new TextBox();
            Txt_TrackTitle = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            EditTrack = new Button();
            button5 = new Button();
            Txt_AlbumID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(554, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(554, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(770, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(1020, 14);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(723, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 31);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(305, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Edit);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(Txt_Description);
            groupBox1.Controls.Add(Txt_Artist);
            groupBox1.Controls.Add(Txt_Year);
            groupBox1.Controls.Add(Txt_ImageURL);
            groupBox1.Controls.Add(Txt_AlbumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 303);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Edit
            // 
            Edit.AutoSize = true;
            Edit.Location = new Point(164, 217);
            Edit.Name = "Edit";
            Edit.Size = new Size(68, 29);
            Edit.TabIndex = 10;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(6, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 303);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Album";
            // 
            // button4
            // 
            button4.Location = new Point(0, 217);
            button4.Name = "button4";
            button4.Size = new Size(158, 34);
            button4.TabIndex = 9;
            button4.Text = "Add / Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 24);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 183);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 4;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 144);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 3;
            label8.Text = "ImageURL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 105);
            label9.Name = "label9";
            label9.Size = new Size(44, 25);
            label9.TabIndex = 2;
            label9.Text = "Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 66);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 1;
            label10.Text = "Artist";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 27);
            label11.Name = "label11";
            label11.Size = new Size(102, 25);
            label11.TabIndex = 0;
            label11.Text = "Album Title";
            // 
            // Add
            // 
            Add.Location = new Point(0, 217);
            Add.Name = "Add";
            Add.Size = new Size(158, 34);
            Add.TabIndex = 9;
            Add.Text = "Add / Update";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Txt_Description
            // 
            Txt_Description.Location = new Point(114, 180);
            Txt_Description.Name = "Txt_Description";
            Txt_Description.Size = new Size(150, 31);
            Txt_Description.TabIndex = 8;
            // 
            // Txt_Artist
            // 
            Txt_Artist.Location = new Point(114, 63);
            Txt_Artist.Name = "Txt_Artist";
            Txt_Artist.Size = new Size(150, 31);
            Txt_Artist.TabIndex = 7;
            // 
            // Txt_Year
            // 
            Txt_Year.Location = new Point(114, 102);
            Txt_Year.Name = "Txt_Year";
            Txt_Year.Size = new Size(150, 31);
            Txt_Year.TabIndex = 6;
            // 
            // Txt_ImageURL
            // 
            Txt_ImageURL.Location = new Point(114, 141);
            Txt_ImageURL.Name = "Txt_ImageURL";
            Txt_ImageURL.Size = new Size(150, 31);
            Txt_ImageURL.TabIndex = 6;
            // 
            // Txt_AlbumName
            // 
            Txt_AlbumName.Location = new Point(114, 24);
            Txt_AlbumName.Name = "Txt_AlbumName";
            Txt_AlbumName.Size = new Size(150, 31);
            Txt_AlbumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 183);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 144);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Album Title";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 318);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            label6.Click += label6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(554, 361);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(539, 225);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(554, 592);
            button3.Name = "button3";
            button3.Size = new Size(201, 34);
            button3.TabIndex = 8;
            button3.Text = "Delete Selected Track";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Txt_AlbumID);
            groupBox3.Controls.Add(Edit2);
            groupBox3.Controls.Add(Add2);
            groupBox3.Controls.Add(Txt_Number);
            groupBox3.Controls.Add(Txt_VideoURL);
            groupBox3.Controls.Add(Txt_Lyrics);
            groupBox3.Controls.Add(Txt_TrackTitle);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label21);
            groupBox3.Location = new Point(250, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 303);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Track";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Edit2
            // 
            Edit2.AutoSize = true;
            Edit2.Location = new Point(164, 220);
            Edit2.Name = "Edit2";
            Edit2.Size = new Size(68, 29);
            Edit2.TabIndex = 11;
            Edit2.Text = "Edit";
            Edit2.UseVisualStyleBackColor = true;
            // 
            // Add2
            // 
            Add2.Location = new Point(0, 217);
            Add2.Name = "Add2";
            Add2.Size = new Size(158, 34);
            Add2.TabIndex = 9;
            Add2.Text = "Add / Update";
            Add2.UseVisualStyleBackColor = true;
            Add2.Click += Add2_Click;
            // 
            // Txt_Number
            // 
            Txt_Number.Location = new Point(114, 63);
            Txt_Number.Name = "Txt_Number";
            Txt_Number.Size = new Size(150, 31);
            Txt_Number.TabIndex = 7;
            // 
            // Txt_VideoURL
            // 
            Txt_VideoURL.Location = new Point(114, 102);
            Txt_VideoURL.Name = "Txt_VideoURL";
            Txt_VideoURL.Size = new Size(150, 31);
            Txt_VideoURL.TabIndex = 6;
            // 
            // Txt_Lyrics
            // 
            Txt_Lyrics.Location = new Point(114, 141);
            Txt_Lyrics.Name = "Txt_Lyrics";
            Txt_Lyrics.Size = new Size(150, 31);
            Txt_Lyrics.TabIndex = 6;
            // 
            // Txt_TrackTitle
            // 
            Txt_TrackTitle.Location = new Point(114, 24);
            Txt_TrackTitle.Name = "Txt_TrackTitle";
            Txt_TrackTitle.Size = new Size(150, 31);
            Txt_TrackTitle.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 183);
            label17.Name = "label17";
            label17.Size = new Size(88, 25);
            label17.TabIndex = 4;
            label17.Text = "Album ID";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 144);
            label18.Name = "label18";
            label18.Size = new Size(54, 25);
            label18.TabIndex = 3;
            label18.Text = "Lyrics";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 105);
            label19.Name = "label19";
            label19.Size = new Size(89, 25);
            label19.TabIndex = 2;
            label19.Text = "VideoURL";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 66);
            label20.Name = "label20";
            label20.Size = new Size(77, 25);
            label20.TabIndex = 1;
            label20.Text = "Number";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 27);
            label21.Name = "label21";
            label21.Size = new Size(88, 25);
            label21.TabIndex = 0;
            label21.Text = "Track Title";
            label21.TextAlign = ContentAlignment.TopCenter;
            label21.Click += label21_Click;
            // 
            // EditTrack
            // 
            EditTrack.Location = new Point(893, 592);
            EditTrack.Name = "EditTrack";
            EditTrack.Size = new Size(200, 34);
            EditTrack.TabIndex = 10;
            EditTrack.Text = "Edit Selected Track";
            EditTrack.UseVisualStyleBackColor = true;
            EditTrack.Click += EditTrack_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1152, 13);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 11;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Txt_AlbumID
            // 
            Txt_AlbumID.Location = new Point(114, 180);
            Txt_AlbumID.Name = "Txt_AlbumID";
            Txt_AlbumID.Size = new Size(150, 31);
            Txt_AlbumID.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 624);
            Controls.Add(button5);
            Controls.Add(EditTrack);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            Load += Form1_Load;
        }




        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox Txt_Artist;
        private TextBox Txt_Year;
        private TextBox Txt_ImageURL;
        private TextBox Txt_AlbumName;
        private TextBox Txt_Description;
        private Button Add;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button3;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox3;
        private Button Add2;
        private TextBox Txt_Number;
        private TextBox Txt_VideoURL;
        private TextBox Txt_Lyrics;
        private TextBox Txt_TrackTitle;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button EditTrack;
        private Button button5;
        private CheckBox Edit;
        private CheckBox Edit2;
        private TextBox Txt_AlbumID;

        public EventHandler Form1_Load { get; private set; }
    }
}
