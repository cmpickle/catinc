namespace catinc.Models.Domain
{
    public interface IIdentityUser
    {
        string Id { get; set; }
        IIdentityUser Create();
    }
}