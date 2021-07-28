using System;
using Microsoft.AspNetCore.Identity;

namespace HelloDotNet.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
