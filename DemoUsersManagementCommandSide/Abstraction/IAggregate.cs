﻿using DemoUsersManagementCommandSide.Events;

namespace DemoUsersManagementCommandSide.Abstraction
{
    public interface IAggregate
    {
        Guid Id { get; }
        int Sequence { get; }
        IReadOnlyList<Event> GetUncommittedEvents();
        void MarkChangesAsCommitted();

    }
}
