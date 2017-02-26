using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardCommon
{
    public static class Logger
    {
        private static readonly ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Error(string format, params object[] args)
        {
            _log.Error(string.Format(format, args));
        }
        public static void Information(string format, params object[] args)
        {
            _log.Info(string.Format(format, args));
        }
    }
}
