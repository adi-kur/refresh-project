namespace Model.Covid
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COVID
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string nama { get; set; }

        [Required]
        [StringLength(8)]
        public string npm { get; set; }

        public int umur { get; set; }

        public bool jenis_kelamin { get; set; }

        [Required]
        [StringLength(13)]
        public string telepon { get; set; }

        [Required]
        [StringLength(50)]
        public string alamat_saat_ini { get; set; }

        [Required]
        [StringLength(50)]
        public string alamat_asal { get; set; }

        [Required]
        [StringLength(50)]
        public string posisi_saat_ini { get; set; }

        public string create_by { get; set; }

        public DateTime? create_date { get; set; }

        public string update_by { get; set; }

        public DateTime? update_date { get; set; }

        public bool is_delete { get; set; }
    }
}
