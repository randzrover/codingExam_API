﻿using System;
using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public sealed class ItemNotFoundException : NotFoundException
{
    public ItemNotFoundException(Guid itemId)
        : base($"The item with the identifier {itemId} was not found.")
    {
    }
}