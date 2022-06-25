using System;
using System.Collections.Generic;
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

        public List<TaiKhoan> GetTaiKhoans()
        {
            return Model.Instance.TaiKhoans.ToList();
        }

        public TaiKhoan GetTaiKhoan(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(sp => sp.MaNhanVien == maNhanVien);
        }

        public List<string> GetMaTaiKhoans()
        {
            if (Model.Instance.TaiKhoans.Select(sp => sp.MaTaiKhoan).ToList() == null)
                return new List<string> { "TK0" };
            else
                return Model.Instance.TaiKhoans.Select(sp => sp.MaTaiKhoan).ToList();
        }

        public void UpdateTaiKhoanNhanVien(string maTaiKhoan, string tenDangNhap, string matKhau)
        {
            var taiKhoan = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaTaiKhoan == maTaiKhoan);
            if (tenDangNhap != "")
                taiKhoan.TenDangNhap = tenDangNhap;
            if (matKhau != "")
                taiKhoan.MatKhau = matKhau;
            Model.Instance.SaveChanges();
        }

        public string GenerateSixLengthRandomMatKhau()
        {
            string randomMatKhau = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomMatKhau += chars[rnd.Next(chars.Length)];
            }
            return randomMatKhau;
        }

        public void UpdateAndSendTaiKhoanInformationToMail(string email, string tenDangNhap, string matKhauMoi)
        {
            UpdateTaiKhoanNhanVien(GetTaiKhoan(BLLNhanVien.Instance.GetNhanVien(email).MaNhanVien).MaTaiKhoan, tenDangNhap, matKhauMoi);

            SmtpClient smtp = new SmtpClient();
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("taikhoan0142@outlook.com.vn", "Tạo và reset mật khẩu");
            mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.Body = "Tên đăng nhập: " + BLLTaiKhoan.Instance.GetTaiKhoan(BLLNhanVien.Instance.GetNhanVien(email).MaNhanVien).TenDangNhap + "<br/>Mật khẩu mới của bạn là: " + matKhauMoi;
            mail.Subject = "Reset mật khẩu tài khoản.";
            mail.To.Add(email);

            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("taikhoan0142@outlook.com.vn", "1234567890Vu@");
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.SendAsync(mail, null);
        }
    }
}
