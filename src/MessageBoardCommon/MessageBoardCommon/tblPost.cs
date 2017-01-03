using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class tblPost
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
        public virtual ICollection<tblComment> tblComments { get; set; }

        [DataMember]
        public virtual tblUser tblUser { get; set; }
    }
}
