﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts
{
    public interface IGroupBO
    {
        Group ChangeName(Group group, Person person);
    }
}
