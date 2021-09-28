using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLSV.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int Masv { get; set; }
        public string Tensv { get; set; }
        public DateTime Namsinhsv { get; set; }
        public string Lopsv { get; set; }
        public string SDTsv { get; set; }
    }
}