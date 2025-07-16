using System;
using System.ComponentModel.DataAnnotations;

namespace UnitTest_TOP_OCR
{
    public class Test_Model
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}