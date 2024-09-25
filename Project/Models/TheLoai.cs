using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Không được để trống thể loại !!")]
        [Display(Name="Thể Loại")]
        public string Name { get; set; }
        [Required(ErrorMessage ="không đúng định dạng ngày tháng năm !!")]
        [Display(Name="Ngày Tạo")]
        public DateTime DateCreated { get; set; }

    }

}
