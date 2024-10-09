using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống Tên Khách hàng !!")]
        [Display(Name = "Tên Khách Hàng")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống địa chỉ !!")]
        [Display(Name = "Đại Chỉ")]
        public string address { get; set; }
        [Required(ErrorMessage = "Không được để trống Số điện thoại!!")]
        [Display(Name = "Số Điện Thoại")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Không được để trống Email!!")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
