using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamirSolankiBooks.DataAccess.Repository.IRepository
{
    interface IPS_Call :IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters)
    }
}
