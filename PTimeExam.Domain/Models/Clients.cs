using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Dal.Models
{
    public class Clients
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(300)]
        public string Membership_Card_Validity_Date{ get; set; }
        [Required]
        [MaxLength(200)]
        public string Memhership_Card_Number { get; set; }
        [Required]
        [MaxLength(200)]
        public DateTime Rent_Date { get; set; }
        [Required]
        [MaxLength(200)]
        public DateTime Return_Date { get; set; }
        [Required]
        [MaxLength(200)]
        public string { get; set; }
        public List<Movies> Movies { get; set; }
    }
}
