﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Core.Data
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
