using BussinessObject.Context;
using BussinessObject.Models;
using DataAccess.Repository;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member _Member)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    if (fsContext.Members.SingleOrDefault(value => value.MemberId == _Member.MemberId) != null)
                    {
                        throw new Exception("This Id was existed");
                    }
                    fsContext.Members.Add(_Member);
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        public IEnumerable<Member> GetMember()
        {
            IEnumerable<Member> members;

            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    members = fsContext.Members.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
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
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    var _member = fsContext.Members.SingleOrDefault(value => value.MemberId == _Member.MemberId);
                    fsContext.Members.Remove(_Member);
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateMember(Member _Member)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    fsContext.Entry<Member>(_Member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
