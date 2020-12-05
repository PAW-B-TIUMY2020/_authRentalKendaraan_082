using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_082.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [DisplayName("ID")]

        public int IdPeminjaman { get; set; }
        [DisplayName("Tanggal Peminjaman")]
        [Required(ErrorMessage = "Tanggal wajib di isi")]
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        [Required(ErrorMessage = "Kendaraan wajib di isi")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Nama Customer wajib di isi")]
        public int? IdCustomer { get; set; }
        [DisplayName("Jaminan")]
        [Required(ErrorMessage = "Jaminan wajib di isi")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya wajib di isi")]
        public int? Biaya { get; set; }
        [DisplayName("Customer")]
        public Customer IdCustomerNavigation { get; set; }
        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
