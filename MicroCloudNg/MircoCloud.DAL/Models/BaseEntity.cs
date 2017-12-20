using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MircoCloud.DAL.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ApplicationUser AddedBy { get; set; }
        public ApplicationUser ModifiedBy { get; set; }
        public bool Deleted { get; set; }
        public ApplicationUser DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
