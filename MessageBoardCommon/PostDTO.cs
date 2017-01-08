using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class PostDTO
    {
        [DataMember]
        public int PostID { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string PostText { get; set; }

        [DataMember]
        public byte[] PostImage { get; set; }

        [DataMember]
        public bool IsPublished { get; set; }

        [DataMember]
        public System.DateTime CreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<CommentDTO> tblComments { get; set; }

        [DataMember]
        public virtual UserDTO tblUser { get; set; }
    }
}
