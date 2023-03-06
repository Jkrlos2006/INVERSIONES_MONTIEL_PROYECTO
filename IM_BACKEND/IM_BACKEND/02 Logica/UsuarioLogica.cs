using IM_BACKEND._03_Repositorio;
using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._02_Logica
{
    public class UsuarioLogica
    {
        UsuarioRepositorio repo = new UsuarioRepositorio();

        public List<Usuario> getAll()
        {
            //select * from Usuario
            return repo.getAll();
        }


        //select * from Usuario wherd id = id
        public Usuario getById(int id)
        {
            //select * from Usuario
            return repo.getById(id);
        }


        //insert into Usuario
        //select * from Usuario wherd id = id
        public Usuario create(Usuario request)
        {
            //request.id = 0 // 4

            return repo.create(request);
        }

        //update into Usuario
        //select * from Usuario wherd id = id
        public Usuario update(Usuario request)
        {
            return repo.update(request);
        }


        public int delete(int id)
        {

            return repo.delete(id);
        }

    }

}
