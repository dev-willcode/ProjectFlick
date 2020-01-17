﻿namespace FlickLib.DAO
{
    /*
     *  Interface DAO para todos los controladores de Entidad 
     *  que necesiten implementar las operaciones CRUD
     */
    interface IDataAccess<T>
    {
        int Create(T Entidad);
        T Get(int id);
        bool Update(int id, T Entidad);
        bool Delete(int id);
    }
}