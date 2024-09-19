using System.Diagnostics;

namespace BTQUANLYGIASUCWINFORM
{
    public partial class Form1 : Form
    {
        private Bo bo;
        private Cuu cuu;
        private De de;


        public Form1()
        {
            InitializeComponent();
        }

        // Hàm lấy số lượng gia súc từ TextBox
        private void LaySoLuongGiaSuc()
        {
            int soLuongBo = int.Parse(boTextBox.Text); // txtSoLuongBo là TextBox của số lượng bò
            int soLuongCuu = int.Parse(CuuTextBox.Text); // txtSoLuongCuu là TextBox của số lượng cừu
            int soLuongDe = int.Parse(dETextBox.Text); // txtSoLuongDe là TextBox của số lượng dê

            // Khởi tạo đối tượng các loài gia súc
            Bo bo = new Bo(soLuongBo);
            Cuu cuu = new Cuu(soLuongCuu);
            De de = new De(soLuongDe);

            // Lưu trữ đối tượng gia súc vào các biến toàn cục để sử dụng sau
            this.bo = bo;
            this.cuu = cuu;
            this.de = de;
        }

        // Hàm phát tiếng kêu của tất cả các loài gia súc
        // Hàm phát tiếng kêu của tất cả các loài gia súc và hiển thị trên cửa sổ Output
        private void PhatTiengKeuCuaTatCaGiaSuc()
        {
            int tong = bo.SoLuong + cuu.SoLuong + de.SoLuong;

            for (int i = 0; i < tong; i++)
            {
                if (i < bo.SoLuong)
                {
                    bo.PhatTiengKeu();
                }
                if (i < cuu.SoLuong)
                {
                    cuu.PhatTiengKeu();
                }
                if (i < de.SoLuong)
                {
                    de.PhatTiengKeu();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            LaySoLuongGiaSuc();
            MessageBox.Show("SuccessS", "Sus");
        }

        private void soundBtn_Click(object sender, EventArgs e)
        {
            PhatTiengKeuCuaTatCaGiaSuc();

        }

        // Hàm hiện thống kê số gia súc, số con sinh ra và tổng số lít sữa
        private void HienThiThongKe()
        {
            // Sinh con
            int soConBo = this.bo.SinhCon();
            int soConCuu = this.cuu.SinhCon();
            int soConDe = this.de.SinhCon();

            // Cho sữa
            int soLitSuaBo = this.bo.ChoSua();
            int soLitSuaCuu = this.cuu.ChoSua();
            int soLitSuaDe = this.de.ChoSua();

            // Tính tổng số lượng gia súc sau khi sinh con
            int tongSoGiaSucBo = this.bo.SoLuong + soConBo;
            int tongSoGiaSucCuu = this.cuu.SoLuong + soConCuu;
            int tongSoGiaSucDe = this.de.SoLuong + soConDe;

            // Ghi log thông tin thống kê lên cửa sổ Output
            Debug.WriteLine("=== Thống kê số lượng gia súc và sữa ===");
            Debug.WriteLine($"Tổng số gia súc:");
            Debug.WriteLine($"Bò: {tongSoGiaSucBo} con");
            Debug.WriteLine($"Cừu: {tongSoGiaSucCuu} con");
            Debug.WriteLine($"Dê: {tongSoGiaSucDe} con");

            Debug.WriteLine($"Số con sinh ra:");
            Debug.WriteLine($"Bò: {soConBo} con");
            Debug.WriteLine($"Cừu: {soConCuu} con");
            Debug.WriteLine($"Dê: {soConDe} con");

            Debug.WriteLine($"Tổng số lít sữa:");
            Debug.WriteLine($"Bò: {soLitSuaBo} lít");
            Debug.WriteLine($"Cừu: {soLitSuaCuu} lít");
            Debug.WriteLine($"Dê: {soLitSuaDe} lít");
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            HienThiThongKe();
        }
    }

}
