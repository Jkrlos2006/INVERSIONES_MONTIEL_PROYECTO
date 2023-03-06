using IM_BACKEND._03_Repositorio;
using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND._02_Logica
{
    public class IngresoLogica
    {
        IngresoRepositorio repo = new IngresoRepositorio();


        public List<Ingreso> getAll()
        {
            //select * from ingreso
            return repo.getAll();
        }


        public Ingreso getById(int ingreso_id)
        {
            return repo.getById(ingreso_id);
        }

        public Ingreso create(Ingreso request)
        {

            //requeest id=0 // a
            return repo.create(request);

        }


        public Ingreso update(Ingreso request)
        {
            return repo.update(request);

        }

        public int delete(int ingreso_id)
        {
            return repo.delete(ingreso_id);
        }
    }
}
