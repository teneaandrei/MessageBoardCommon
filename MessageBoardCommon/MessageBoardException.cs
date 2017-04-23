//using DevExpress.XtraEditors;
//using System;
//using System.Data.SqlClient;
//using System.ServiceModel;

//namespace MessageBoardCommon
//{
//    public class MessageBoardException : Exception
//    {
//        private Exception _ex;

//        public MessageBoardException()
//            : base() { }

//        public MessageBoardException(string message)
//            : base(message)
//        {
//        }

//        public MessageBoardException(string format, params object[] args)
//            : base(string.Format(format, args)) { }

//        public MessageBoardException(string message, Exception innerException)
//            : base(message, innerException)
//        {
//            _ex = innerException;
//        }

//        public MessageBoardException(string format, Exception innerException, params object[] args)
//            : base(string.Format(format, args), innerException)
//        {
//            _ex = innerException;
//        }


//        public void WriteErrorMessage()
//        {
//            if (_ex is TimeoutException)
//            {
//                XtraMessageBox.Show(Constants.ERR_TIMEOUT_EX);
//            }
//            if (_ex is EndpointNotFoundException)
//            {
//                XtraMessageBox.Show(Constants.ExceptionService);
//            }
//            if (_ex is NullReferenceException)
//            {
//                XtraMessageBox.Show(Constants.ExceptionNullObjReference);
//            }
//            if (_ex is SqlException)
//            {
//                XtraMessageBox.Show(_ex.Message);
//            }
//        }
//    }
//}
