using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductTestHome.Entities
{
    public class Product
    {
        [Key]
        [Required]
        [Display(Name = "Mã số")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tên Sản Phẩm")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Giá")]
        public string price { get; set; }

        [Required]
        [Display(Name = "Hình ảnh")]
        public string photo { get; set; }

        [Required]
        [Display(Name= "Ngày")]
        public DateTime datePro { get; set; }
    }
}
