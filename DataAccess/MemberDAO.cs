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
        public Member CheckLogin(string email,string password)
        {
            Member member = null;
            using var db = new FStoreDBAssignmentContext();
            member =(Member)db.Member.Where(x => x.Email == email && x.Password == password);
            return member;
        }

        public List<Member> GetMembers()
        {
            List<Member> list = null;
            using var db = new FStoreDBAssignmentContext();
            list = db.Member.ToList<Member>();
            return list;
        }

        public void AddMember(Member member)
        {
            using var db = new FStoreDBAssignmentContext();
            db.Member.Add(member);
            db.SaveChanges();
        }

        public void DeleteMember(string email)
        {
            using var db = new FStoreDBAssignmentContext();
            Member member=db.Member.Where(x=>x.Email == email).FirstOrDefault();
            db.Member.Remove(member);
            db.SaveChanges();
        }
        public void UpdateMember(Member member)
        {
            using var db = new FStoreDBAssignmentContext();
            db.Member.Update(member);
            db.SaveChanges();
        }

    }
}
