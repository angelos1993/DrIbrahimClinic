using System.Drawing;

namespace DrIbrahimClinic.Utility
{
    public static class Constants
    {
        public static Color ErrorColor = Color.HotPink;

        #region DB

        public static string DatabaseName = @"DrIbrahimClinic";
        //development
        public static string ServerName = @"ANGELOS-PC\SQLEXPRESS";
        //production
        //public static string ServerName = @"ASHRAF1\MSSQLSERVER2012";

        #endregion
    }
}