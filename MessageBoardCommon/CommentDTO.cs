using MessageBoardCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class CommentDTO
    {
        [DataMember]
        public int CommentID { get; set; }

        [DataMember]
        public Nullable<int> UserID { get; set; }

        [DataMember]
        public Nullable<int> PostID { get; set; }

        [DataMember]
        public Nullable<int> MainComment { get; set; }

        [DataMember]
        public string CommentContent { get; set; }

        [DataMember]
        public bool IsBlocked { get; set; }

        [DataMember]
        public System.DateTime CreationDate { get; set; }

        [DataMember]
        public virtual UserDTO tblUser { get; set; }

        [DataMember]
        public virtual PostDTO tblPost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<CommentDTO> tblComment1 { get; set; }

        [DataMember]
        public virtual CommentDTO tblComment2 { get; set; }
    }
}
