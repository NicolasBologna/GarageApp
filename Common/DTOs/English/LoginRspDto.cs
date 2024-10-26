using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.English
{
    public class LoginRspDto
    {
        public int Status { get; set; }
        public string Mensaje { get; set; }
        public string Token { get; set; }
    }
}
