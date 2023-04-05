using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YallaHelpWeb.Shared
{
	public class BaseResponse
	{
        public string? Meassage { get; set; }
        public string? Code { get; set; }
        public dynamic? Data { get; set; }
    }
}
