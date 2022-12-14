using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zadatak.Models;

namespace Zadatak.Dal
{
    interface IRepository
    {
        DataSet CreateDataSet(DBEntity dbEntity);
        DataSet ExecuteQuery(string query, string dbName, TextBox tbSuccess);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);

        
        void LogIn(string server, string username, string password);
    }
}