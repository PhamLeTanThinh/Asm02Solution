using BussinessObject.Context;
using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.Repository;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private MemberDAO _memberDAO = MemberDAO.Instance;
        public void AddMember(Member _Member) => _memberDAO.AddMember(_Member);

        public IEnumerable<Member> FilterMemberByString(string name) => _memberDAO.FilterMemberByString(name);

        public Member GetMemberByEmail(string email) => _memberDAO.GetMemberByEmail(email);

        public Member GetMemberById(int id) => _memberDAO.GetMemberById(id);

        public IEnumerable<Member> GetMemberList() => _memberDAO.GetMemberList();

        public Member Login(string email, string password) => _memberDAO.Login(email, password);

        public void RemoveMember(Member _Member) => _memberDAO.RemoveMember(_Member);

        public void UpdateMember(Member _Member) => _memberDAO.UpdateMember(_Member);
    }
}
