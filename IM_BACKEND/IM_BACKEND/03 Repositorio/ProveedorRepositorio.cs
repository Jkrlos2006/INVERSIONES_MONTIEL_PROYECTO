using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._03_Repositorio
{
    public class ProveedorRepositorio
    {
        _DbContextInversionesMontiel db = new _DbContextInversionesMontiel();

        public List<Proveedor> getAll()
        {
            //select * from Proveedor
            return db.Proveedors.ToList();
        }


        //select * from Proveedor wherd id = id
        public Proveedor getById(int proveedor_id)
            
        {
            //select * from Proveedor
            return db.Proveedors.Find(proveedor_id);
        }


        //insert into Proveedor
        //select * from Proveedor wherd id = id
        public Proveedor create(Proveedor request)
        {
            //request.id = 0 // 4
            db.Proveedors.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into Proveedor
        //select * from Proveedor wherd id = id
        public Proveedor update(Proveedor request)
        {
            //request.id = 0 // 4
            db.Proveedors.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int proveedor_id)
        {

            //select * from Proveedor wherd id = id
            Proveedor Proveedor = db.Proveedors.Find(proveedor_id);
            //request.id = 0 // 4
            db.Proveedors.Remove(Proveedor);
            return db.SaveChanges();
        }



    }
}
