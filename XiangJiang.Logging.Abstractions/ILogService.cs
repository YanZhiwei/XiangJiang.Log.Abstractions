using System;

namespace XiangJiang.Logging.Abstractions
{
    public interface ILogService : IDisposable
    {
        #region Methods

        /// <summary>
        ///     Debug记录
        /// </summary>
        /// <param name="message">日志信息</param>
        void Debug(string message);

        /// <summary>
        ///     Error记录
        /// </summary>
        /// <param name="message">日志信息</param>
        void Error(string message);

        /// <summary>
        ///     Error记录
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="ex">异常信息</param>
        void Error(string message, Exception ex);

        /// <summary>
        ///     Fatal记录
        /// </summary>
        /// <param name="message">日志信息</param>
        void Fatal(string message);

        /// <summary>
        ///     Fatal记录
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="ex">异常信息</param>
        void Fatal(string message, Exception ex);

        /// <summary>
        ///     Info记录
        /// </summary>
        /// <param name="message">日志信息</param>
        void Info(string message);

        /// <summary>
        ///     Warn记录
        /// </summary>
        /// <param name="message">日志信息</param>
        void Warn(string message);

        #endregion Methods
    }
}
