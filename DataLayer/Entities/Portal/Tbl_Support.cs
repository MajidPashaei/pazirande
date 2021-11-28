using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities.Portal
{
    public class Tbl_Support
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string To { get; set; }
        public string Status { get; set; }
        
        
    }
}