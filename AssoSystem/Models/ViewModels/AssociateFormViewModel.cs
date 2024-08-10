using AssoSystem.Models.Enums;

namespace AssoSystem.Models.ViewModels
{
    public class AssociateFormViewModel
    {
        public ICollection<Associate> Associate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
    }
}
