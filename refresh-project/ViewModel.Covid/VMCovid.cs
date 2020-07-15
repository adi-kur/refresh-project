using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Covid
{
    public class VMCovid
    {
        public int id { get; set; }

        public string email { get; set; }


        public string nama { get; set; }

        public string npm { get; set; }

        public int umur { get; set; }

        public bool jenis_kelamin { get; set; }

        public string telepon { get; set; }


        public string alamat_saat_ini { get; set; }


        public string alamat_asal { get; set; }

        public string posisi_saat_ini { get; set; }

        public string create_by { get; set; }

        public DateTime? create_date { get; set; }

        public string update_by { get; set; }

        public DateTime? update_date { get; set; }

        public bool is_delete { get; set; }
    }
}
