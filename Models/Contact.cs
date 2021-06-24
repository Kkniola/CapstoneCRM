using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Contact
    {

        [Display(Name = "Contact ID")] 
        public int ContactID { get; set; }
        
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [Display(Name = "Suffix")] 
        public string Suffix { get; set; }
        [Display(Name = "Prefix")] 
        public string Prefix { get; set; }
        [Display(Name = "Pronouns")] 
        public string Pronouns { get; set; }
        [Display(Name = "Title")] 
        public string Title { get; set; }
        [Display(Name = "Role ID")] 
        public int RoleID { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        [Display(Name = "Email")] 
        public string Email { get; set; }
        [Display(Name = "Address 1")] 
        public string HomeAddress1 { get; set; }
        [Display(Name = "Address 2")] 
        public string HomeAddress2 { get; set; }

        [Display(Name = "City")] 
        public string HomeCity { get; set; }
        [Display(Name = "State")] 
        public string StateID { get; set; }
        [Display(Name = "Zip Code")] 
        public string HomeZipCode { get; set; }
        [Display(Name = "Country")] 
        public string Country { get; set; }
        [Display(Name = "Home Phone")] 
        public string HomePhone { get; set; }
        [Display(Name = "Cell Phone")] 
        public string CellPhone { get; set; }
        [Display(Name = "Work Phone")] 
        public string WorkPhone { get; set; }
        [Display(Name = "LinkedIn")] 
        public string LinkedIn { get; set; }
        [Display(Name = "Facebook")] 
        public string Facebook { get; set; }
        [Display(Name = "Preferred Contact Method")] 
        public string ContactMethod { get; set; }
        [Display(Name = "Emergency Contact")] 
        public string EmergencyContactName { get; set; }
        [Display(Name = "Emergency Contact Number")] 
        public string EmergencyContactNumber { get; set; }
        [Display(Name = "Location ID")] 
        public int LocationID { get; set; }
        [Display(Name = "Source ID")] 
        public string SourceID { get; set; }
        [Display(Name = "Created By")] 
        public string CreatedBy { get; set; }
        [Display(Name = "Date Created")] 
        
        public DateTime DateCreated { get; set; }
        
        [Display(Name = "Last Date Contacted")] 
        public DateTime LastDateContacted { get; set; }
        [Display(Name = "Contact Type ID")] 
        public int ContactTypeID { get; set; }
        [Display(Name = "Comment")] 
        public string Comment { get; set; }



        //navigation property

        public Role Role { get; set; }
        public Source Source { get; set; }

        public Location Location { get; set; }

        public State State { get; set; }
        //public Activity Activity { get; set; }


        public ICollection<Activity> Activities { get; set; }
    }
}
