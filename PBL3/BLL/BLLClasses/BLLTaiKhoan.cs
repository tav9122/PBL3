using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

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

        public void UpdateAndSendMatKhauMoiToMail(string email, string matKhauMoi)
        {
            BLLTaiKhoan.Instance.UpdateMatKhauNhanVien(BLLTaiKhoan.Instance.GetTenDangNhapNhanVien(BLLNhanVien.Instance.GetNhanVien(email).MaNhanVien), matKhauMoi);

            SmtpClient smtp = new SmtpClient();
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("taikhoan0142@outlook.com.vn", "Tạo và reset mật khẩu");
            mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.Body = "Mật khẩu mới của bạn là: " + matKhauMoi;
            mail.Subject = "Reset mật khẩu tài khoản.";
            mail.To.Add(email);

            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("taikhoan0142@outlook.com.vn", "1234567890Vu@");
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.Send(mail);
        }
    }
}
