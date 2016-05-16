using System;

namespace WebApiProductionPack.Examples.Models.Root
{
    public class RootResult
    {
        public Guid Id { get; set; }

        public RootResult()
        {
            Id = Guid.NewGuid();
        }
    }
}