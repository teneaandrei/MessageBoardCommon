using System.Runtime.Serialization;

namespace MessageBoardDTO
{
    [DataContract]
    public class BaseDTO
    {
        [DataMember]
        public bool IsError { get; set; }
        [DataMember]
        public bool ErrorMessage { get; set; }
    }
}