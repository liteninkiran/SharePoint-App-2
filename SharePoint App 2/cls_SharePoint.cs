using System;
using System.Security;
using Microsoft.SharePoint.Client;

namespace SharePoint_App_2
{
    class cls_SharePoint
    {
        public static ClientContext GetClient(string siteUrl, string userName, string password, ref string errorMessage)
        {
            // Create a Secure String for password
            SecureString secPassword = securePassword(password);

            // Initialise an empty object
            ClientContext clientContext = null;

            // Set the Client Context
            try
            {
                clientContext = new ClientContext(siteUrl);

                // Enter credentials
                clientContext.Credentials = new SharePointOnlineCredentials(userName, secPassword);

                // Try and load site
                clientContext.Load(clientContext.Web);
                clientContext.ExecuteQuery();
            }
            catch (Exception e)
            {
                clientContext = null;
                errorMessage = e.Message;
            }

            // Return the object
            return clientContext;
        }

        public static ClientContext GetClient(string siteUrl, string userName, string password)
        {
            string errorMessage = "";
            return GetClient(siteUrl, userName, password, ref errorMessage);
        }

        public static SecureString securePassword(string password)
        {
            // Create a Secure String for password
            SecureString secPassword = new SecureString();

            // Append characters of password to Secure String
            foreach (char c in password.ToCharArray())
            {
                secPassword.AppendChar(c);
            }

            return secPassword;
        }
    }
}
