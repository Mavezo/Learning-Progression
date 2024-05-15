namespace ASP.NET_Core_3
{
    public interface IGetResult
    {
        int GetResult(int index);
    }

    public class Fibonacci : IGetResult
    {
        public int GetResult(int index)
        {
            if (index < 0)
            {
                return 0;
            }
            if (index == 1)
            {
                return 1;
            }

            return GetResult(index - 1) + GetResult(index - 2);
        }
    }

    public class Factorial : IGetResult
    {
        public int GetResult(int index)
        {
            if(index == 1)
            {
                return 1;
            }
            return index * GetResult(index - 1);
        }
    }

    public class NumberProcessingService
    {
        private readonly IGetResult method;

        public NumberProcessingService(IGetResult method)
        {
            this.method = method;
        }

        public int GetResult(int index)
        {
            return method.GetResult(index);
        }

    }

}
