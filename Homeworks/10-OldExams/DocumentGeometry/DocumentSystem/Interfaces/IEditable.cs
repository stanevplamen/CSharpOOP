﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public interface IEditable
    {
        void ChangeContent(string newContent);
    }
}
