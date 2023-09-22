namespace Member.Application;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;

    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    IList<Domain.Member> IMemberService.GetAllMembers()
    {
        return _memberRepository.GetAllMembers();
    }
}
