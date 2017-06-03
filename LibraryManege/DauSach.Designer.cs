namespace LibraryManege
{
    partial class DauSac
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
            this.dgvdausach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.dtpngayxuatban = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtphienban = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttendausach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtsotrang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttheloai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txttacgia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txttimkemdausach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.validatorBase1 = new DevAge.ComponentModel.Validator.ValidatorBase();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdausach)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpngayxuatban)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdausach
            // 
            this.dgvdausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdausach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdausach.Location = new System.Drawing.Point(0, 0);
            this.dgvdausach.Name = "dgvdausach";
            this.dgvdausach.Size = new System.Drawing.Size(599, 307);
            this.dgvdausach.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 367);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Location = new System.Drawing.Point(255, 329);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Location = new System.Drawing.Point(174, 329);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsua.Location = new System.Drawing.Point(93, 329);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.Location = new System.Drawing.Point(12, 329);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm ";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.ControlDark;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbNXB);
            this.groupPanel1.Controls.Add(this.dtpngayxuatban);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtid);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtphienban);
            this.groupPanel1.Controls.Add(this.txttendausach);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtsotrang);
            this.groupPanel1.Controls.Add(this.txttheloai);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txttacgia);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(346, 290);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 16;
            this.groupPanel1.Text = "Thông tin đầu sách";
            // 
            // cmbNXB
            // 
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(144, 136);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(180, 21);
            this.cmbNXB.TabIndex = 25;
            // 
            // dtpngayxuatban
            // 
            // 
            // 
            // 
            this.dtpngayxuatban.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpngayxuatban.ButtonDropDown.Visible = true;
            this.dtpngayxuatban.Location = new System.Drawing.Point(144, 227);
            // 
            // 
            // 
            this.dtpngayxuatban.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpngayxuatban.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpngayxuatban.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpngayxuatban.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpngayxuatban.MonthCalendar.DisplayMonth = new System.DateTime(2017, 4, 1, 0, 0, 0, 0);
            this.dtpngayxuatban.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpngayxuatban.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpngayxuatban.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpngayxuatban.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpngayxuatban.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpngayxuatban.MonthCalendar.TodayButtonVisible = true;
            this.dtpngayxuatban.Name = "dtpngayxuatban";
            this.dtpngayxuatban.Size = new System.Drawing.Size(119, 20);
            this.dtpngayxuatban.TabIndex = 24;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(18, 224);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(121, 23);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "Ngày xuất bản :";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(17, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ID Đầu sách :";
            // 
            // txtid
            // 
            // 
            // 
            // 
            this.txtid.Border.Class = "TextBoxBorder";
            this.txtid.Location = new System.Drawing.Point(144, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(180, 20);
            this.txtid.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(17, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên đầu sách :";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // txtphienban
            // 
            // 
            // 
            // 
            this.txtphienban.Border.Class = "TextBoxBorder";
            this.txtphienban.Location = new System.Drawing.Point(144, 195);
            this.txtphienban.Name = "txtphienban";
            this.txtphienban.Size = new System.Drawing.Size(180, 20);
            this.txtphienban.TabIndex = 13;
            // 
            // txttendausach
            // 
            // 
            // 
            // 
            this.txttendausach.Border.Class = "TextBoxBorder";
            this.txttendausach.Location = new System.Drawing.Point(144, 48);
            this.txttendausach.Name = "txttendausach";
            this.txttendausach.Size = new System.Drawing.Size(180, 20);
            this.txttendausach.TabIndex = 3;
            this.txttendausach.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            this.txttendausach.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxX2_Validating);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(17, 195);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(121, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Phiên bản :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(17, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(121, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Thể loại :";
            // 
            // txtsotrang
            // 
            // 
            // 
            // 
            this.txtsotrang.Border.Class = "TextBoxBorder";
            this.txtsotrang.Location = new System.Drawing.Point(144, 166);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(180, 20);
            this.txtsotrang.TabIndex = 11;
            // 
            // txttheloai
            // 
            // 
            // 
            // 
            this.txttheloai.Border.Class = "TextBoxBorder";
            this.txttheloai.Location = new System.Drawing.Point(144, 77);
            this.txttheloai.Name = "txttheloai";
            this.txttheloai.Size = new System.Drawing.Size(180, 20);
            this.txttheloai.TabIndex = 5;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(17, 166);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(121, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Số trang :";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(17, 106);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(121, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Tác giả :";
            // 
            // txttacgia
            // 
            // 
            // 
            // 
            this.txttacgia.Border.Class = "TextBoxBorder";
            this.txttacgia.Location = new System.Drawing.Point(144, 106);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(180, 20);
            this.txttacgia.TabIndex = 7;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(18, 134);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(121, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Nhà xuất bản :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(346, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 367);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvdausach);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 307);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 60);
            this.panel3.TabIndex = 1;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txttimkemdausach);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(599, 60);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Tìm kiếm";
            // 
            // txttimkemdausach
            // 
            // 
            // 
            // 
            this.txttimkemdausach.Border.Class = "TextBoxBorder";
            this.txttimkemdausach.Location = new System.Drawing.Point(144, 3);
            this.txttimkemdausach.Name = "txttimkemdausach";
            this.txttimkemdausach.Size = new System.Drawing.Size(171, 20);
            this.txttimkemdausach.TabIndex = 17;
            this.txttimkemdausach.TextChanged += new System.EventHandler(this.txttimkemdausach_TextChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(0, 3);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(138, 23);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "Tìm kiếm đầu sách :";
            this.labelX9.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(121, 296);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 24;
            this.buttonX1.Text = "Huy";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // DauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DauSac";
            this.Text = "DauSach";
            this.Load += new System.EventHandler(this.DauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdausach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpngayxuatban)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdausach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txttendausach;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtid;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtphienban;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsotrang;
        private DevComponents.DotNetBar.Controls.TextBoxX txttheloai;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttacgia;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimkemdausach;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevAge.ComponentModel.Validator.ValidatorBase validatorBase1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpngayxuatban;
        private System.Windows.Forms.ComboBox cmbNXB;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}