using System.ComponentModel.DataAnnotations.Schema;

namespace BEE.Models
{
    public abstract class BaseEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string createdAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string updatedAt { get; set; }
    }
}