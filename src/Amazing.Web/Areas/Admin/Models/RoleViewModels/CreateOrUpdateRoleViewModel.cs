using System;
using System.ComponentModel.DataAnnotations;

namespace Amazing.Web.Areas.Admin.Models.RoleViewModels
{
    public class CreateOrUpdateRoleViewModel
    {
        public Guid ? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
