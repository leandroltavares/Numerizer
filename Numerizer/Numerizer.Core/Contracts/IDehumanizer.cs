using System;
namespace Numerizer.Core.Contracts
{
    public interface IDehumanizer
    {
        long DehumanizeOrdinal(string source);

        long DehumanizeCardinal(string source);
    }
}
