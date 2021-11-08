using System.ComponentModel.DataAnnotations;

namespace WebAppAspNetMvcPdf.Models
{
    public enum SettingType
    {
        [Display(Name = "Пароль")]
        Password = 1,
    }
}