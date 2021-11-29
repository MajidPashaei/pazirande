using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities.Portal
{
    public class Tbl_ClassCodes
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
    }
}