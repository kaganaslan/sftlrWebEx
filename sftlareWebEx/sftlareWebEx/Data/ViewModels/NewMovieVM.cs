using sftlareWebEx.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sftlareWebEx.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        
        public string Name { get; set; }

        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Movie Poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "escription is required")]
        public string Description { get; set; }

        [Display(Name = "Price in TL")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie Stard Date")]
        [Required(ErrorMessage = "Stard Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date in TL")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie Category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships 

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actors is required")]

        public List<int> ActorIds { get; set; }

        [Display(Name = "Select cinema(s)")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select producer(s)")]
        [Required(ErrorMessage = "Movie producer is required")]

        public int ProducerId { get; set; }
    }
}
