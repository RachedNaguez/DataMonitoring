using System.ComponentModel.DataAnnotations;

namespace DataMonitoring.ViewModel
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}