using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public partial class UserDTO
    {
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string PasswordHash { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Function { get; set; }

        [DataMember]
        public byte[] ProfileImage { get; set; }

        [DataMember]
        public bool IsAdministrator { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public System.DateTime AccountCreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<CommentDTO> tblComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<PostDTO> tblPosts { get; set; }

    }
}
