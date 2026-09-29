using System;
using System.Data;
namespace webCinestar_WebForms_202620.Controllers
{
    public class CinestarController
    {
        Db db = new Db("cnCinestar");

        internal DataTable getCines()
        {
            db.Sentencia("sp_getCines");
            return db.getDataTable();
        }

        internal DataTable getPeliculas(string id)
        {
            db.Sentencia("sp_getPeliculas " + id);
            return db.getDataTable();
        }
    }
}