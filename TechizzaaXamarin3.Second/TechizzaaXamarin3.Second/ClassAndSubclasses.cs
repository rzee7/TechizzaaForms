﻿using System;
using System.Collections.Generic;

namespace TechizzaXamarin3
{
    class ClassAndSubclasses
    {
        public ClassAndSubclasses(Type parent)
        {
            this.Type = parent;
            this.Subclasses = new List<ClassAndSubclasses>();
        }

        public Type Type { private set; get; }
        public List<ClassAndSubclasses> Subclasses { private set; get; }
    }
}
