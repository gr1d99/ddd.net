namespace Member.Application;

public interface IMemberService
{
    //This interface is use for Bussiness Rule / USE CASE
    IList<Domain.Member> GetAllMembers();
}
