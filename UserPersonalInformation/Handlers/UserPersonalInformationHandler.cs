using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using UserPersonalInformation.Records;

namespace UserPersonalInformation.Handlers
{
    public class UserPersonalInformationHandler:ContentHandler
    {
        public UserPersonalInformationHandler(IRepository<UserPersonalInformationRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}