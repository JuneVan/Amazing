using System.Threading;

namespace Amazing
{
    public interface ISignal
    {
        CancellationToken Token { get; }
    }
}
