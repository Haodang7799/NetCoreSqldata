using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTutorial1.Models
{
    public class UserLogin
    {
        public string ID { set; get; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Vip { set; get; }
    }
}
