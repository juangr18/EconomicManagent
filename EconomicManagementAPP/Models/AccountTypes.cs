using EconomicManagementAPP.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EconomicManagementAPP.Models
{
    public class AccountTypes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        [Remote(action: "VerificaryAccountType", controller: "AccountTypes")]//Activamos la validacion se dispara peticion http hacia el back
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int OrderAccount { get; set; }
    }
}
