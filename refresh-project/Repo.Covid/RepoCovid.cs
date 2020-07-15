using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Covid;
using Model.Covid;
using System.Data.Entity;

namespace Repo.Covid
{
    public class RepoCovid
    {
        public static List<VMCovid> GetListAll()
        {
            List<VMCovid> result = new List<VMCovid>();
            using (var db = new Model1())
            {
                var data = from x in db.TB_COVID
                           where x.is_delete == false
                           select new VMCovid
                           {
                               id = x.id,
                               email = x.email,
                               nama = x.nama,
                               npm = x.npm,
                               umur = x.umur,
                               jenis_kelamin = x.jenis_kelamin,
                               telepon = x.telepon,
                               alamat_saat_ini = x.alamat_saat_ini,
                               alamat_asal = x.alamat_asal,
                               posisi_saat_ini = x.posisi_saat_ini,
                               is_delete = x.is_delete,
                               create_by = "System",
                               create_date = DateTime.Now,
                               update_by = "System",
                               update_date = DateTime.Now

                           };
                result = data.ToList();
            }

            return result;
        }

        public static VMCovid GetDetailsById(int paramId)
        {
            VMCovid result = new VMCovid();
            try
            {
                using (Model1 db = new Model1())
                {
                    result = db.TB_COVID.Where(x => x.id == paramId).Select(a => new VMCovid

                    {
                        id = a.id,
                        email = a.email,
                        nama = a.nama,
                        npm = a.npm,
                        umur = a.umur,
                        jenis_kelamin = a.jenis_kelamin,
                        telepon = a.telepon,
                        alamat_saat_ini = a.alamat_saat_ini,
                        alamat_asal = a.alamat_asal,
                        posisi_saat_ini = a.posisi_saat_ini,
                        create_by = a.create_by,
                        create_date = DateTime.Now,
                        update_by = a.update_by,
                        update_date = DateTime.Now,
                        is_delete = a.is_delete
                    }).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static string savedata(VMCovid paramModel)
        {
            try
            {
                using (Model1 db = new Model1())
                {
                    TB_COVID data = new TB_COVID();

                    db.TB_COVID.Add(new TB_COVID
                    {

                        email = paramModel.email,
                        nama = paramModel.nama,
                        npm = paramModel.npm,
                        umur = paramModel.umur,
                        jenis_kelamin = paramModel.jenis_kelamin,
                        telepon = paramModel.telepon,
                        alamat_saat_ini = paramModel.alamat_saat_ini,
                        alamat_asal = paramModel.alamat_asal,
                        posisi_saat_ini = paramModel.posisi_saat_ini,
                        is_delete = false,

                        create_by = "System",
                        create_date = DateTime.Now,
                        update_by = "System",
                        update_date = DateTime.Now,
                    });
                    db.SaveChanges();

                }
                return "ok";

            }
            catch (Exception e)
            {

                return e.Message.ToString();
                throw;
            }

        }

        public static string HapusData(int IdCovid)
        {
            try
            {
                using (Model1 db = new Model1())
                {
                    TB_COVID datalama = db.TB_COVID.Where(a => a.id == IdCovid).FirstOrDefault();

                    datalama.is_delete = true;

                    db.SaveChanges();
                    return "ok";
                }

            }
            catch (Exception e)
            {
                return e.Message.ToString();
                throw;
            }
        }

        public static string edit(VMCovid paramModel)
        {
            try
            {
                using (Model1 db = new Model1())
                {

                    TB_COVID a = db.TB_COVID.Where(o => o.id == paramModel.id).FirstOrDefault();

                    
                    a.email = paramModel.email;
                    a.nama = paramModel.nama;
                    a.npm = paramModel.npm;
                    a.umur = paramModel.umur;
                    a.jenis_kelamin = paramModel.jenis_kelamin;
                    a.telepon = paramModel.telepon;
                    a.alamat_saat_ini = paramModel.alamat_saat_ini;
                    a.alamat_asal = paramModel.alamat_asal;
                    a.posisi_saat_ini = paramModel.posisi_saat_ini;
                    a.is_delete = paramModel.is_delete;

                    a.create_by = "System";
                    a.create_date = DateTime.Now;
                    a.update_by = "System";
                    a.update_date = DateTime.Now;

                    db.SaveChanges();
                    return "ok";
                }

            }
            catch (Exception e)
            {
                return e.Message.ToString();
                throw;
            }
        }



    }
}
