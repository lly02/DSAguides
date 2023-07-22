using System.ComponentModel.DataAnnotations;

namespace DSAguides.Models.DataStructures.Array.Model
{
    public class NewArrayModel
    {
        [Required]
        [RegularExpression(@"^(\d+,?){0,10}(?<!,)$", ErrorMessage = "Please only input up to 10 integers in this format ( int, int, int... )")]
        public string? NewArray { get; set; }
    }
}
