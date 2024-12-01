using System;
using System.Collections.Generic;
using System.Linq;
using Cognify.Core.Interfaces;
using Cognify.Core.Models;

namespace Cognify.Core.Services
{
    public class MemoryFactory : IMemoryFactory
    {
        public Memory CreateMemory(CrimeType crimeType)
        {
            return crimeType switch
            {
                CrimeType.Violent => new Memory 
                { 
                    TargetCrimeType = crimeType,
                    Description = "Experiencia de víctima de violencia",
                    PerceivedDuration = TimeSpan.FromDays(30),
                    EmotionalImpact = "Alto impacto emocional, desarrollo de empatía"
                },
                CrimeType.Financial => new Memory 
                { 
                    TargetCrimeType = crimeType,
                    Description = "Consecuencias de pérdidas financieras",
                    PerceivedDuration = TimeSpan.FromDays(60),
                    EmotionalImpact = "Comprensión del impacto económico"
                },
                CrimeType.HateCrime => new Memory 
                { 
                    TargetCrimeType = crimeType,
                    Description = "Experiencias de discriminación y sus efectos",
                    PerceivedDuration = TimeSpan.FromDays(45),
                    EmotionalImpact = "Desarrollo de comprensión y respeto por la diversidad"
                },
                _ => throw new ArgumentException("Tipo de crimen no soportado")
            };
        }

        public List<Memory> CreateMemorySequence(CrimeType crimeType, int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => CreateMemory(crimeType))
                .ToList();
        }
    }
}