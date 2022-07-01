using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

       public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(string email)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetMembers()
        {
            using var db = new FStoreDBAssignmentContext();
            List<Member> list = new List<Member>();
            list=db.Member.ToList();
            return list;
        }

        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
