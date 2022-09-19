using System.ComponentModel.DataAnnotations;

namespace PartyInvitesSequel.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naam moet ingevuld zijn.")]
        public string? Name { get; set; }
        [EmailAddress(ErrorMessage = "Emailadres moet in de juiste format")]
        [Required(ErrorMessage = "Emailadres moet ingevuld zijn.")]
        public string? Email { get; set; } 
        [Required(ErrorMessage ="Telefoonnummer moet ingevuld zijn")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Moet aangegeven worden of men komt.")]
        public bool? WillAttend { get; set; }
    }
}
