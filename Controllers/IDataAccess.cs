using Controllers.Utilidades;

namespace Controllers.DAO
{
    /*
     *  Interface DAO para todos los controladores de Entidad 
     *  que necesiten implementar las operaciones CRUD
     */
    public abstract class IDataAccess<T>
    {
        public UtilsProcedimientos Procedimientos { get; set; }

        protected IDataAccess()
        {
            Procedimientos = new UtilsProcedimientos();
        }

        public abstract int Create(T Entidad);
        public abstract T Get(int id);
        public abstract bool Update(T Entidad);
        public abstract bool Delete(int id);
    }
}
