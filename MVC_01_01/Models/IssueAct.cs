using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using Dapper;

namespace MVC_01_01.Models
{
    public class IssueAct
    {
        public IEnumerable<Issue> GetIssue()
        {
            OracleConnection db = new OracleConnection(
                ConfigurationManager.ConnectionStrings["oraConnection"].ConnectionString);

            var _issue = db.Query<Issue>(@"select * from YYJ3887.issue");

            return _issue;
        }
    }
}