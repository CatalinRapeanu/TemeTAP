namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {
        Tuple<int, int, int> Test1(int value);

        bool Test2(string value);

        Task<string> Test3Async(string value);

        Task<int> Test4Async(int number1, int number2);

        int Test5(int a, int b);

        string Test6Hello();

        Tuple<string, string, string> Test7Tuple2(string value);

        Task<string> Test8(string value);

        string Test9();
    }
}
