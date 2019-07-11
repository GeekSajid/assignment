using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A4AeroAssisgment.Models
{
    public class BusinessEntities
    {
        [Key]
        public Int64 BusinessId { get; set; }
        [StringLength(50)] 
        public string Code { get; set; }
        [EmailAddress] 
        public string Email { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        [StringLength(150)] 
        public string City { get; set; }
        [StringLength(150)] 
        public string State { get; set; }
        [StringLength(50)] 
        public string Zip { get; set; }
        [StringLength(150)] 
        public string Country { get; set; }
        [StringLength(50)] 
        public string Mobile { get; set; }
        [StringLength(50)] 
        public string Phone { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [StringLength(50)]
        [Display(Name = "Supplier")]
        public string ReferredBy { get; set; }
        public string Logo { get; set; }
        public int Status { get; set; }
        public decimal Balance { get; set; }
        [StringLength(50)]
        [Display(Name = "Login Url")]
        public string LoginUrl { get; set; }
        [StringLength(50)]
        [Display(Name = "Security Code")]
        public string SecurityCode { get; set; }
        [StringLength(50)]
        [Display(Name = "SMTP Server")]
        public string SMTPServer { get; set; }
        [Display(Name = "SMTP Port")]
        public int SMTPPort { get; set; }
        [StringLength(50)]
        [Display(Name = "SMTP Username")]
        public string SMTPUsername { get; set; }
        [StringLength(50)]
        [Display(Name = "SMTP Password")]
        public string SMTPPassword { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }
    }
}