using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Service.Dtos
{
    public class MoviesPostPutDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public decimal Rating { get; set; }
        public string Box_Office_Earnings { get; set; }
    }
}
