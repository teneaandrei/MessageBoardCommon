using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardCommon
{
    [DataContract]
    public class ReportRequestDTO
    {
        [DataMember]
        public bool RequestForPost { get; set; }
        [DataMember]
        public bool RequestForComment { get; set; }
        [DataMember]
        public System.DateTime? StartDate { get; set; }
        [DataMember]
        public System.DateTime? EndDate { get; set; }
    }
}
