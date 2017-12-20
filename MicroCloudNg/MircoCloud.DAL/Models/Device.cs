using System;
using System.Collections.Generic;
using System.Text;

namespace MircoCloud.DAL.Models
{
    public class Device : BaseEntity
    {
        public Guid Key { get; set; }

        public User User { get; set; }
    }
}
