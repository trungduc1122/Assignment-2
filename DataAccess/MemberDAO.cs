using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        Member checkLogin(string email,string password)
        {
            Member member = null;
            using var db = new FStoreDBAssignmentContext();
            member =(Member)db.Member.Where(x => x.Email == email && x.Password == password);
            return member;
        }

        List<Member> GetMembers()
        {
            List<Member> list = null;
            using var db = new FStoreDBAssignmentContext();
            list = db.Member.ToList<Member>();
            return list;
        }

    }
}
