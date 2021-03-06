﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;

namespace Booking.DB
{
    public class DataAccess
    {
        private static DataAccess instance = null;

        private DataAccess()
        {

        }

        public static DataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccess();
                }
                return instance;
            }
        }

        public string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return "Server=;Integrated Security=false; MultipleActiveResultSets=true; Encrypt=True; TrustServerCertificate=True";
        }

    }
}
