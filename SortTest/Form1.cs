using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SortTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Khai báo các biến toàn cục
        TextBox[] Node;
        int[] a;
        int Spt = 0; //số phần tử
        Label[] Chi_so;
        int Toc_do;
        int i, Kthuoc_Code = 10;
        Boolean Da_tao_mang, KT_tam_dung = false; //Biến kiểm tra đã tạo mảng và kiểm tra tạm dừng
        //Biến kiểm tra sắp xếp 1 lần hay từng bước
        Boolean Sap_xep_tung_buoc;

        #endregion

        #region Khai báo các biến định dạng node
        int Khoang_cach;//khoảng cách 2 node liên tiếp
        int Canh_le;//canh lề node
        int Kich_thuoc; // kích thước node
        int Co_chu; //kích thước chữ
        #endregion Khai báo các biến định dạng node

        #region CÁC HÀM DI CHUYỂN NODE
        // Hàm swap 2 node có thể hiện
        public void Hoan_Vi_Node(Control t1, Control t2)
        {
            Application.DoEvents();

            this.Invoke((MethodInvoker)delegate
            {
                Point p1 = t1.Location; //lưu vị trí ban đầu của t1
                Point p2 = t2.Location; //lưu vị trí ban đầu của t2
                if (p1 != p2)
                {
                    // t1 lên, t2 xuống
                    while ((t1.Location.Y > p1.Y - (Kich_thuoc + 5)) || (t2.Location.Y < p2.Y + (Kich_thuoc + 5)))
                    {
                        Application.DoEvents();
                        t1.Top -= 1;
                        t2.Top += 1;
                        Tre(Toc_do);

                    }
                    // t1 dịch phải, t2 dịch trái
                    if (t1.Location.X < t2.Location.X)
                    {

                        while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                        {
                            Application.DoEvents();
                            t1.Left += 1;
                            t2.Left -= 1;
                            Tre(Toc_do);


                        }

                    }
                    // t1 dịch trái, t2 dịch phải
                    else
                    {

                        while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                        {
                            Application.DoEvents();
                            t1.Left -= 1;
                            t2.Left += 1;
                            Tre(Toc_do);

                        }

                    }
                    // t1 xuống, t2 lên
                    while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
                    {
                        Application.DoEvents();
                        t1.Top += 1;
                        t2.Top -= 1;
                        Tre(Toc_do);

                    }
                    t1.Refresh();
                    t2.Refresh();
                }
            });

        }
        // t dịch chuyển sang Phải Step Node
        public void Node_qua_phai(Control t, int Step)
        {
            Application.DoEvents();

            this.Invoke((MethodInvoker)delegate
            {
                int Loop_Count = ((Kich_thuoc + Khoang_cach)) * Step; //Số lần dịch chuyển
                {
                    while (Loop_Count > 0)
                    {
                        Application.DoEvents();
                        t.Left += 1;
                        Tre(Toc_do);
                        Loop_Count--;
                    }
                }
                t.Refresh();
            });
        }
        // t dịch chuyển sang trai Step Node
        public void Node_qua_trai(Control t, int Step)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int Loop_Count = ((Kich_thuoc + Khoang_cach)) * Step; //Số lần dịch chuyển
                while (Loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Left -= 1;
                    Tre(Toc_do);
                    Loop_Count--;
                }
                t.Refresh();
            });
        }
        // t dịch chuyển lên với quãng đường S
        public void Node_di_len(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                //t xuống
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Top -= 1;
                    Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }
        // t dịch chuyển xuống với quãng đường S
        public void Node_di_xuong(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                // t lên
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Top += 1;
                    Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }
        
        #endregion

        #region CÁC HÀM KHÁC
        //Hàm ngủ
        public void SleepP(int milisecond)
        {
            int i;
            for (i = 0; i < milisecond; i++)
            {
                Application.DoEvents();
                Thread.Sleep(5);
            }
            Application.DoEvents();
        }
        //Hàm Trễ
        public void Tre(int milisecond)
        {
            //Nếu tốc độ max thì ko sleep
            if (Trb_Toc_do.Value == Trb_Toc_do.Maximum)
            {
                Application.DoEvents();
                return;
            }

            SleepP(milisecond);
        }
        // Hàm hoán vị 2 node mà không thể hiện
        public void Hoan_Tri_Node(int t1, int t2)
        {
            TextBox Temp = Node[t1];
            Node[t1] = Node[t2];
            Node[t2] = Temp;
        }
        // Hàm hoán vị 2 giá trị
        public void Hoan_vi(ref int i, ref int j)
        {
            int Temp = i;
            i = j;
            j = Temp;

        }

        //Sắp xếp hoàn thành
        public void Hoan_thanh()
        {
            for (i = 0; i < Spt; i++)
            {
                Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
            }
            //Ẩn các index
            Mui_ten_xanh_xuong_1.Visible = false;        
            Mui_ten_xanh_len_1.Visible = false;
            lbl_status_01.Visible = true;
            lbl_status_01.Text = "Đã sắp xếp xong!";
            btn_Ngaunhien.Enabled = false;
            btn_Nhap.Enabled = false;
            btn_Dung.Enabled = false;
            btn_Chayhet.Enabled = false;
            btn_Ketiep.Enabled = true;
            //Thiết lập các nút nhập liệu
            rad_insertionsort.Enabled = true;           
            rad_Selectionsort.Enabled = true;     
            btn_Docfile.Enabled = true;
            btn_Taomang.Enabled = true;
            btn_Ngaunhien.Enabled = true;
            btn_Nhap.Enabled = true;
            txt_chiso.Enabled = true;
            txt_giatri.Enabled = true;
        }
        //Hàm tạo mảng
        public void Tao_mang()
        {
            if ((Spt < 2) || (Spt > 30))
            {
                lbl_A.Visible = false;
                MessageBox.Show("2 <= Số Phần Tử <= 30");

                this.txt_sophantu.Clear();
                Da_tao_mang = false;
                return;
            }

            #region Thiết lập thuộc tính node ứng với số phần tử
            switch (Spt)
            {
                case 30:
                case 29:
                case 28:
                case 27:
                case 26:
                    Kich_thuoc = 27;
                    Co_chu = 10;
                    Khoang_cach = 6;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 25:
                case 24:
                case 23:
                case 22:
                case 21:
                    Kich_thuoc = 30;
                    Co_chu = 13;
                    Khoang_cach = 10;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 20:
                case 19:
                    Kich_thuoc = 40;
                    Co_chu = 18;
                    Khoang_cach = 5;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 18:
                case 17:
                case 16:
                    Kich_thuoc = 40;
                    Co_chu = 18;
                    Khoang_cach = 10;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    Kich_thuoc = 40;
                    Co_chu = 18;
                    Khoang_cach = 18;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                    Kich_thuoc = 50;
                    Co_chu = 25;
                    Khoang_cach = 40;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
            }
            #endregion
            #region Tạo các mảng dữ liệu
            Chi_so = new Label[Spt];
            a = new int[Spt];
            Node = new TextBox[Spt];
            #endregion
            //Dán nhãn mảng a
            lbl_A.Width = Kich_thuoc;
            lbl_A.Height = Kich_thuoc;
            lbl_A.Location = new Point(Canh_le - (Kich_thuoc), 250);
            lbl_A.Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Bold);
            lbl_A.Visible = true;
            #region Tạo node và chỉ số
            for (i = 0; i < Spt; i++)
            {
                //node
                a[i] = i;
                Node[i] = new TextBox();
                Node[i].Multiline = true;
                Node[i].Text = a[i].ToString();
                Node[i].TextAlign = HorizontalAlignment.Center;
                Node[i].Width = Kich_thuoc;
                Node[i].Height = Kich_thuoc;
                Node[i].Location = new Point(Canh_le + (Kich_thuoc + Khoang_cach) * i, 250);
                Node[i].BackColor = Color.OrangeRed;
                Node[i].ForeColor = Color.White;
                Node[i].Font = new Font(this.Font, FontStyle.Bold);
                Node[i].Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Bold);
                Node[i].ReadOnly = true;
                this.Controls.Add(Node[i]);
                //chỉ số
                Chi_so[i] = new Label();
                Chi_so[i].TextAlign = ContentAlignment.MiddleCenter;
                Chi_so[i].Text = i.ToString();
                Chi_so[i].Width = Kich_thuoc;
                Chi_so[i].Height = Kich_thuoc;
                Chi_so[i].ForeColor = Color.Azure;
                Chi_so[i].Location = new Point(Canh_le + (Kich_thuoc + Khoang_cach) * i, 340 + 3 * Kich_thuoc);
                if (Spt <= 10)
                {
                    Chi_so[i].Font = new System.Drawing.Font("Arial", Co_chu - 10, FontStyle.Regular);
                }
                else
                {
                    Chi_so[i].Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Regular);
                }
                this.Controls.Add(Chi_so[i]);
                Da_tao_mang = true; //Xác nhận đã tạo mảng
                                    //Cho phép các nút điều khiển có tác dụng khi đã tạo mảng
                btn_Sapxep.Enabled = true;
                btn_Ngaunhien.Enabled = true;
                btn_Nhap.Enabled = true;

            }
            #endregion
        }
        //Hàm xóa mảng
        public void Xoa_mang()
        {
            btn_Nhap.Enabled = false;
            btn_Ngaunhien.Enabled = false;
            btn_Sapxep.Enabled = false;
            if (Da_tao_mang == true)
            {
                for (i = 0; i < Spt; i++)
                {
                    this.Controls.Remove(Node[i]);
                    this.Controls.Remove(Chi_so[i]);

                }
            }
        }
        //Hàm dừng toàn bộ chương trình
        public void Play_or_Stop()
        {
            while (KT_tam_dung == true)
            {
                Application.DoEvents();
            }
        }
        //Hàm Tạm dừng
        public void Tam_dung()
        {
            if (Sap_xep_tung_buoc == true)
            {
                KT_tam_dung = true;
                btn_Dung.Enabled = false;
                Play_or_Stop();
            }

        }
        //Hàm đặt màu cho Node
        public void Dat_mau_node(Control t, System.Drawing.Color Mau_nen, System.Drawing.Color Mau_chu)
        {
            t.BackColor = Mau_nen;
            t.ForeColor = Mau_chu;
            t.Refresh();
        }
        #endregion

        #region Các phương thức nhập dữ liệu
        //Nhập ngẫu nhiên
        private void btn_Ngaunhien_Click(object sender, EventArgs e)
        {
            btn_Sapxep.Enabled = true;
            Random r = new Random();
            for (i = 0; i < Spt; i++)
            {
                Node[i].BackColor = Color.OrangeRed; // đặt lại màu cho mảng ngẫu nhiên
                Node[i].ForeColor = Color.White;
                a[i] = r.Next(100);
                Node[i].Text = a[i].ToString();
            }
        }
        //Nhập từ file
        private void btn_Docfile_Click(object sender, EventArgs e)
        {
            //Gọi hàm xóa mảng
            Xoa_mang();
            //Đọc file
            StreamReader Re = File.OpenText("TEST.txt");
            string input = null;
            int i = 0;
            int kt = 0;
            while ((kt < 1) && ((input = Re.ReadLine()) != null))
            {
                Spt = Convert.ToInt32(input);
                kt++;
            }
            //Gọi hàm tạo mảng
            Tao_mang();
            while (((input = Re.ReadLine()) != null) && (i < Spt))
            {

                Node[i].BackColor = Color.OrangeRed; // đặt lại màu cho mảng ngẫu nhiên
                Node[i].ForeColor = Color.White;
                a[i] = Convert.ToInt32(input);
                Node[i].Text = a[i].ToString();
                i++;
            }
            Re.Close();
        }
        //Nhập bằng tay
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            Boolean KTra = true;
            int giatri;
            try
            {
                i = Convert.ToInt32(txt_chiso.Text);
            }
            catch
            {
                MessageBox.Show("Chỉ số nhập vào không hợp lệ!");
                return;
            }
            if (i > Spt - 1)
            {
                MessageBox.Show("Không có phần tử thứ  " + i);
                return;
            }
            try
            {
                giatri = Convert.ToInt32(txt_giatri.Text);
            }
            catch
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!");
                return;
            }
            if ((giatri < -10) || (giatri > 100))
            {
                MessageBox.Show("0 <= Giá trị nhập vào < 100");
                this.txt_giatri.Clear();
                KTra = false;
            }
            if (KTra == true)
            {
                for (int j = 0; j < Spt; j++)
                {
                    Node[j].BackColor = Color.OrangeRed; // đặt lại màu cho mảng không thứ tự
                    Node[j].ForeColor = Color.White;
                }
                a[i] = giatri;
                Node[i].Text = a[i].ToString();
                Chi_so[i].Text = i.ToString();
                //Đổi màu node khi nhận giá trị nhập vào
                Node[i].BackColor = Color.AliceBlue;
                Node[i].ForeColor = Color.Black;
                Node[i].Refresh();
                Thread.Sleep(1000);
                Node[i].BackColor = Color.OrangeRed;
                Node[i].ForeColor = Color.White;
                Node[i].Refresh();
                this.txt_giatri.Text = (giatri + 1).ToString();
                this.txt_chiso.Focus();
                this.txt_chiso.Text = (i + 1).ToString();
                this.txt_chiso.SelectAll();
            }
        }
        //Mở file
        private void btn_Mofile_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();

            notePad.StartInfo.FileName = "notepad.exe";
            notePad.StartInfo.Arguments = Application.StartupPath + @"/TEST.txt";
            notePad.Start();
        }

        #endregion

        #region Các hàm sắp xếp
        #region INSERTION SORT
        void InsertionSort_Tang()
        {
            int i, pos, x;
            TextBox Node_tam;
            int Chi_so_tam;
            int Dem_node;

            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                for (i = 1; i < Spt; i++)
                {
                    lst_Code.SelectedIndex = 3;
                    Tre(40 * Toc_do);
                    Application.DoEvents();
                    //Thiết lập Node đầu tiên, là Node đã có thứ tự 
                    Dat_mau_node(Node[0], Color.LawnGreen, Color.Black);
                    //đềm số bước dịch chuyển 1 Node
                    Dem_node = 0;
                    lst_Code.SelectedIndex = 5;
                    x = a[i];
                    Node_tam = Node[i];
                    Chi_so_tam = i;
                    pos = i - 1;
                    //thiết lập mũi tên đánh dấu nút cần chèn
                    Mui_ten_xanh_xuong_1.Visible = true;
                    Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                    Mui_ten_xanh_xuong_1.Text = "i=" + i;
                    Mui_ten_xanh_xuong_1.Refresh();

                    //Di chuyển Node cần chèn lên
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_di_len(Node_tam, (Kich_thuoc + 5));
                    });
                    //Tạm dừng sau 1 bước dịch chuyển Node
                    Tam_dung();
                    //Tìm vị trí chèn Node đã di chuyển lên ở trên
                    lbl_status_01.Visible = true;
                    lbl_status_01.Text = "So_Sanh(a[pos],a[i])";
                    //Thiết lập bàn tay chỉ vi trí có phải vị trí cần chèn không                        
                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * pos) + (Kich_thuoc / 2) - 30, Node[pos].Location.Y + Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Text = "POS=" + pos;
                    Mui_ten_xanh_len_1.Visible = true;
                    Mui_ten_xanh_len_1.Refresh();
                    Tre(40 * Toc_do);
                    while ((pos >= 0) && (a[pos] > x))
                    {
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        //Thiết lập bàn tay chỉ vi trí có phải vị trí cần chèn không                        
                        Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * pos) + (Kich_thuoc / 2) - 30, Node[pos].Location.Y + Kich_thuoc + 5);
                        Mui_ten_xanh_len_1.Text = "POS=" + pos;
                        Mui_ten_xanh_len_1.Visible = true;
                        Mui_ten_xanh_len_1.Refresh();

                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "So_Sanh(a[pos],a[i])";
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                        lst_Code.SelectedIndex = 9;
                        //Dịch chuyển Node qua phải
                        a[pos + 1] = a[pos];
                        Dem_node++;

                        Application.DoEvents();
                        this.Invoke((MethodInvoker)delegate
                        {
                            Node_qua_phai(Node[pos], 1);
                        });
                        Hoan_Tri_Node(pos + 1, pos);
                        lst_Code.SelectedIndex = 10;
                        pos--;
                        lst_Code.SelectedIndex = 12;
                        a[pos + 1] = x;
                        //Tạm dừng sau 1 bước dịch chuyển Node
                        Tam_dung();

                    }
                    //status hoán vị
                    if (Dem_node > 0)
                    {
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "Hoan_vi(a[pos],a[i])";
                    }
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_qua_trai(Node_tam, Dem_node);
                    });

                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_di_xuong(Node_tam, (Kich_thuoc + 5));
                    });
                    //Ẩn status
                    lbl_status_01.Visible = false;
                    //Ẩn mũi tên POS sau khi đã tìm ra POS
                    Mui_ten_xanh_len_1.Visible = false; ;
                    //Thiết lập node nằm trong nhóm đã có thứ tự
                    Node[pos + 1] = Node_tam;
                    Dat_mau_node(Node[pos + 1], Color.LawnGreen, Color.Black);
                    //Tạm dừng sau 1 bước dịch chuyển Node
                    Tam_dung();
                }
            });
            lst_Code.SelectedIndex = 0;
            Hoan_thanh();
        }

        void InsertionSort_Giam()
        {
            int i, pos, x;
            TextBox Node_tam;
            int Chi_so_tam;
            int Dem_node;

            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                for (i = 1; i < Spt; i++)
                {
                    lst_Code.SelectedIndex = 3;
                    Tre(40 * Toc_do);
                    Application.DoEvents();
                    //Thiết lập Node đầu tiên, là Node đã có thứ tự 
                    Dat_mau_node(Node[0], Color.LawnGreen, Color.Black);
                    //đềm số bước dịch chuyển 1 Node
                    Dem_node = 0;
                    lst_Code.SelectedIndex = 5;
                    x = a[i];
                    Node_tam = Node[i];
                    Chi_so_tam = i;
                    pos = i - 1;
                    //thiết lập mũi tên đánh dấu nút cần chèn
                    Mui_ten_xanh_xuong_1.Visible = true;
                    Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                    Mui_ten_xanh_xuong_1.Text = "i=" + i;
                    Mui_ten_xanh_xuong_1.Refresh();

                    //Di chuyển Node cần chèn lên
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_di_len(Node_tam, (Kich_thuoc + 5));
                    });
                    //Tạm dừng sau 1 bước dịch chuyển Node
                    Tam_dung();
                    //Tìm vị trí chèn Node đã di chuyển lên ở trên
                    lbl_status_01.Visible = true;
                    lbl_status_01.Text = "So_Sanh(a[pos],a[i])";
                    //Thiết lập bàn tay chỉ vi trí có phải vị trí cần chèn không                        
                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * pos) + (Kich_thuoc / 2) - 30, Node[pos].Location.Y + Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Text = "POS=" + pos;
                    Mui_ten_xanh_len_1.Visible = true;
                    Mui_ten_xanh_len_1.Refresh();
                    Tre(40 * Toc_do);
                    while ((pos >= 0) && (a[pos] < x))
                    {
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        //Thiết lập bàn tay chỉ vi trí có phải vị trí cần chèn không                        
                        Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * pos) + (Kich_thuoc / 2) - 30, Node[pos].Location.Y + Kich_thuoc + 5);
                        Mui_ten_xanh_len_1.Text = "POS=" + pos;
                        Mui_ten_xanh_len_1.Visible = true;
                        Mui_ten_xanh_len_1.Refresh();

                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "So_Sanh(a[pos],a[i])";
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                        lst_Code.SelectedIndex = 9;
                        //Dịch chuyển Node qua phải
                        a[pos + 1] = a[pos];
                        Dem_node++;

                        Application.DoEvents();
                        this.Invoke((MethodInvoker)delegate
                        {
                            Node_qua_phai(Node[pos], 1);
                        });
                        Hoan_Tri_Node(pos + 1, pos);
                        lst_Code.SelectedIndex = 10;
                        pos--;
                        lst_Code.SelectedIndex = 12;
                        a[pos + 1] = x;
                        //Tạm dừng sau 1 bước dịch chuyển Node
                        Tam_dung();

                    }
                    //status hoán vị
                    if (Dem_node > 0)
                    {
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "Hoan_vi(a[pos],a[i])";
                    }
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_qua_trai(Node_tam, Dem_node);
                    });

                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_di_xuong(Node_tam, (Kich_thuoc + 5));
                    });
                    //Ẩn status
                    lbl_status_01.Visible = false;
                    //Ẩn mũi tên POS sau khi đã tìm ra POS
                    Mui_ten_xanh_len_1.Visible = false; ;
                    //Thiết lập node nằm trong nhóm đã có thứ tự
                    Node[pos + 1] = Node_tam;
                    Dat_mau_node(Node[pos + 1], Color.LawnGreen, Color.Black);
                    //Tạm dừng sau 1 bước dịch chuyển Node
                    Tam_dung();
                }
            });
            lst_Code.SelectedIndex = 0;
            Hoan_thanh(); 
        }

        #endregion
        #region SELECTION SORT
        void SelectionSort_Tang()
        {
            int min, i, j;

            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                for (i = 0; i < Spt - 1; i++)
                {
                    Application.DoEvents();
                    lst_Code.SelectedIndex = 3;
                    Tre(40 * Toc_do);
                    lst_Code.SelectedIndex = 5;
                    Tre(40 * Toc_do);
                    min = i;
                    
                    //Thiết lập
                    Mui_ten_xanh_xuong_1.Visible = true;
                    Mui_ten_xanh_xuong_1.Text = "i=" + i;
                    Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 60);
                    Mui_ten_xanh_xuong_1.Refresh();
                    //thiết lập mũi tên chỉ vị trí MIN đầu tiên
                    Mui_ten_xanh_len_1.Visible = true;
                    Mui_ten_xanh_len_1.Text = "Min=" + min;
                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * min) + (Kich_thuoc / 2) - 30, Node[min].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Refresh();
                    Tre(40 * Toc_do);
                    //

                    for (j = i + 1; j < Spt; j++)
                    {
                        lst_Code.SelectedIndex = 6;
                        Tre(40 * Toc_do);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "So_Sanh( a[min] , a[" + j + "] )";
                        lbl_status_01.Refresh();
                        //đánh dấu phần tử lúc so sánh với min                       
                        Dat_mau_node(Node[i], Color.Navy, Color.White);
                        Dat_mau_node(Node[j], Color.Navy, Color.White);
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                        // bỏ đánh dấu sau khi đã có kết quả so sánh
                        Dat_mau_node(Node[i], Color.Navy, Color.White);
                        Dat_mau_node(Node[j], Color.OrangeRed, Color.White);

                        if (a[j] < a[min]) 
                        {
                            lst_Code.SelectedIndex = 8;

                            min = j;
                            Tam_dung();
                            //thiết lập mũi tên chỉ vị trí MIN
                            Mui_ten_xanh_len_1.Text = "Min=" + min;
                            Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * min) + (Kich_thuoc / 2) - 30, Node[j].Location.Y + 2 * Kich_thuoc + 5);
                            Mui_ten_xanh_len_1.Refresh();
                            Tre(20 * Toc_do);
                        }                          
                    }
                    //status
                    if (min != i)
                    {
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "Hoan_vi( a[i] , a[min] )";
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                    }
                    //
                    lst_Code.SelectedIndex = 9;
                    Tre(40 * Toc_do);
                    Hoan_vi(ref a[min], ref a[i]);
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Hoan_Vi_Node(Node[min], Node[i]);
                    });
                    Tam_dung();
                    Hoan_Tri_Node(min, i);
                    //Thiết lập nút đã có thứ tự
                    Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                }
                //Thiết lập nút cuối cùng đúng thứ tự
                Dat_mau_node(Node[Spt - 1], Color.LawnGreen, Color.Black);

            });
            lst_Code.SelectedIndex = 0;
            Hoan_thanh();
        }
        void SelectionSort_Giam()
        {
            int max, i, j;

            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                for (i = 0; i < Spt - 1; i++)
                {
                    Application.DoEvents();
                    lst_Code.SelectedIndex = 3;
                    Tre(40 * Toc_do);
                    lst_Code.SelectedIndex = 5;
                    Tre(40 * Toc_do);
                    max = i;

                    //Thiết lập
                    Mui_ten_xanh_xuong_1.Visible = true;
                    Mui_ten_xanh_xuong_1.Text = "i=" + i;
                    Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 60);
                    Mui_ten_xanh_xuong_1.Refresh();
                    //thiết lập mũi tên chỉ vị trí MIN đầu tiên
                    Mui_ten_xanh_len_1.Visible = true;
                    Mui_ten_xanh_len_1.Text = "Max=" + max;
                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * max) + (Kich_thuoc / 2) - 30, Node[max].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Refresh();
                    Tre(40 * Toc_do);
                    //

                    for (j = i + 1; j < Spt; j++)
                    {
                        lst_Code.SelectedIndex = 6;
                        Tre(40 * Toc_do);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "So_Sanh( a[max] , a[" + j + "] )";
                        lbl_status_01.Refresh();
                        //đánh dấu phần tử lúc so sánh với min                       
                        Dat_mau_node(Node[i], Color.Navy, Color.White);
                        Dat_mau_node(Node[j], Color.Navy, Color.White);
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                        // bỏ đánh dấu sau khi đã có kết quả so sánh
                        Dat_mau_node(Node[i], Color.Navy, Color.White);
                        Dat_mau_node(Node[j], Color.OrangeRed, Color.White);

                        if (a[j] > a[max])
                        {
                            lst_Code.SelectedIndex = 8;

                            max = j;
                            Tam_dung();
                            //thiết lập mũi tên chỉ vị trí MIN
                            Mui_ten_xanh_len_1.Text = "Max=" + max;
                            Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * max) + (Kich_thuoc / 2) - 30, Node[j].Location.Y + 2 * Kich_thuoc + 5);
                            Mui_ten_xanh_len_1.Refresh();
                            Tre(20 * Toc_do);
                        }
                    }
                    //status
                    if (max != i)
                    {
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "Hoan_vi( a[i] , a[min] )";
                        Tre(40 * Toc_do);
                        lbl_status_01.Visible = false;
                    }
                    //
                    lst_Code.SelectedIndex = 9;
                    Tre(40 * Toc_do);
                    Hoan_vi(ref a[max], ref a[i]);
                    Application.DoEvents();
                    this.Invoke((MethodInvoker)delegate
                    {
                        Hoan_Vi_Node(Node[max], Node[i]);
                    });
                    Tam_dung();
                    Hoan_Tri_Node(max, i);
                    //Thiết lập nút đã có thứ tự
                    Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                }
                //Thiết lập nút cuối cùng đúng thứ tự
                Dat_mau_node(Node[Spt - 1], Color.LawnGreen, Color.Black);

            });
            lst_Code.SelectedIndex = 0;
            Hoan_thanh();
        }
        #endregion
        #endregion

        //các nút bấm chức năng 
        private void btn_Taomang_Click(object sender, EventArgs e)
        {
            //Gọi hàm xóa mảng
            Xoa_mang();
            this.txt_sophantu.Focus();
            this.txt_sophantu.SelectAll();
            try
            {
                Spt = Convert.ToInt32(txt_sophantu.Text);
            }
            catch
            {
                MessageBox.Show("Số phần tử vừa nhập vào không hợp lệ!");
                this.txt_sophantu.Clear();
                return;
            }
            //gọi hàm tạo mảng
            Tao_mang();
        }
        private void btn_Sapxep_Click(object sender, EventArgs e)
        {
            btn_Sapxep.Enabled = false;
            rad_insertionsort.Enabled = false;
            rad_Selectionsort.Enabled = false;

            //Cho phép các nút điều khiển
            btn_Dung.Enabled = true;
            btn_Chayhet.Enabled = true;

            #region INSERTION SORT
            if (rad_insertionsort.Checked == true && rad_Tang.Checked == true)
            {
                InsertionSort_Tang();
            }
            
            if(rad_insertionsort.Checked == true && rad_Giam.Checked == true)
            {
                InsertionSort_Giam();
            }

            #endregion
            #region SELECTION SORT
            if (rad_Selectionsort.Checked == true && rad_Tang.Checked == true)
            {
                SelectionSort_Tang();
            }
            if(rad_Selectionsort.Checked == true && rad_Giam.Checked == true)
            {
                SelectionSort_Giam();
            }
            #endregion
        }
        private void Tmr_thay_doi_toc_do_Tick(object sender, EventArgs e)
        {
            Toc_do = (Trb_Toc_do.Maximum - Trb_Toc_do.Value);
            lbl_Toc_do.Text = Trb_Toc_do.Value.ToString();
            if (Trb_Toc_do.Value == Trb_Toc_do.Maximum)
            {
                lbl_Toc_do.Text = "Max=10";
            }
            else if (Trb_Toc_do.Value == Trb_Toc_do.Minimum)
            {
                lbl_Toc_do.Text = "Min=0";
            }
        }
        private void txt_sophantu_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_chiso_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Dung_Click(object sender, EventArgs e)
        {
            btn_Chayhet.Focus();

            if (btn_Dung.Text == ";")
            {
                btn_Dung.Text = "4";
                KT_tam_dung = true;
                Play_or_Stop();
            }
            else
            {
                btn_Dung.Text = ";";
                KT_tam_dung = false;
            }
        }
        private void btn_Phongto_Click(object sender, EventArgs e)
        {
            Kthuoc_Code++;
            lst_Code.Font = new System.Drawing.Font("Arial", Kthuoc_Code, FontStyle.Bold);
        }
        private void rad_insertionsort_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_Ketiep_Click(object sender, EventArgs e)
        {
            btn_Dung.Text = ";";
            Sap_xep_tung_buoc = true;
            KT_tam_dung = false;
            btn_Dung.Enabled = true;
        }
        private void btn_Chayhet_Click(object sender, EventArgs e)
        {
            btn_Dung.Text = ";";
            Sap_xep_tung_buoc = false;
            KT_tam_dung = false;
            btn_Dung.Enabled = true;
        }
        private void rad_Tang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_insertionsort.Checked == true && rad_Tang.Checked == true)
            {
                lst_Code.Items.Clear();
                //Tải code của thuật toán Insertion Sort vào Cửa sổ xem code
                lst_Code.Items.Add("void InsertionSort_Tang(int a[], int n)");
                lst_Code.Items.Add(" {");
                lst_Code.Items.Add("   int i, pos, x;");
                lst_Code.Items.Add("   for (i = 1; i < n; i++)");
                lst_Code.Items.Add("      {");
                lst_Code.Items.Add("         x = a[i];");
                lst_Code.Items.Add("         pos = i - 1;");
                lst_Code.Items.Add("         while ((pos >= 0) && (a[pos] > x))");
                lst_Code.Items.Add("           {");
                lst_Code.Items.Add("            a[pos + 1] = a[pos];");
                lst_Code.Items.Add("            pos--;");
                lst_Code.Items.Add("           }");
                lst_Code.Items.Add("         a[pos + 1] = x;");
                lst_Code.Items.Add("      }");
                lst_Code.Items.Add(" }");
            }
            if (rad_insertionsort.Checked == true && rad_Giam.Checked == true)
            {
                lst_Code.Items.Clear();
                //Tải code của thuật toán Insertion Sort vào Cửa sổ xem code
                lst_Code.Items.Add("void InsertionSort_Giam(int a[], int n)");
                lst_Code.Items.Add(" {");
                lst_Code.Items.Add("   int i, pos, x;");
                lst_Code.Items.Add("   for (i = 1; i < n; i++)");
                lst_Code.Items.Add("      {");
                lst_Code.Items.Add("         x = a[i];");
                lst_Code.Items.Add("         pos = i - 1;");
                lst_Code.Items.Add("         while ((pos >= 0) && (a[pos] < x))");
                lst_Code.Items.Add("           {");
                lst_Code.Items.Add("            a[pos + 1] = a[pos];");
                lst_Code.Items.Add("            pos--;");
                lst_Code.Items.Add("           }");
                lst_Code.Items.Add("         a[pos + 1] = x;");
                lst_Code.Items.Add("      }");
                lst_Code.Items.Add(" }");
            }

            if (rad_Selectionsort.Checked == true && rad_Tang.Checked == true)
            {
                lst_Code.Items.Clear();
                //Tải code của thuật toán Selection Sort vào Cửa sổ xem code
                lst_Code.Items.Add("void SelectionSort(int a[], int n) ");
                lst_Code.Items.Add("  {");
                lst_Code.Items.Add("    int min, i, j; ");
                lst_Code.Items.Add("    for (i = 0; i < n - 1; i++)");
                lst_Code.Items.Add("       {     ");
                lst_Code.Items.Add("         min = i;      ");
                lst_Code.Items.Add("         for (j = i + 1; j < n; j++)    ");
                lst_Code.Items.Add("           if (a[j] < a[min])     ");
                lst_Code.Items.Add("              min = j;      ");
                lst_Code.Items.Add("           if(min != i)     ");                                           
                lst_Code.Items.Add("              Swap(a[min], a[i]);       ");
                lst_Code.Items.Add("       }          ");
                lst_Code.Items.Add("   }        ");
            }
            if (rad_Selectionsort.Checked == true && rad_Giam.Checked == true)
            {
                lst_Code.Items.Clear();
                //Tải code của thuật toán Selection Sort vào Cửa sổ xem code
                lst_Code.Items.Add("void SelectionSort(int a[], int n) ");
                lst_Code.Items.Add("  {");
                lst_Code.Items.Add("    int max, i, j; ");
                lst_Code.Items.Add("    for (i = 0; i < n - 1; i++)");
                lst_Code.Items.Add("       {     ");
                lst_Code.Items.Add("         max = i;      ");
                lst_Code.Items.Add("         for (j = i + 1; j < n; j++)    ");
                lst_Code.Items.Add("           if (a[j] > a[max])     ");
                lst_Code.Items.Add("              max = j;      ");
                lst_Code.Items.Add("           if(max != i)     ");
                lst_Code.Items.Add("              Swap(a[max], a[i]);       ");
                lst_Code.Items.Add("       }          ");
                lst_Code.Items.Add("   }        ");
            }
        }
        private void btn_Thunho_Click(object sender, EventArgs e)
        {
            Kthuoc_Code--;
            lst_Code.Font = new System.Drawing.Font("Arial", Kthuoc_Code, FontStyle.Bold);
        }
        private void rad_Selectionsort_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
