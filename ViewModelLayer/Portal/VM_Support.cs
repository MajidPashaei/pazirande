using System.ComponentModel.DataAnnotations;

namespace ViewModelLayer.Portal
{
    public class VM_Support
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