using System.ComponentModel.DataAnnotations;

namespace GutenBerg.MrGut.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}