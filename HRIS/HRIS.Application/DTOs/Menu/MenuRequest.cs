using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.DTOs.Menu
{
    public class MenuRequest
    {
        public string userId { get; set; }
        public List<int>menus { get; set; }
    }
}
