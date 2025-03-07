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
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        [MinLength(3, ErrorMessage = "Soyad alanı en az 3 karakter olmalıdır.")]
        [MaxLength(30, ErrorMessage = "Soyad alanı en fazla 30 karakter olmalıdır.")]
        [Display(Name = "Soyad")]
        [StringLength(30)]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Email alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez.")]
        [MinLength(6, ErrorMessage = "Şifre alanı en az 6 karakter olmalıdır.")]
        [MaxLength(15, ErrorMessage = "Şifre alanı en fazla 15 karakter olmalıdır.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]   
        [StringLength(15)]
        public string Sifre { get; set; }

        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}