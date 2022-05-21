using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Bảo hành")]
    public class BaoHanh
    {
        [Column("Số seri")]
        [Key]
        [Required]
        public int SoSeri { get; set; }
        
        [Column("Trạng thái")]
        public string TrangThai { get; set; }
        
        [Column("Ghi chú")]
        public string GhiChu { get; set; }

        [Column("Thời gian tạo phiếu bảo hành")]
        public DateTime ThoiGianTaoPhieuBaoHanh { get; set; }
        

        [ForeignKey("SoSeri")]
        public virtual VatPham VatPham { get; set; }
    }
}
