namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Introduction(string value, Func<string, string> callback)
        {
            var upperName = value.ToUpper();
            return callback(upperName);
        } 

        public string Welcome(string name)
        {
            return $"Welcome, {name}";
        }

        public string MinimumRequirements(string name)
        { 
            return $"Sorry, {name}, you don't meet the minimum requirements.";
        }
    }
}
