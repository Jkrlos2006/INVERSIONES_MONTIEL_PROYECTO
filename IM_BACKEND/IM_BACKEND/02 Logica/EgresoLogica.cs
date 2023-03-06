using IM_BACKEND._03_Repositorio;
using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._02_Logica
{
    public class EgresoLogica
    {
        EgresoRepositorio repo = new EgresoRepositorio();

        public List<Egreso> getAll()
        {
            return repo.getAll();
        }
                
        public Egreso getById(int salida_id)
        {            
            return repo.getById(salida_id);
        }
                
        public Egreso create(Egreso request)
        {           

            return repo.create(request);
        }
                
        public Egreso update(Egreso request)
        {
            return repo.update(request);
        }


        public int delete(int salida_id)
        {

            return repo.delete(salida_id);
        }

    }

}
