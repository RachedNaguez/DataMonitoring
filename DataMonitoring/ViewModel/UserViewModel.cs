using System.Collections.Generic;

namespace DataMonitoring.ViewModel
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Departement { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}