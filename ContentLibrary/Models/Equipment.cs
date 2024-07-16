using System.ComponentModel.DataAnnotations;

namespace Testing.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int SerialNumber { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int IdSupplier {  get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int NumberContract { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int InventoryNumber {  get; set; }
    }
}
