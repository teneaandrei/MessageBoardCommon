using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MessageBoardCommon
{
    [DataContract]
    public class TranslationDTO
    {
        [DataMember]
        public int TranslationID { get; set; }
        [DataMember]
        public string FormName { get; set; }
        [DataMember]
        public string ControlName { get; set; }
        [DataMember]
        public string RowKey { get; set; }
    }
}
