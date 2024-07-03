using System.ComponentModel.DataAnnotations;

namespace Testing.Models
{
    public class Components
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int IdMainEquip { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание компонента")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Название компонента")]
        public int NomenclatureNumber { get; set; }

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
        public int Cost { get; set; }

        [Display(Name = "Название компонента")]
        public string Country { get; set; }
    }

}
