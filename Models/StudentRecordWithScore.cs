using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Models
{
    internal class StudentRecordWithScore
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public char EnglishGrade { get; set; }
        public char MathsGrade { get; set; }
        public int EnglishScore { get; set; }
        public int MathsScore { get; set; }
    }

}