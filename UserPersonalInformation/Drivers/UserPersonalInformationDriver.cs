using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserPersonalInformation.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement;

namespace UserPersonalInformation.Drivers
{
    public class UserPersonalInformationDriver:ContentPartDriver<UserPersonalInformationPart>
    {        
        protected override DriverResult Display(UserPersonalInformationPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_UserPersonalInformation", () => shapeHelper.Parts_UserPersonalInformation(
                ContentPart: part,
                FirstName: part.FirstName,
                MiddleName: part.MiddleName,
                LastName: part.LastName,
                //DateOfBirth: part.DateOfBirth,
                NickName: part.NickName,
                DisplayName: part.DisplayName,
                Gender: part.Gender));
        }

        //GET
        protected override DriverResult Editor(UserPersonalInformationPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_UserPersonalInformation_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/UserPersonalInformation",
                    Model: part,
                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(UserPersonalInformationPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);            
            return Editor(part, shapeHelper);
        }
    }
}