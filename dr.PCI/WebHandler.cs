using System;
using System.Net;
using System.Windows.Forms;

namespace dr.PCI
{
    /// <summary>
    ///     Class WebHandler
    ///     provides methods to handle online communications
    /// </summary>
    class WebHandler
    {
        /// <summary>
        ///     Method for downloading the latest PCI database
        /// </summary>
        public static bool dwnldPCIDB(string dwnldAddress)
        {

            // Get environment variable with path to ProgramData
            string dwnldCurAppData = Environment.GetEnvironmentVariable("%ProgramData%");

            try
            {

                // Create new instance of WebClient
                WebClient dwnldHandler = new WebClient();
                dwnldHandler.DownloadFile(dwnldAddress, dwnldCurAppData + "curDB.dat");

                return true;

            } catch(Exception dwnldExc)
            {

                // Show error message
                MessageBox.Show("Could not download latest PCI database file from\n" + dwnldAddress + "\n\nException:\n" + dwnldExc.Message);

                return false;

            } // ~catch

        } // ~dwnldPCIDB()

    } // ~WebHandler
}
