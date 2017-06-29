using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MessageBoardCommon
{
    [DataContract]
    public class LanguageDTO
    {
        [DataMember]
        public int LanguageID { get; set; }
        [DataMember]
        public string LanguageName { get; set; }
        [DataMember]
        public string Culture { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual ICollection<TranslationDTO> tblTranslations { get; set; }
    }
}
