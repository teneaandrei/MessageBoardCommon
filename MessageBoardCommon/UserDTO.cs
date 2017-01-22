using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    
    public partial class UserDTO
    {
        public int UserID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Function { get; set; }

        public byte[] ProfileImage { get; set; }

        public bool IsAdministrator { get; set; }

        public bool IsActive { get; set; }

        public System.DateTime AccountCreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<CommentDTO> tblComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<PostDTO> tblPosts { get; set; }

    }
}
