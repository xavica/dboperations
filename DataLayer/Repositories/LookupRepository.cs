using Dapper;
using DataLayer.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataLayer
{
    public class LookupRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["contactsDB"].ConnectionString);

        public List<State> GetStates()
        {
            return this.db.Query<State>("SELECT Id, StateName FROM States ORDER BY StateName").ToList();
        }
    }
}
