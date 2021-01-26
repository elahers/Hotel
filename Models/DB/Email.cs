using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models.DB
{
    public class Email
    {

        public int Id { get; set; }
        public string EmailSend { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public string Port { get; set; }
        public string Smtp { get; set; }

    }
}
