using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Dal.Models
{
    public class Movies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Director { get; set; }
        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Year { get; set; }
        [Required]
        [MaxLength(50)]
        public decimal Rating { get; set; }
        [MaxLength(50)]

        public int Box_Office_Earnings { get; set; }
        [MaxLength(50)]

        [ForeignKey("ClientsId")]
        public int ClientsId { get; set; }
        public Clients Clients { get; set; }
    }
}
