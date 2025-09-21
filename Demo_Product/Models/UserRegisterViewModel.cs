using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="lütfen isim değeri giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage ="lütfen soyisim değeri giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="lütfen kullanıcı adı değeri giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="lütfen mail adresi girirniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage ="lütfen şifre değeri giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage ="lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}
