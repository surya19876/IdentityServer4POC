using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerPOC3.Models
{
    public class UserEntity
    {
        public int pkUserTable { get; set; }

        //public DateTime dtEntered { get; set; }
        public int fkAffiliateID { get; set; }

        public int? fkUpdateSource { get; set; }
        public int? fkUserContactInfo { get; set; }
        public int? fkUserSource { get; set; }
        public byte fkUserType { get; set; }
        public int iNoMail { get; set; }
        public int iSessionKey { get; set; }
        public int iSplit { get; set; }
        public decimal nRebate { get; set; }
        public string sAnswer { get; set; }
        public string sCRMAccountId { get; set; }

        public string sLogin { get; set; }
        public string sPassword { get; set; }
        public string sPWD { get; set; }
        public string sQuestion { get; set; }
        public string sRefer { get; set; }
        public string sSalt { get; set; }
        public DateTime? dtCreated { get; set; }
        public string sCreatedBy { get; set; }
        public DateTime? dtLastUpdated { get; set; }
        public string sLastUpdatedBy { get; set; }
    }
}
