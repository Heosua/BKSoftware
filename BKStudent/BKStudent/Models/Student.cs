using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BKStudent.Models
{
    public class Student { 
    
        public int      Id { get; set;} 
        public string   Name { get; set; }
        public string   Faculty { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public int      CPA { get; set; }
    }
}
