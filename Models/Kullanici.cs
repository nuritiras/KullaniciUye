using System;
using System.ComponentModel.DataAnnotations;

namespace KullaniciUye.Models
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim alanı boş geçilemez.")]
        [MinLength(3, ErrorMessage = "İsim alanı en az 3 karakter olmalıdır.")]
        [MaxLength(30, ErrorMessage = "İsim alanı en fazla 30 karakter olmalıdır.")]
        [StringLength(30)]
        [Display(Name = "İsim")]
        [DataType(DataType.Text)]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        [MinLength(3, ErrorMessage = "Soyad alanı en az 3 karakter olmalıdır.")]
        [MaxLength(30, ErrorMessage = "Soyad alanı en fazla 30 karakter olmalıdır.")]
        [Display(Name = "Soyisim")]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Email alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez.")]
        [MinLength(6, ErrorMessage = "Şifre alanı en az 6 karakter olmalıdır.")]
        [MaxLength(15, ErrorMessage = "Şifre alanı en fazla 15 karakter olmalıdır.")]
        [Display(Name = "Şifre")] 
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,15}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.")]
        [DataType(DataType.Password)]
        [StringLength(15)]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı alanı boş geçilemez.")]
        [Compare("Sifre", ErrorMessage = "Şifreler uyuşmuyor.")]
        [Display(Name = "Şifre Tekrarı")]
        [DataType(DataType.Password)]
        [StringLength(15)]
        public string SifreTekrar { get; set; }

        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}