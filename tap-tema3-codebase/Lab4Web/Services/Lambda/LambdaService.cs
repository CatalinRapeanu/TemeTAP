namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {
        //tuple ca parametru
        public Tuple<int, int,int> Test1(int value)
        {
            var lambdaExp = (int num) => new Tuple<int, int, int>(num % 10, (num /= 10) % 10, (num /= 10) % 10);
            return lambdaExp(value);
        }

        //parametri neutilizati in expresie
        public bool Test2(string value)
        {
            return int.TryParse(value, out _);
        }

        //un parametru + async
        public async Task<string> Test3Async(string value)
        {
            var lambaExp = async (string v) =>
            {
                await Delay();
                return value.ToLower();
            };

            return await lambaExp(value);
        }
        
        //doi parametri + async
        public async Task<int> Test4Async(int number1, int number2)
        {
            var lambdaExp = async (int num1, int num2) =>
            {
                await Delay();
                return num1 * num1 + num2 * num2;
            };

            return await lambdaExp(number1, number2);
        }

        //parametri cu valori default
        public int Test5(int a = 21, int b = 34)
        {
            Func<int, int, int> lambdaExp = (x, y) => (x % 10) * (x % 100) + (y % 10) * (y / 10);
            return lambdaExp(a, b);
        }
        
        //fara parametri
        public string Test6Hello()
        {
            var lambdaExp = () => $"Hello and welcome to the page.";
            return lambdaExp();
        }
         
        //tuple
        public Tuple<string, string, string> Test7Tuple2(string value)
        {
            Func<string, Tuple<string, string, string>> lambdaExp = val =>
                new Tuple<string, string, string>(
                    val.Substring(0, val.Length / 3),
                    val.Substring(val.Length / 3, val.Length / 3),
                    val.Substring(2 * val.Length / 3)
                );
            return lambdaExp(value);
        }
        
        //un parametru + async
        public async Task<string> Test8(string value)
        {
            var lambdaExp = async (string val) =>
            {
                await Delay();
                return val.ToUpper();
            };
            return await lambdaExp(value);
        }

        //fara parametri
        public string Test9()
        {
            var lambdaExp = () => "No parameters lambda expression.";
            return lambdaExp();
        }
        
        public Task Delay()
        {
            return Task.Delay(2000);
        }
    }
}
