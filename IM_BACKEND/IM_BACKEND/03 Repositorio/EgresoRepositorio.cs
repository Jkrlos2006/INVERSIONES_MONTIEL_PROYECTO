using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._03_Repositorio
{
    public class EgresoRepositorio
    {
        _DbContextInversionesMontiel db = new _DbContextInversionesMontiel();

        public List<Egreso> getAll()
        {
            return db.Egresos.ToList();
        }
                
        public Egreso getById(int salida_id)
            
        {            
            return db.Egresos.Find(salida_id);
        }
        
        public Egreso create(Egreso request)
        {
            db.Egresos.Add(request);
            db.SaveChanges();
            return request;
        }
                
        public Egreso update(Egreso request)
        {            
            db.Egresos.Update(request);
            db.SaveChanges();
            return request;
        }

        public int delete(int salida_id)
        {

            Egreso Egreso = db.Egresos.Find(salida_id);
            
            db.Egresos.Remove(Egreso);
            return db.SaveChanges();
        }



    }
}
