using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Tbl_User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public string NationalCode { get; set; }
        public string Avatar { get; set; }
        public string Code { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RCode { get; set; }
    }
}