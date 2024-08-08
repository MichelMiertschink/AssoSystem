using AssoSystem.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssoSystem.Models
{
    public class Associate : Person
    {

        // Usar para o RG quando PF
        
        [Display(Name = "IE/RG")]
        public string StateNumber { get; set; }
        // Usar para data de fundação da empresa / expedição do RG
        [Display(Name = "Dt.Criação")]
        [DataType(DataType.DateTime)]
        public DateOnly BornDate { get; set; }

        // Endereço
        [Display(Name = "Logradouro")]
        public string PublicPlace { get; set; }

        [Display(Name = "Nro")]
        public int NumberPlace { get; set; }

        [Display(Name = "Bairro")]
        public string Neigborhood { get; set; }

        [Display(Name = "Complemento")]
        public string? AddressComplement { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "CEP")]
        public int PostalCode { get; set; }

        // Dados apenas para PF
        [Display(Name = "Gênero")]
        public bool? Gender{ get; set; }
        [Display(Name = "Estado Civil")]
        public MaritalStatus? MaritalStatus { get; set; }
        [Display(Name = "Estado Civil")]
        public int MaritalStatusId { get; set; }
        [Display(Name = "Dt. Nascimento")]
        [DataType(DataType.Date)]
        public DateOnly? BirthDate { get; set; }
        [Display(Name = "Nome da mãe")]
        public string? MothersName { get; set; }
        [Display(Name = "Nome da esposa")]
        public string? WifeName { get; set; }
        [Display(Name = "Dt. inclusão")]
        [DataType(DataType.DateTime)]
        public DateOnly? IncludeDate { get; set; }
        [Display(Name = "Dt. de Saída")]
        [DataType(DataType.DateTime)]
        public DateOnly? ExitDate { get; set; }

        public Associate()
        {
        }
    }
}
