using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TinyMCE.Models.Helpers
{
    public class BaseHelper
    {
        public string connectionString = "server=127.0.0.1;uid=sa;password=ThsdhqmCGSY!!;database=TinyMCE";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
    }
}