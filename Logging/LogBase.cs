using NLog;

namespace NewsKeeper.Logging
{
    public class LogBase
    {
        #region Properties
        private Logger Log { get; }
        #endregion

        #region Construction / Initalization /Deconstruction
        public LogBase()
        {
            Log = LogManager.GetLogger(GetType().FullName);
        }
        #endregion

        #region Public implementations
        public virtual void Trace(string message, object[] param = null)
        {
            Log.Trace(message, param);
        }
        public virtual void Debug(string message, object[] param = null)
        {
            Log.Debug(message,param);
        }

        public virtual void Info(string message, object[] param = null)
        {
            Log.Info(message, param);
        }

        public virtual void Error(string message, object[] param = null)
        {
            Log.Error(message, param);
        }
        public virtual void Fatal(string message, object[] param = null)
        {
            Log.Fatal(message, param);
        }
        public virtual void Warn(string message, object[] param = null)
        {
            Log.Warn(message, param);
        }
        #endregion
    }
}
