using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEng
{
    public class Helper
    {
        static public string GetQuotNoNumber(DateTime date)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            string NextNumber = settings["NextNumberQT"].Value ?? "0";
            string format = string.Format("PD-0{0}.{1}.{2}", NextNumber, date.Month, date.Year);

            int next = 0;
            int.TryParse(NextNumber, out next);
            next++;
            settings["NextNumberQT"].Value = next.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);


            return format;
        }
    }
}
