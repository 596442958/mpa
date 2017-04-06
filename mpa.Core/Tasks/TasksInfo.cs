using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpa.Tasks
{
    [Table("tbTasksInfo")]
    public class TasksInfo : FullAuditedEntity, IPassivable
    {
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public bool IsActive { get; set ; }
    }
}
