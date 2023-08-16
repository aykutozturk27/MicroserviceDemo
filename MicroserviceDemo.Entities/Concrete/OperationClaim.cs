﻿using MicroserviceDemo.Core.Entities;

namespace MicroserviceDemo.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
