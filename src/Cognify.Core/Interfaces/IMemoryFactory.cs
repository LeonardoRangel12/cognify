using System.Collections.Generic;
using Cognify.Core.Models;

namespace Cognify.Core.Interfaces
{
    public interface IMemoryFactory
    {
        Memory CreateMemory(CrimeType crimeType);
        List<Memory> CreateMemorySequence(CrimeType crimeType, int count);
    }
}