﻿using SandBoxAPI.Interfaces;

namespace SandBoxAPI.Models
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
