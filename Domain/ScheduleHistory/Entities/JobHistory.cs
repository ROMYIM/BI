using Core.Domain.Entity;
using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ScheduleHistory.Entities
{
    public class JobHistory : AggregateRoot<ulong>
    {
        public string Description { get; private set; }

        public string Name { get; private set; }

        internal JobHistory(string name, string description)
        {
            Name = name;
            Description = description;
            CreationTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        internal JobHistory(ulong id, string name, string description, DateTime creationTime, DateTime updateTime)
        {
            Id = id;
            Name = name;
            CreationTime = creationTime;
            UpdateTime = updateTime;
            Description = description;
        }

        public void Deconstruct(out ulong id, out string name, out string description, out DateTime creationTime, out DateTime updateTime)
        {
            id = Id;
            name = Name;
            description = Description;
            creationTime = CreationTime;
            updateTime = UpdateTime;
        }
    }
}
