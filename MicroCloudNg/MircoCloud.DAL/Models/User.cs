using System;
using System.Collections.Generic;
using System.Text;

namespace MircoCloud.DAL.Models
{
    public class User: BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
