using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._03_Repositorio
{
    public class ProductoRepositorio
    {
        _DbContextInversionesMontiel db = new _DbContextInversionesMontiel();

        public List<Producto> getAll()
        {
            //select * from Producto
            return db.Productos.ToList();
        }


        //select * from Producto wherd id = id
        public Producto getById(int id)
        {
            //select * from Producto
            return db.Productos.Find(id);
        }


        //insert into Producto
        //select * from Producto wherd id = id
        public Producto create(Producto request)
        {
            //request.id = 0 // 4
            db.Productos.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into Producto
        //select * from Producto wherd id = id
        public Producto update(Producto request)
        {
            //request.id = 0 // 4
            db.Productos.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from Producto wherd id = id
            Producto Producto = db.Productos.Find(id);
            //request.id = 0 // 4
            db.Productos.Remove(Producto);
            return db.SaveChanges();
        }



    }
}
