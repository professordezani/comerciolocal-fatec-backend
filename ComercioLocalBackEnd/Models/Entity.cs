using System;

namespace ComercioLocalBackEnd.Models
{
  public abstract class Entity
  {
    public Guid Id { get; set; }

    public Entity()
    {
      Id = Guid.NewGuid();
    }
  }
}