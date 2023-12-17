﻿using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IMenuRepository
{
    public void Add(Menu menu);
    public void Remove(Guid id);  
    public Menu Get(Guid id);
}
