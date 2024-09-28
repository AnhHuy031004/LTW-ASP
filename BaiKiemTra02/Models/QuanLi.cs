using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaiKiemTra02.Models
{
    public class QuanLi
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống !!")]
        [Display(Name = "Thể Loại")]
        public string Name { get; set; }
      
        [Required(ErrorMessage = "không đúng định dạng ngày tháng năm !!")]
        [Display(Name = "Năm Nhập Học")]
        public DateTime Datejoin { get; set; }
       
        [Required(ErrorMessage = "không đúng định dạng ngày tháng năm !!")]
        [Display(Name = "Năm Ra Trường")]
        public DateTime Dateout { get; set; }
       public int SoLuongSinhVien { get; set; }
    }
}
