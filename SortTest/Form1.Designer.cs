
namespace SortTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grb_nhap = new System.Windows.Forms.GroupBox();
            this.btn_Mofile = new System.Windows.Forms.Button();
            this.txt_sophantu = new System.Windows.Forms.TextBox();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.txt_chiso = new System.Windows.Forms.TextBox();
            this.btn_Ngaunhien = new System.Windows.Forms.Button();
            this.btn_Taomang = new System.Windows.Forms.Button();
            this.btn_Docfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_cacthuattoan = new System.Windows.Forms.GroupBox();
            this.rad_insertionsort = new System.Windows.Forms.RadioButton();
            this.rad_Selectionsort = new System.Windows.Forms.RadioButton();
            this.grb_xemCode = new System.Windows.Forms.GroupBox();
            this.btn_Thunho = new System.Windows.Forms.Button();
            this.lst_Code = new System.Windows.Forms.ListBox();
            this.btn_Phongto = new System.Windows.Forms.Button();
            this.lbl_A = new System.Windows.Forms.Label();
            this.grb_dieukhien = new System.Windows.Forms.GroupBox();
            this.lbl_status_01 = new System.Windows.Forms.Label();
            this.Tmr_thay_doi_toc_do = new System.Windows.Forms.Timer(this.components);
            this.Mui_ten_xanh_len_1 = new System.Windows.Forms.Label();
            this.Mui_ten_xanh_xuong_1 = new System.Windows.Forms.Label();
            this.Trb_Toc_do = new System.Windows.Forms.TrackBar();
            this.lbl_Toc_do = new System.Windows.Forms.Label();
            this.rad_Tang = new System.Windows.Forms.RadioButton();
            this.rad_Giam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Sapxep = new System.Windows.Forms.Button();
            this.btn_Ketiep = new System.Windows.Forms.Button();
            this.btn_Dung = new System.Windows.Forms.Button();
            this.btn_Chayhet = new System.Windows.Forms.Button();
            this.grb_nhap.SuspendLayout();
            this.grb_cacthuattoan.SuspendLayout();
            this.grb_xemCode.SuspendLayout();
            this.grb_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_nhap
            // 
            this.grb_nhap.BackColor = System.Drawing.Color.Transparent;
            this.grb_nhap.Controls.Add(this.btn_Mofile);
            this.grb_nhap.Controls.Add(this.txt_sophantu);
            this.grb_nhap.Controls.Add(this.txt_giatri);
            this.grb_nhap.Controls.Add(this.label5);
            this.grb_nhap.Controls.Add(this.label4);
            this.grb_nhap.Controls.Add(this.btn_Nhap);
            this.grb_nhap.Controls.Add(this.txt_chiso);
            this.grb_nhap.Controls.Add(this.btn_Ngaunhien);
            this.grb_nhap.Controls.Add(this.btn_Taomang);
            this.grb_nhap.Controls.Add(this.btn_Docfile);
            this.grb_nhap.Controls.Add(this.label3);
            this.grb_nhap.Controls.Add(this.label2);
            this.grb_nhap.Controls.Add(this.label1);
            this.grb_nhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.grb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_nhap.Location = new System.Drawing.Point(12, 415);
            this.grb_nhap.Name = "grb_nhap";
            this.grb_nhap.Size = new System.Drawing.Size(253, 282);
            this.grb_nhap.TabIndex = 6;
            this.grb_nhap.TabStop = false;
            this.grb_nhap.Text = "Nhập dữ liệu";
            // 
            // btn_Mofile
            // 
            this.btn_Mofile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Mofile.Location = new System.Drawing.Point(129, 61);
            this.btn_Mofile.Name = "btn_Mofile";
            this.btn_Mofile.Size = new System.Drawing.Size(96, 29);
            this.btn_Mofile.TabIndex = 32;
            this.btn_Mofile.Text = "Mở file";
            this.btn_Mofile.UseVisualStyleBackColor = true;
            this.btn_Mofile.Click += new System.EventHandler(this.btn_Mofile_Click);
            // 
            // txt_sophantu
            // 
            this.txt_sophantu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sophantu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_sophantu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sophantu.Location = new System.Drawing.Point(129, 101);
            this.txt_sophantu.Name = "txt_sophantu";
            this.txt_sophantu.Size = new System.Drawing.Size(96, 26);
            this.txt_sophantu.TabIndex = 11;
            this.txt_sophantu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sophantu.TextChanged += new System.EventHandler(this.txt_sophantu_TextChanged);
            // 
            // txt_giatri
            // 
            this.txt_giatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_giatri.Location = new System.Drawing.Point(171, 200);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(54, 22);
            this.txt_giatri.TabIndex = 10;
            this.txt_giatri.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(126, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "bằng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phần tử thứ";
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(131, 232);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(94, 28);
            this.btn_Nhap.TabIndex = 7;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // txt_chiso
            // 
            this.txt_chiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_chiso.Location = new System.Drawing.Point(92, 200);
            this.txt_chiso.Name = "txt_chiso";
            this.txt_chiso.Size = new System.Drawing.Size(32, 22);
            this.txt_chiso.TabIndex = 6;
            this.txt_chiso.Text = "i";
            this.txt_chiso.TextChanged += new System.EventHandler(this.txt_chiso_TextChanged);
            // 
            // btn_Ngaunhien
            // 
            this.btn_Ngaunhien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ngaunhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ngaunhien.Location = new System.Drawing.Point(15, 133);
            this.btn_Ngaunhien.Name = "btn_Ngaunhien";
            this.btn_Ngaunhien.Size = new System.Drawing.Size(94, 28);
            this.btn_Ngaunhien.TabIndex = 5;
            this.btn_Ngaunhien.Text = "Ngẫu nhiên";
            this.btn_Ngaunhien.UseVisualStyleBackColor = true;
            this.btn_Ngaunhien.Click += new System.EventHandler(this.btn_Ngaunhien_Click);
            // 
            // btn_Taomang
            // 
            this.btn_Taomang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Taomang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Taomang.Location = new System.Drawing.Point(129, 133);
            this.btn_Taomang.Name = "btn_Taomang";
            this.btn_Taomang.Size = new System.Drawing.Size(96, 28);
            this.btn_Taomang.TabIndex = 4;
            this.btn_Taomang.Text = "Tạo mảng";
            this.btn_Taomang.UseVisualStyleBackColor = true;
            this.btn_Taomang.Click += new System.EventHandler(this.btn_Taomang_Click);
            // 
            // btn_Docfile
            // 
            this.btn_Docfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Docfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Docfile.Location = new System.Drawing.Point(129, 26);
            this.btn_Docfile.Name = "btn_Docfile";
            this.btn_Docfile.Size = new System.Drawing.Size(96, 29);
            this.btn_Docfile.TabIndex = 3;
            this.btn_Docfile.Text = "Đọc file";
            this.btn_Docfile.UseVisualStyleBackColor = true;
            this.btn_Docfile.Click += new System.EventHandler(this.btn_Docfile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tạo mảng thủ công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tạo mảng tự động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo mảng từ file";
            // 
            // grb_cacthuattoan
            // 
            this.grb_cacthuattoan.BackColor = System.Drawing.Color.Transparent;
            this.grb_cacthuattoan.Controls.Add(this.rad_insertionsort);
            this.grb_cacthuattoan.Controls.Add(this.rad_Selectionsort);
            this.grb_cacthuattoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_cacthuattoan.Location = new System.Drawing.Point(666, 415);
            this.grb_cacthuattoan.Name = "grb_cacthuattoan";
            this.grb_cacthuattoan.Size = new System.Drawing.Size(117, 282);
            this.grb_cacthuattoan.TabIndex = 7;
            this.grb_cacthuattoan.TabStop = false;
            this.grb_cacthuattoan.Text = "Thuật toán";
            // 
            // rad_insertionsort
            // 
            this.rad_insertionsort.AutoSize = true;
            this.rad_insertionsort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rad_insertionsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_insertionsort.Location = new System.Drawing.Point(6, 35);
            this.rad_insertionsort.Name = "rad_insertionsort";
            this.rad_insertionsort.Size = new System.Drawing.Size(102, 20);
            this.rad_insertionsort.TabIndex = 1;
            this.rad_insertionsort.TabStop = true;
            this.rad_insertionsort.Text = "Insertion Sort";
            this.rad_insertionsort.UseVisualStyleBackColor = true;
            this.rad_insertionsort.CheckedChanged += new System.EventHandler(this.rad_insertionsort_CheckedChanged);
            // 
            // rad_Selectionsort
            // 
            this.rad_Selectionsort.AutoSize = true;
            this.rad_Selectionsort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rad_Selectionsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_Selectionsort.Location = new System.Drawing.Point(6, 84);
            this.rad_Selectionsort.Name = "rad_Selectionsort";
            this.rad_Selectionsort.Size = new System.Drawing.Size(108, 20);
            this.rad_Selectionsort.TabIndex = 0;
            this.rad_Selectionsort.TabStop = true;
            this.rad_Selectionsort.Text = "Selection Sort";
            this.rad_Selectionsort.UseVisualStyleBackColor = true;
            this.rad_Selectionsort.CheckedChanged += new System.EventHandler(this.rad_Selectionsort_CheckedChanged);
            // 
            // grb_xemCode
            // 
            this.grb_xemCode.BackColor = System.Drawing.Color.Transparent;
            this.grb_xemCode.Controls.Add(this.btn_Thunho);
            this.grb_xemCode.Controls.Add(this.lst_Code);
            this.grb_xemCode.Controls.Add(this.btn_Phongto);
            this.grb_xemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_xemCode.Location = new System.Drawing.Point(271, 415);
            this.grb_xemCode.Name = "grb_xemCode";
            this.grb_xemCode.Size = new System.Drawing.Size(389, 282);
            this.grb_xemCode.TabIndex = 8;
            this.grb_xemCode.TabStop = false;
            this.grb_xemCode.Text = "Xem Code C/C++";
            // 
            // btn_Thunho
            // 
            this.btn_Thunho.AutoSize = true;
            this.btn_Thunho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thunho.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thunho.Location = new System.Drawing.Point(250, 237);
            this.btn_Thunho.Name = "btn_Thunho";
            this.btn_Thunho.Size = new System.Drawing.Size(66, 34);
            this.btn_Thunho.TabIndex = 8;
            this.btn_Thunho.Text = "Thu nhỏ";
            this.btn_Thunho.UseVisualStyleBackColor = true;
            this.btn_Thunho.Click += new System.EventHandler(this.btn_Thunho_Click);
            // 
            // lst_Code
            // 
            this.lst_Code.BackColor = System.Drawing.SystemColors.Window;
            this.lst_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_Code.FormattingEnabled = true;
            this.lst_Code.ItemHeight = 15;
            this.lst_Code.Location = new System.Drawing.Point(6, 19);
            this.lst_Code.Name = "lst_Code";
            this.lst_Code.Size = new System.Drawing.Size(377, 197);
            this.lst_Code.TabIndex = 0;
            // 
            // btn_Phongto
            // 
            this.btn_Phongto.AutoSize = true;
            this.btn_Phongto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Phongto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phongto.Location = new System.Drawing.Point(92, 237);
            this.btn_Phongto.Name = "btn_Phongto";
            this.btn_Phongto.Size = new System.Drawing.Size(66, 35);
            this.btn_Phongto.TabIndex = 7;
            this.btn_Phongto.Text = "Phóng to";
            this.btn_Phongto.UseVisualStyleBackColor = true;
            this.btn_Phongto.Click += new System.EventHandler(this.btn_Phongto_Click);
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_A.ForeColor = System.Drawing.Color.Black;
            this.lbl_A.Location = new System.Drawing.Point(68, 182);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(25, 24);
            this.lbl_A.TabIndex = 11;
            this.lbl_A.Text = "a:";
            this.lbl_A.Visible = false;
            // 
            // grb_dieukhien
            // 
            this.grb_dieukhien.BackColor = System.Drawing.Color.Transparent;
            this.grb_dieukhien.Controls.Add(this.label6);
            this.grb_dieukhien.Controls.Add(this.rad_Giam);
            this.grb_dieukhien.Controls.Add(this.rad_Tang);
            this.grb_dieukhien.Controls.Add(this.btn_Chayhet);
            this.grb_dieukhien.Controls.Add(this.lbl_Toc_do);
            this.grb_dieukhien.Controls.Add(this.btn_Dung);
            this.grb_dieukhien.Controls.Add(this.Trb_Toc_do);
            this.grb_dieukhien.Controls.Add(this.btn_Ketiep);
            this.grb_dieukhien.Controls.Add(this.btn_Sapxep);
            this.grb_dieukhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dieukhien.Location = new System.Drawing.Point(789, 415);
            this.grb_dieukhien.Name = "grb_dieukhien";
            this.grb_dieukhien.Size = new System.Drawing.Size(209, 282);
            this.grb_dieukhien.TabIndex = 27;
            this.grb_dieukhien.TabStop = false;
            this.grb_dieukhien.Text = "Điều khiển";
            // 
            // lbl_status_01
            // 
            this.lbl_status_01.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status_01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_01.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_status_01.Location = new System.Drawing.Point(366, 37);
            this.lbl_status_01.Name = "lbl_status_01";
            this.lbl_status_01.Size = new System.Drawing.Size(355, 39);
            this.lbl_status_01.TabIndex = 29;
            this.lbl_status_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status_01.Visible = false;
            // 
            // Tmr_thay_doi_toc_do
            // 
            this.Tmr_thay_doi_toc_do.Enabled = true;
            this.Tmr_thay_doi_toc_do.Interval = 1;
            this.Tmr_thay_doi_toc_do.Tick += new System.EventHandler(this.Tmr_thay_doi_toc_do_Tick);
            // 
            // Mui_ten_xanh_len_1
            // 
            this.Mui_ten_xanh_len_1.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_len_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_xanh_len_1.ForeColor = System.Drawing.Color.Black;
            this.Mui_ten_xanh_len_1.Image = global::SortTest.Properties.Resources.Green_Up_Arrow;
            this.Mui_ten_xanh_len_1.Location = new System.Drawing.Point(661, 362);
            this.Mui_ten_xanh_len_1.Name = "Mui_ten_xanh_len_1";
            this.Mui_ten_xanh_len_1.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_len_1.TabIndex = 30;
            this.Mui_ten_xanh_len_1.Text = "u1";
            this.Mui_ten_xanh_len_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_len_1.Visible = false;
            // 
            // Mui_ten_xanh_xuong_1
            // 
            this.Mui_ten_xanh_xuong_1.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_xuong_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Mui_ten_xanh_xuong_1.Image = global::SortTest.Properties.Resources.Green_Down_Arrow;
            this.Mui_ten_xanh_xuong_1.Location = new System.Drawing.Point(582, 362);
            this.Mui_ten_xanh_xuong_1.Name = "Mui_ten_xanh_xuong_1";
            this.Mui_ten_xanh_xuong_1.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_xuong_1.TabIndex = 31;
            this.Mui_ten_xanh_xuong_1.Text = "d1";
            this.Mui_ten_xanh_xuong_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_xuong_1.Visible = false;
            // 
            // Trb_Toc_do
            // 
            this.Trb_Toc_do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Trb_Toc_do.Location = new System.Drawing.Point(114, 84);
            this.Trb_Toc_do.Name = "Trb_Toc_do";
            this.Trb_Toc_do.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Trb_Toc_do.Size = new System.Drawing.Size(45, 145);
            this.Trb_Toc_do.TabIndex = 3;
            this.Trb_Toc_do.TickFrequency = 2;
            this.Trb_Toc_do.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Trb_Toc_do.Value = 5;
            // 
            // lbl_Toc_do
            // 
            this.lbl_Toc_do.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toc_do.Location = new System.Drawing.Point(98, 225);
            this.lbl_Toc_do.Name = "lbl_Toc_do";
            this.lbl_Toc_do.Size = new System.Drawing.Size(76, 18);
            this.lbl_Toc_do.TabIndex = 4;
            this.lbl_Toc_do.Text = "10";
            this.lbl_Toc_do.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad_Tang
            // 
            this.rad_Tang.AutoSize = true;
            this.rad_Tang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rad_Tang.Location = new System.Drawing.Point(102, 32);
            this.rad_Tang.Name = "rad_Tang";
            this.rad_Tang.Size = new System.Drawing.Size(96, 19);
            this.rad_Tang.TabIndex = 5;
            this.rad_Tang.TabStop = true;
            this.rad_Tang.Text = "Sắp xếp tăng";
            this.rad_Tang.UseVisualStyleBackColor = true;
            this.rad_Tang.CheckedChanged += new System.EventHandler(this.rad_Tang_CheckedChanged);
            // 
            // rad_Giam
            // 
            this.rad_Giam.AutoSize = true;
            this.rad_Giam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rad_Giam.Location = new System.Drawing.Point(102, 61);
            this.rad_Giam.Name = "rad_Giam";
            this.rad_Giam.Size = new System.Drawing.Size(100, 19);
            this.rad_Giam.TabIndex = 6;
            this.rad_Giam.TabStop = true;
            this.rad_Giam.Text = "Sắp xếp giảm";
            this.rad_Giam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(115, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tốc độ";
            // 
            // btn_Sapxep
            // 
            this.btn_Sapxep.AutoSize = true;
            this.btn_Sapxep.Enabled = false;
            this.btn_Sapxep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sapxep.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sapxep.Location = new System.Drawing.Point(10, 24);
            this.btn_Sapxep.Name = "btn_Sapxep";
            this.btn_Sapxep.Size = new System.Drawing.Size(63, 35);
            this.btn_Sapxep.TabIndex = 0;
            this.btn_Sapxep.Text = "&Sắp xếp";
            this.btn_Sapxep.UseVisualStyleBackColor = true;
            this.btn_Sapxep.Click += new System.EventHandler(this.btn_Sapxep_Click);
            // 
            // btn_Ketiep
            // 
            this.btn_Ketiep.AutoSize = true;
            this.btn_Ketiep.Enabled = false;
            this.btn_Ketiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ketiep.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Ketiep.Location = new System.Drawing.Point(12, 168);
            this.btn_Ketiep.Name = "btn_Ketiep";
            this.btn_Ketiep.Size = new System.Drawing.Size(61, 34);
            this.btn_Ketiep.TabIndex = 2;
            this.btn_Ketiep.Text = ":";
            this.btn_Ketiep.UseVisualStyleBackColor = true;
            this.btn_Ketiep.Click += new System.EventHandler(this.btn_Ketiep_Click);
            // 
            // btn_Dung
            // 
            this.btn_Dung.AutoSize = true;
            this.btn_Dung.Enabled = false;
            this.btn_Dung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dung.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Dung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Dung.Location = new System.Drawing.Point(10, 123);
            this.btn_Dung.Name = "btn_Dung";
            this.btn_Dung.Size = new System.Drawing.Size(61, 34);
            this.btn_Dung.TabIndex = 1;
            this.btn_Dung.Text = ";";
            this.btn_Dung.UseVisualStyleBackColor = true;
            this.btn_Dung.Click += new System.EventHandler(this.btn_Dung_Click);
            // 
            // btn_Chayhet
            // 
            this.btn_Chayhet.AutoSize = true;
            this.btn_Chayhet.Enabled = false;
            this.btn_Chayhet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Chayhet.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Chayhet.Location = new System.Drawing.Point(10, 71);
            this.btn_Chayhet.Name = "btn_Chayhet";
            this.btn_Chayhet.Size = new System.Drawing.Size(61, 34);
            this.btn_Chayhet.TabIndex = 0;
            this.btn_Chayhet.Text = "8";
            this.btn_Chayhet.UseVisualStyleBackColor = true;
            this.btn_Chayhet.Click += new System.EventHandler(this.btn_Chayhet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SortTest.Properties.Resources.Screenshot_2022_12_22_100733;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 707);
            this.Controls.Add(this.Mui_ten_xanh_xuong_1);
            this.Controls.Add(this.Mui_ten_xanh_len_1);
            this.Controls.Add(this.lbl_status_01);
            this.Controls.Add(this.grb_cacthuattoan);
            this.Controls.Add(this.grb_dieukhien);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.grb_xemCode);
            this.Controls.Add(this.grb_nhap);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Giao diện mô phỏng thuật toán giải thuật sắp xếp";
            this.grb_nhap.ResumeLayout(false);
            this.grb_nhap.PerformLayout();
            this.grb_cacthuattoan.ResumeLayout(false);
            this.grb_cacthuattoan.PerformLayout();
            this.grb_xemCode.ResumeLayout(false);
            this.grb_xemCode.PerformLayout();
            this.grb_dieukhien.ResumeLayout(false);
            this.grb_dieukhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_chiso;
        private System.Windows.Forms.Button btn_Ngaunhien;
        private System.Windows.Forms.Button btn_Taomang;
        private System.Windows.Forms.Button btn_Docfile;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sophantu;
        private System.Windows.Forms.GroupBox grb_cacthuattoan;
        private System.Windows.Forms.RadioButton rad_insertionsort;
        private System.Windows.Forms.RadioButton rad_Selectionsort;
        private System.Windows.Forms.GroupBox grb_xemCode;
        private System.Windows.Forms.ListBox lst_Code;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.GroupBox grb_dieukhien;
        private System.Windows.Forms.Button btn_Thunho;
        private System.Windows.Forms.Button btn_Phongto;
        private System.Windows.Forms.Label lbl_status_01;
        private System.Windows.Forms.Timer Tmr_thay_doi_toc_do;
        private System.Windows.Forms.Label Mui_ten_xanh_len_1;
        private System.Windows.Forms.Label Mui_ten_xanh_xuong_1;
        private System.Windows.Forms.Button btn_Mofile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rad_Giam;
        private System.Windows.Forms.RadioButton rad_Tang;
        private System.Windows.Forms.Label lbl_Toc_do;
        private System.Windows.Forms.TrackBar Trb_Toc_do;
        private System.Windows.Forms.Button btn_Chayhet;
        private System.Windows.Forms.Button btn_Dung;
        private System.Windows.Forms.Button btn_Ketiep;
        private System.Windows.Forms.Button btn_Sapxep;
    }
}

