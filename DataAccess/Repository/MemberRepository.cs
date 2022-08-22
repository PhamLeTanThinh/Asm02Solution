using BussinessObject.Context;
using BussinessObject.Models;
using DataAccess.Repository;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member _Member)
        {
        }

        public IEnumerable<Member> FilterMemberByString(string name)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetMemberList()
        {
            throw new NotImplementedException();
        }

        public Member Login(string email, string password)
        {

            Member _tempMember = null;
            try
            {
                using var context = new SaleManagementContext();
                _tempMember = context.Members.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            }
            catch (Exception ex)
            {
               /* throw new Exception(ex.ToString());*/
            }
            return _tempMember;
        }

        public void RemoveMember(Member _Member)
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(Member _Member)
        {
            throw new NotImplementedException();
        }
    }
}
