using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sftlareWebEx.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Logo")]
        [Required(ErrorMessage = "Cinema Logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage ="Cinema Name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
