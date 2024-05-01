using AssoSystem.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssoSystem.Models
{
    public class Associate
    {
    
        [Key]
        public int Id { get; set; }
        [Display(Name ="Tipo")]
        public bool Type { get; set; }
        // Usar para o nome quando PF
        [Display(Name ="Razão Social")]
        public string CorporateReason { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string? FantasyName { get; set; }
        [Display(Name = "CNPJ/CPF")]
        public string CnpjCpf { get; set; }
        // Usar para o RG quando PF
        [Display(Name = "Ins. Estadual")]
        public string StateNumber { get; set; }
        // Usar para data de fundação da empresa / expedição do RG
        [Display(Name = "Dt.Criação")]
        public DateOnly ShippingDate { get; set; }

        // Endereço
        public Address Address { get; set; }
        public int AddressID { get; set; }
        
        // Dados apenas para PF
        [Display(Name = "Gênero")]
        public bool? Gender{ get; set; }
        [Display(Name = "Estado Civil")]
        public MaritalStatus? MaritalStatus { get; set; }
        public int MaritalStatusId { get; set; }
        [Display(Name = "Dt. Nascimento")]
        public DateOnly? BirthDate { get; set; }
        [Display(Name = "Nome da mãe")]
        public string? MothersName { get; set; }
        [Display(Name = "Nome da esposa")]
        public string? WifeName { get; set; }
        [Display(Name = "Dt. inclusão")]
        public DateOnly? IncludeDate { get; set; }
        [Display(Name = "Dt. de Saída")]
        public DateOnly? ExitDate { get; set; }

        public Associate()
        {
        }

        public Associate(int id, bool type, string corporateReason, string? fantasyName,
            string cnpjCpf, string stateNumber, DateOnly shippingDate, Address address,
            bool? gender, MaritalStatus? maritalStatus, DateOnly? birthDate, string? mothersName,
            string? wifeName, DateOnly? includeDate, DateOnly? exitDate)
        {
            Id = id;
            Type = type;
            CorporateReason = corporateReason;
            FantasyName = fantasyName;
            CnpjCpf = cnpjCpf;
            StateNumber = stateNumber;
            ShippingDate = shippingDate;
            Address = address;
            Gender = gender;
            MaritalStatus = maritalStatus;
            BirthDate = birthDate;
            MothersName = mothersName;
            WifeName = wifeName;
            IncludeDate = includeDate;
            ExitDate = exitDate;
        }
    }
}
