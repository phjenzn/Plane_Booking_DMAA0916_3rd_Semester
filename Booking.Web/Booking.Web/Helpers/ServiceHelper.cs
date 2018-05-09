﻿using Booking.Web.BookingAuthRemote;
using Booking.Web.BookingServiceRemote;
using System;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace Booking.Web.Helpers
{
    public class ServiceHelper
    {
        public static ServiceClient GetServiceClient()
        {
            string username = "Guest";
            string password = "Guest";

            if (AuthHelper.IsLoggedIn() && AuthHelper.CurrentUser.Email != null && AuthHelper.CurrentUser.Password != null)
            {
                    username = AuthHelper.CurrentUser.Email.ToLower();
                    password = AuthHelper.CurrentUser.Password;
            }

            ServiceClient client = new ServiceClient("WSHttpBinding_IService");
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }

        public static AuthClient GetAuthClient()
        {
            return new AuthClient("WSHttpBinding_IAuth");
        }
    }
}