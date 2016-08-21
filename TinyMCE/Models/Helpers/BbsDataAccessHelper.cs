using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TinyMCE.Models.Helpers
{
    public class BbsDataAccessHelper : BaseHelper
    {
        /// <summary>
        /// TinyMCE 를 이용한 게시판 테스트
        /// </summary>
        /// <param name="category"></param>
        /// <param name="subject"></param>
        /// <param name="contents"></param>
        /// <returns></returns>
        public int OnSubmit(string category, string subject, string contents)
        {
            string sql = string.Format("INSERT INTO BBS_TEST (CATEGORY, SUBJECT, CONTENTS) VALUES ('{0}','{1}','{2}')", category, subject, contents);
            int result = 0;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                command = new SqlCommand(sql, connection);
                result = command.ExecuteNonQuery();

                connection.Close();
            }

            return result;
        }
    }
}