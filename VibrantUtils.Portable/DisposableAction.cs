﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class DisposableAction : IDisposable
    {
        private Action _act;

        public DisposableAction(Action act)
        {
            _act = act;
        }

        public void Dispose()
        {
            _act();
        }
    }
}
