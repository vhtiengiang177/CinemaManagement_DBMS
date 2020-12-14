namespace CinemaManagement.GUI
{
    partial class fAddShowtimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddShowtimes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseDay = new System.Windows.Forms.Button();
            this.dtmChooseDay = new System.Windows.Forms.DateTimePicker();
            this.txtCountMovieInDay = new System.Windows.Forms.TextBox();
            this.txtShiftEmpty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChooseShift = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.txtCountShift = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChooseMovie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTypeMovie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtmDay = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResetInfo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddShowtimes = new System.Windows.Forms.Button();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChoosrRoom = new System.Windows.Forms.Button();
            this.txtCountRoom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnChooseDay);
            this.panel1.Controls.Add(this.dtmChooseDay);
            this.panel1.Controls.Add(this.txtCountMovieInDay);
            this.panel1.Controls.Add(this.txtShiftEmpty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 173);
            this.panel1.TabIndex = 0;
            // 
            // btnChooseDay
            // 
            this.btnChooseDay.Location = new System.Drawing.Point(200, 27);
            this.btnChooseDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseDay.Name = "btnChooseDay";
            this.btnChooseDay.Size = new System.Drawing.Size(56, 23);
            this.btnChooseDay.TabIndex = 38;
            this.btnChooseDay.Text = "Chọn";
            this.btnChooseDay.UseVisualStyleBackColor = true;
            this.btnChooseDay.Click += new System.EventHandler(this.btnChooseDay_Click);
            // 
            // dtmChooseDay
            // 
            this.dtmChooseDay.CustomFormat = "mm/dd/yyyy";
            this.dtmChooseDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmChooseDay.Location = new System.Drawing.Point(30, 31);
            this.dtmChooseDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmChooseDay.Name = "dtmChooseDay";
            this.dtmChooseDay.Size = new System.Drawing.Size(151, 20);
            this.dtmChooseDay.TabIndex = 13;
            this.dtmChooseDay.ValueChanged += new System.EventHandler(this.dtmChooseDay_ValueChanged);
            // 
            // txtCountMovieInDay
            // 
            this.txtCountMovieInDay.Location = new System.Drawing.Point(28, 102);
            this.txtCountMovieInDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountMovieInDay.Name = "txtCountMovieInDay";
            this.txtCountMovieInDay.ReadOnly = true;
            this.txtCountMovieInDay.Size = new System.Drawing.Size(76, 20);
            this.txtCountMovieInDay.TabIndex = 8;
            // 
            // txtShiftEmpty
            // 
            this.txtShiftEmpty.Location = new System.Drawing.Point(27, 141);
            this.txtShiftEmpty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShiftEmpty.Name = "txtShiftEmpty";
            this.txtShiftEmpty.ReadOnly = true;
            this.txtShiftEmpty.Size = new System.Drawing.Size(76, 20);
            this.txtShiftEmpty.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng phim đã xếp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "1.Chọn ngày xếp lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng ca còn trống:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnChooseShift);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cboShift);
            this.panel2.Controls.Add(this.txtCountShift);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(290, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 174);
            this.panel2.TabIndex = 1;
            // 
            // btnChooseShift
            // 
            this.btnChooseShift.Location = new System.Drawing.Point(127, 28);
            this.btnChooseShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseShift.Name = "btnChooseShift";
            this.btnChooseShift.Size = new System.Drawing.Size(56, 23);
            this.btnChooseShift.TabIndex = 37;
            this.btnChooseShift.Text = "Chọn";
            this.btnChooseShift.UseVisualStyleBackColor = true;
            this.btnChooseShift.Click += new System.EventHandler(this.btnChooseShift_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "2.Chọn ca chiếu";
            // 
            // cboShift
            // 
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Items.AddRange(new object[] {
            "9am-11am",
            "11am-1pm",
            "1pm-3pm",
            "3pm-5pm"});
            this.cboShift.Location = new System.Drawing.Point(18, 30);
            this.cboShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(92, 21);
            this.cboShift.TabIndex = 20;
            this.cboShift.SelectedIndexChanged += new System.EventHandler(this.cboShift_SelectedIndexChanged);
            // 
            // txtCountShift
            // 
            this.txtCountShift.Location = new System.Drawing.Point(18, 103);
            this.txtCountShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountShift.Name = "txtCountShift";
            this.txtCountShift.ReadOnly = true;
            this.txtCountShift.Size = new System.Drawing.Size(76, 20);
            this.txtCountShift.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số lượt chọn ca còn:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btnChooseMovie);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboTypeMovie);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cboMovie);
            this.panel3.Location = new System.Drawing.Point(695, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 174);
            this.panel3.TabIndex = 2;
            // 
            // btnChooseMovie
            // 
            this.btnChooseMovie.Location = new System.Drawing.Point(151, 25);
            this.btnChooseMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseMovie.Name = "btnChooseMovie";
            this.btnChooseMovie.Size = new System.Drawing.Size(56, 23);
            this.btnChooseMovie.TabIndex = 38;
            this.btnChooseMovie.Text = "Chọn";
            this.btnChooseMovie.UseVisualStyleBackColor = true;
            this.btnChooseMovie.Click += new System.EventHandler(this.btnChooseMovie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn thể loại phim:";
            // 
            // cboTypeMovie
            // 
            this.cboTypeMovie.FormattingEnabled = true;
            this.cboTypeMovie.Location = new System.Drawing.Point(11, 102);
            this.cboTypeMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTypeMovie.Name = "cboTypeMovie";
            this.cboTypeMovie.Size = new System.Drawing.Size(132, 21);
            this.cboTypeMovie.TabIndex = 17;
            this.cboTypeMovie.SelectedIndexChanged += new System.EventHandler(this.cboTypeMovie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "4.Chọn phim";
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(14, 25);
            this.cboMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(126, 21);
            this.cboMovie.TabIndex = 18;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // iconClose
            // 
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(985, 10);
            this.iconClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(36, 34);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 4;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.dtmDay);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnResetInfo);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtRoom);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnAddShowtimes);
            this.panel4.Controls.Add(this.txtMovie);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtShift);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(416, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 157);
            this.panel4.TabIndex = 3;
            // 
            // dtmDay
            // 
            this.dtmDay.CustomFormat = "mm/dd/yyyy";
            this.dtmDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDay.Location = new System.Drawing.Point(21, 54);
            this.dtmDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmDay.Name = "dtmDay";
            this.dtmDay.Size = new System.Drawing.Size(84, 20);
            this.dtmDay.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "Sửa lịch chiếu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnResetInfo
            // 
            this.btnResetInfo.Location = new System.Drawing.Point(153, 98);
            this.btnResetInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetInfo.Name = "btnResetInfo";
            this.btnResetInfo.Size = new System.Drawing.Size(111, 28);
            this.btnResetInfo.TabIndex = 28;
            this.btnResetInfo.Text = "Hủy lịch chiếu";
            this.btnResetInfo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Phòng chiếu";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(248, 54);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(90, 20);
            this.txtRoom.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phim ";
            // 
            // btnAddShowtimes
            // 
            this.btnAddShowtimes.Location = new System.Drawing.Point(21, 98);
            this.btnAddShowtimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddShowtimes.Name = "btnAddShowtimes";
            this.btnAddShowtimes.Size = new System.Drawing.Size(111, 28);
            this.btnAddShowtimes.TabIndex = 4;
            this.btnAddShowtimes.Text = "Thêm lịch chiếu";
            this.btnAddShowtimes.UseVisualStyleBackColor = true;
            this.btnAddShowtimes.Click += new System.EventHandler(this.btnAddShowtimes_Click);
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(352, 54);
            this.txtMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.ReadOnly = true;
            this.txtMovie.Size = new System.Drawing.Size(91, 20);
            this.txtMovie.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ca chiếu";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(126, 54);
            this.txtShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(93, 20);
            this.txtShift.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ngày chiếu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btnChoosrRoom);
            this.panel5.Controls.Add(this.txtCountRoom);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.cboRoom);
            this.panel5.Location = new System.Drawing.Point(484, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 174);
            this.panel5.TabIndex = 4;
            // 
            // btnChoosrRoom
            // 
            this.btnChoosrRoom.Location = new System.Drawing.Point(134, 27);
            this.btnChoosrRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoosrRoom.Name = "btnChoosrRoom";
            this.btnChoosrRoom.Size = new System.Drawing.Size(56, 23);
            this.btnChoosrRoom.TabIndex = 36;
            this.btnChoosrRoom.Text = "Chọn";
            this.btnChoosrRoom.UseVisualStyleBackColor = true;
            this.btnChoosrRoom.Click += new System.EventHandler(this.btnChoosrRoom_Click);
            // 
            // txtCountRoom
            // 
            this.txtCountRoom.Location = new System.Drawing.Point(17, 101);
            this.txtCountRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountRoom.Name = "txtCountRoom";
            this.txtCountRoom.ReadOnly = true;
            this.txtCountRoom.Size = new System.Drawing.Size(90, 20);
            this.txtCountRoom.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 84);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Số lượt chọn phòng còn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "3.Chọn phòng chiếu";
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Items.AddRange(new object[] {
            "9am-11am",
            "11am-1pm",
            "1pm-3pm",
            "3pm-5pm"});
            this.cboRoom.Location = new System.Drawing.Point(16, 30);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(92, 21);
            this.cboRoom.TabIndex = 34;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Các bước set lịch chiếu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(17, 234);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 280);
            this.panel6.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 186);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(230, 18);
            this.label23.TabIndex = 13;
            this.label23.Text = "6.Chọn Thêm hoặc Hủy lịch chiếu";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 159);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(309, 18);
            this.label22.TabIndex = 12;
            this.label22.Text = "5.Xem lại thông tin một lần nữa ở bảng hiển thị";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 242);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(298, 18);
            this.label21.TabIndex = 11;
            this.label21.Text = " cần kiểm tra các thông tin để tránh trùng lặp";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 219);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(223, 18);
            this.label20.TabIndex = 10;
            this.label20.Text = "Lưu ý: trước khi chọn ở các bước";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 132);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 18);
            this.label19.TabIndex = 9;
            this.label19.Text = "4.Chọn phim chiếu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "3.Chọn phòng chiếu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 76);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "2.Chọn ca chiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "1.Chọn ngày xếp lịch";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(413, 248);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(191, 20);
            this.label24.TabIndex = 7;
            this.label24.Text = "Bảng hiển thị thông tin";
            // 
            // fAddShowtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 556);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fAddShowtimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddShowtimes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtmChooseDay;
        private System.Windows.Forms.TextBox txtCountMovieInDay;
        private System.Windows.Forms.TextBox txtShiftEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.TextBox txtCountShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTypeMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddShowtimes;
        private System.Windows.Forms.Button btnResetInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChooseDay;
        private System.Windows.Forms.Button btnChooseShift;
        private System.Windows.Forms.Button btnChooseMovie;
        private System.Windows.Forms.Button btnChoosrRoom;
        private System.Windows.Forms.TextBox txtCountRoom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtmDay;
        //        private cinemaDBMSDataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
    }
}