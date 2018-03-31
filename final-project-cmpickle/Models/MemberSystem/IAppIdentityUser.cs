namespace final_project_cmpickle.Models.MemberSystem
{
    public interface IMyIdentityUser
    {
        int Id { get; set; }

        IIdentityUser Create();
    }
}