using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AtndTrackBlazorApp.Shared.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int RoleId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress] 
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ClientUrl { get; set; }
    }
}
