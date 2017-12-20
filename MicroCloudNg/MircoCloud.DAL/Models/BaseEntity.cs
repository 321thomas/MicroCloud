using System;
using System.Collections.Generic;
using System.Text;

namespace MircoCloud.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User AddedBy { get; set; }
        public User ModifiedBy { get; set; }
        public bool Deleted { get; set; }
        public User DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
