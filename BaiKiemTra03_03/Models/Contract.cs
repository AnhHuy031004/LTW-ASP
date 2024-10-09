using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống tên hợp đồng !!")]
        [Display(Name = "Tên Hợp Đồng")]
        public string Name { get; set; }
        [Required(ErrorMessage = "không đúng định dạng ngày tháng năm !!")]
        [Display(Name = "Ngày Kí Kết")]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Không được để trống khách hàng !!")]
        [Display(Name = "Khách Hàng")]
        public string Customer { get; set; }
        [Required(ErrorMessage = "Không được để trống giá trị!!")]
        [Display(Name = "Giá trị hợp đồng")]
        public decimal value { get; set; }
    }
}
