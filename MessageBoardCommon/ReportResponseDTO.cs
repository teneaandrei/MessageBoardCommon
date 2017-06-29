using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MessageBoardCommon
{
    [DataContract]
    public class ReportResponseDTO
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public int NrOfPosts { get; set; }
        [DataMember]
        public int NrOfComments { get; set; }
        [DataMember]
        public System.DateTime PostCreationDate { get; set; }
        [DataMember]
        public System.DateTime CommentCreationDate { get; set; }
    }
}
