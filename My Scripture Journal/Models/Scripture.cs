using System.ComponentModel.DataAnnotations;

namespace My_Scripture_Journal.Models;

public class Scripture
{
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_Studied{ get; set; }
        public string? Add_Scripture { get; set; }
        public string? Inspired_Notes { get; set; }

}
