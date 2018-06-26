using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Customer Name"), StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}