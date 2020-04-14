using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp.Model
{
    public class Diagnostic
    {
        [Key]
        public int Id { get; set; }
        public int Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
