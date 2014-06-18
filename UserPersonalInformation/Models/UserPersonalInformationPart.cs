using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserPersonalInformation.Records;
using Orchard.ContentManagement;

namespace UserPersonalInformation.Models
{
    public class UserPersonalInformationPart:ContentPart<UserPersonalInformationRecord>
    {
        public int Id
        {
            get { return Record.Id; }            
        }
        public string FirstName
        {
            get { return Record.FirstName; }
            set { Record.FirstName = value; }
        }
        public string MiddleName
        {
            get { return Record.MiddleName; }
            set { Record.MiddleName = value; }
        }
        public string LastName
        {
            get { return Record.LastName; }
            set { Record.LastName = value; }
        }
        //public DateTime DateOfBirth
        //{
        //    get { return Record.DateOfBirth; }
        //    set { Record.DateOfBirth = value; }
        //}
        public string NickName
        {
            get { return Record.NickName; }
            set { Record.NickName = value; }
        }
        public string DisplayName
        {
            get { return Record.DisplayName; }
            set { Record.DisplayName = value; }
        }
        public Gender Gender
        {
            get { return Record.Gender; }
            set { Record.Gender = value; }
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
}