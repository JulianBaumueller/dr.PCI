using System;
using System.IO;
using System.Windows.Forms;

namespace dr.PCI
{
    /// <summary>
    /// Provides default methods for running the environment
    /// </summary>
    class DrPCI
    {
        public static bool loadEnv()
        {

            // Get environment variable with path to ProgramData
            string drpciCurProgData = Environment.GetEnvironmentVariable("%ProgramData%");

            if (!Directory.Exists(drpciCurProgData + "\\drPCI"))
            {
                try
                {
                    Directory.CreateDirectory(drpciCurProgData + "\\drPCI");

                    return true;

                } catch(Exception drpciCrProgDataDirExc)
                {
                    MessageBox.Show("Could not create directory in " + drpciCurProgData + ".\n\nException:\n" + drpciCrProgDataDirExc.Message);

                    return false;

                } // ~catch
            } // ~if


        } // ~loadEnv()
    } // ~DrPCI
} // ~_namespace_
