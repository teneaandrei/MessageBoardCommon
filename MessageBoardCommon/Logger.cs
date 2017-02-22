using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MessageBoardCommon
{
    public static class Logger
    {
        //private static readonly ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog _logError = log4net.LogManager.GetLogger("Error");
        private static readonly ILog _logWrongPassword = log4net.LogManager.GetLogger("Summary");
        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Error(string format, params object[] args)
        {
            _logError.Error(string.Format(format, args));
        }
        public static void Information(string format, params object[] args)
        {
            _logWrongPassword.Info(string.Format(format, args));
        }
    }
}
