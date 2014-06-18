using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Core;
using Orchard.ContentManagement.Records;
using Orchard.ContentManagement;
using Orchard.Core.Common.Utilities;
using UserPersonalInformation.Models;
namespace UserPersonalInformation.Records
{
    public class UserPersonalInformationRecord:ContentPartRecord
    {
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        //public virtual DateTime DateOfBirth { get; set; }
        public virtual string NickName { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual Gender Gender { get; set; }
    }
}