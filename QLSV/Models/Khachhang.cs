using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLSV.Models
{
    [Table("KHACHHANG")]
    public class Khachhang
    {
        [Key]
        public string makh { get; set; }
        public string tenkh {get; set; }
        public DateTime sinhngay { get; set; }
        public string điachi { get; set; }
        public int sodienthoai { get; }
    }
}