using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Models
{
    public class AuthUserGroup
    {
        public AuthUserGroup()
        {

        }
        
        //GUID
        //FN_NAME
        //NAME
        //USER_CNT
        //ALLNAMELIST
        //NAMELIST
        //FUNCTIONLIST
        //FUNCTION
        //ALLNAME
        //SNAME

        public int GroupId { get; set; }
        public string FunctionName { get; set; }
        public string UserGroupName { get; set; }
        public int UserCount { get; set; }
        public string AllNameList { get; set; }
        public string NameList { get; set; }
        public string FunctionList { get; set; }
        public string Function { get; set; }
        public string AllName { get; set; }
        public string UserInGroup { get; set; }
    }
}