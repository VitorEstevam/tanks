using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public abstract class Command
    {
        public abstract void Execute();

        public abstract void Undo();
    }

}