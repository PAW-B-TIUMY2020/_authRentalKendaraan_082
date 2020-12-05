using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_082.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage ="Nama Customer wajib di isi")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$",ErrorMessage ="NIK hanya boleh di isi angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib di isi")]
        public string Alamat { get; set; }
        [MinLength(11,ErrorMessage ="No HP tidak boleh kurang dari 10")]
        [MaxLength(13,ErrorMessage ="No HP tidak boleh lebih dari 13")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
