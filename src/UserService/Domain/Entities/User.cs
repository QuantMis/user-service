using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Domain.Entities
{
    public class User
    {
        public required int Id { get; set;}
        public required string Name { get; set;}
        public required string Email { get; set;}
        public required DateTime CreatedAt { get; set;}
    }
}