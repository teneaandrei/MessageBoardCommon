using System.Runtime.Serialization;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class BaseDTO
    {
        [DataMember]
        public bool IsError { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}