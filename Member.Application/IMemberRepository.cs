namespace Member.Application;

public interface IMemberRepository
{
    IList<Domain.Member> GetAllMembers();
}
