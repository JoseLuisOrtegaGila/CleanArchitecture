using System;
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserID) : IDomainEvent;
