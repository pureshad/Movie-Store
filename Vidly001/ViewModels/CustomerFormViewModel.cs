using System.Collections.Generic;
using Vidly001.Models.Entity;

namespace Vidly001.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}