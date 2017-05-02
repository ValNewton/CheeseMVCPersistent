using System.ComponentModel.DataAnnotations;


namespace CheeseMVC.ViewModels
{
    public class AddMenuViewModel
    {
        [Required(ErrorMessage = "New menu must have a name." )]
        [Display(Name ="Menu Name")]
        public string Name { get; set; }
    }
}
