using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._03_Repositorio
{
    public class IngresoRepositorio
    {
        _DbContextInversionesMontiel db = new _DbContextInversionesMontiel();   

        public List<Ingreso> getAll()
        {
            //select * from ingreso
            return db.Ingresos.ToList();
        }


        public Ingreso getById(int ingreso_id)
        {
            return db.Ingresos.Find(ingreso_id);
        }

        public Ingreso create(Ingreso request)
        {

            //requeest id=0 // a
            db.Ingresos.Add(request);
            db.SaveChanges();
            return request;

        }


        public Ingreso update(Ingreso request)
        {
            db.Ingresos.Update(request);
            db.SaveChanges();
            return request;

        }

        public int delete(int ingreso_id)
        {
            Ingreso Ingreso = db.Ingresos.Find(ingreso_id);
            db.Ingresos.Remove(Ingreso);
            return db.SaveChanges();
        }


    }
            
}
