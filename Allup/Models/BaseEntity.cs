using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedAt { get; set; }
        public Nullable<DateTime> CreatedBy { get; set; }

        public string UpdatedAt { get; set; }
        public Nullable<DateTime> UpdatedBy { get; set; }

        public string DeletedAt { get; set; }
        public Nullable<DateTime> DeletedBy { get; set; }

    }
}
