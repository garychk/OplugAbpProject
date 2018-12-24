using System.ComponentModel.DataAnnotations;

namespace OplugAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}