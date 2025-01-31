using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;

namespace Application.Models
{
    public class MemberActs
    {
        public Member GetMember(int paramMemberNumber)
        {
            MemberData memberData = new MemberData();

            //LINQ문법 즉 paramMemberNumber 값을 받아서, Member_Number를 검색한다.
            return memberData.Members.Where(x => x.Member_Number == paramMemberNumber).SingleOrDefault();
            
        }
    }
}