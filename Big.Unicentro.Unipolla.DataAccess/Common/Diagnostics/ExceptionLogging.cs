using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics
{
    public class ExceptionLogging
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogException(System.Exception ex)
        {
            logger.Error(string.Format(
                "{0}\n\r{1}"
                , ex.Message
                , ex.StackTrace));
        }

        public static void LogInfo(string info)
        {
            logger.Info(string.Format(
                "{0}\n\r"
                , info));
        }

        public static void LogWarn(string info)
        {
            logger.Warn(string.Format(
                "{0}\n\r"
                , info));
        }

        public static void LogTrace(string info)
        {
            logger.Trace(string.Format(
                "{0}\n\r"
                , info));
        }
    }
}
