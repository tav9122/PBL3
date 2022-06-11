using System.Linq;

namespace PBL3
{
    internal class BLLTaiKhoan
    {
        private static BLLTaiKhoan instance;
        public static BLLTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLTaiKhoan();
                return instance;
            }
        }

        public string GetTenDangNhapNhanVien(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).TenDangNhap;
        }

        public string GetMatKhauNhanVien(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).MatKhau;
        }

        public void UpdateMatKhauNhanVien(string tenDangNhap, string matKhau)
        {
            Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap).MatKhau = matKhau;
            Model.Instance.SaveChanges();
        }
    }
}
