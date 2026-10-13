using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_7.Models
{
    public class Feedback
    {
        public string EnrollmentNo {  get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
    }
}