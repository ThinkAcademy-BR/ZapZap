using System.ComponentModel.DataAnnotations;

namespace ThinkAcademy.ZapZap.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}