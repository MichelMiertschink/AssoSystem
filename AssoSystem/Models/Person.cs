using System.ComponentModel.DataAnnotations;

namespace AssoSystem.Models
{
    public class Person : MBase
    {
        public bool Type { get; set; }
        
        // Usar RegisterName para o nome/razão social quando PF/PJ
        [Display(Name = "Razão Social")]
        public string RegisterName { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string? FantasyName { get; set; }
        [Required]
        [Display(Name = "CNPJ/CPF")]
        public string CnpjCpf { get; set; }
    }
}
