using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._03_Repositorio
{
    public class ClienteRepositorio
    {
        _DbContextInversionesMontiel db = new _DbContextInversionesMontiel();

        public List<Cliente> getAll()
        {
            //select * from Cliente
            return db.Clientes.ToList();
        }


        //select * from Cliente wherd id = id
        public Cliente getById(int id)
        {
            //select * from Cliente
            return db.Clientes.Find(id);
        }


        //insert into Cliente
        //select * from Cliente wherd id = id
        public Cliente create(Cliente request)
        {
            //request.id = 0 // 4
            db.Clientes.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into Cliente
        //select * from Cliente wherd id = id
        public Cliente update(Cliente request)
        {
            //request.id = 0 // 4
            db.Clientes.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from Cliente wherd id = id
            Cliente Cliente = db.Clientes.Find(id);
            //request.id = 0 // 4
            db.Clientes.Remove(Cliente);
            return db.SaveChanges();
        }



    }
}
