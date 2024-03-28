namespace Lab4Web.Services.Delegate
{
    public interface IDelegateService
    {
        string Introduction(string value, Func<string, string> callback);

        string Welcome(string name);

        string MinimumRequirements(string name); 
    }
}
