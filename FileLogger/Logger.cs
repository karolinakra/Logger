using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileLogger
{
    public class Logger
    {
        private readonly string fileName;
        //const string fileName2 = "stala";
        private static string directory = System.Configuration.ConfigurationManager.AppSettings["dir"];

        

        public Logger()
        {
            



        }
        public Logger(string fileName)
        {
            this.fileName = fileName;
            setDirectory();
        }

        public void Log(string text)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            //File.AppendAllLines(Path.Combine(directory, fileName), new string [] { text});
            text = $"{Environment.NewLine}  Data: {DateTime.Now} Informacja: {text} {Environment.NewLine}";
            File.AppendAllText(Path.Combine(directory, fileName), text);

        }

        private void setDirectory()
        {
            try
            {
                directory = System.Configuration.ConfigurationManager.AppSettings["dir"];
                //System.Configuration.ConfigurationManager.OpenExeConfiguration("~FileLogger.dll.config");
                //directory = File.AppSettings["dir"].ToString();
            }
            catch (FileNotFoundException fnfe)
            {


            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
