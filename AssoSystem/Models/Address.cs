using System.ComponentModel.DataAnnotations;

namespace AssoSystem.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CEP")]
        public int PostalCode { get; set; }

        [Display(Name = "Logradouro")]
        public string PublicPlace { get; set; }
        
        [Display(Name = "Nro")]
        public int NumberPlace { get; set; }
        
        [Display(Name = "Bairro")]
        public string Neigborhood { get; set; }
        
        [Display(Name = "Complemento")]
        public string? Addressomplement { get; set; }
        
        [Display(Name = "Cidade")]
        public string City { get; set; }
        
        [Display(Name = "Estado")]
        public string State { get; set; }
        
        public Address()
        {
        }

        public Address(int id, int postalCode, string publicPlace, int numberPlace, string neigborhood, string? addressomplement, string city, string state)
        {
            Id = id;
            PostalCode = postalCode;
            PublicPlace = publicPlace;
            NumberPlace = numberPlace;
            Neigborhood = neigborhood;
            Addressomplement = addressomplement;
            City = city;
            State = state;
        }
    }
}
