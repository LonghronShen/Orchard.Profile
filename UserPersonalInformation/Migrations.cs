using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using UserPersonalInformation.Models;

namespace UserPersonalInformation {
    public class Migrations : DataMigrationImpl {

        public int Create() {
            SchemaBuilder.CreateTable("UserPersonalInformationRecord", table => table
                .ContentPartRecord()
                .Column("FirstName", DbType.String)
                .Column("MiddleName", DbType.String)
                .Column("LastName", DbType.String)
                
                .Column("NickName", DbType.String)
                .Column("DisplayName", DbType.String)
                .Column("Gender", DbType.String)
            );
            ContentDefinitionManager.AlterTypeDefinition("User",
                cfg => cfg
                    .WithPart(typeof(UserPersonalInformationPart).Name)
                );
            return 1;
        }
    }
}