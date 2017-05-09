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
        //[DataMember]
        //public string Language { get; set; }
        //[DataMember]
        //public string FormName { get; set; }
        //[DataMember]
        //public string ControlName { get; set; }
        //[DataMember]
        //public string Description { get; set; }
        [DataMember]
        public int TranslationID { get; set; }
        [DataMember]
        public string TranslationKey { get; set; }
        [DataMember]
        public int LanguageID { get; set; }
        [DataMember]
        public string Translation { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateAdded { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
