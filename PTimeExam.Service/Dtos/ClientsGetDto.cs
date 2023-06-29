using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Service.Dtos
{
    public class ClientsGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Memhership_Card_Number { get; set; }
        public string Memhership_Card_Validity_Date { get; set; }
        public string Membership_Card_Number { get; set; }
        public string Rent_Date { get; set; }
        public string Return_Date { get; set; }
    }
}
