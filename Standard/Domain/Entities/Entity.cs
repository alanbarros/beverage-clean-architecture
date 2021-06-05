using System;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Entity : IEntity
    {
        public Guid Id { get; }

        public Entity(Guid id)
        {
            Id = id;
        }
    }
}