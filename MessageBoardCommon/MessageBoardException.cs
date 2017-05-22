using DevExpress.XtraEditors;
using MessageBoardCommon;
using System;
using System.Data.SqlClient;
using System.ServiceModel;

namespace MessageBoardCommon
{
    public class MessageBoardException : Exception
    {
        private Exception _ex;

        public MessageBoardException()
            : base() { }

        public MessageBoardException(string message)
            : base(message)
        {
        }

        public MessageBoardException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public MessageBoardException(string message, Exception innerException)
            : base(message, innerException)
        {
            _ex = innerException;
        }

        public MessageBoardException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
            _ex = innerException;
        }


        public void WriteErrorMessage()
        {
            if (_ex is TimeoutException)
            {
                XtraMessageBox.Show(_ex.Message);
            }
            if (_ex is EndpointNotFoundException)
            {
                XtraMessageBox.Show(_ex.Message);
            }
            if (_ex is NullReferenceException)
            {
                XtraMessageBox.Show(_ex.Message);
            }
            if (_ex is SqlException)
            {
                XtraMessageBox.Show(_ex.Message);
            }
            if(_ex is MessageBoardException)
            {
                XtraMessageBox.Show(_ex.Message);
            }
        }
    }
}
