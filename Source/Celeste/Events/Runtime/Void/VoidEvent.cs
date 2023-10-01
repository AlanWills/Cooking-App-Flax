using FlaxEngine;
using System;
using System.Collections.Generic;

namespace Celeste.Events
{
    [ContentContextMenu("New/Celeste/Events/Void Event")]
    public class VoidEvent
    {
        #region Properties and Fields

        private List<Action> callbacks = new List<Action>();

        #endregion

        public void AddCallback(Action callback)
        {
            callbacks.Add(callback);
        }

        public void RemoveCallback(Action callback)
        {
            callbacks.Remove(callback);
        }

        public void Invoke()
        {
            List<Action> callbacksClone = new List<Action>(callbacks);
            
            foreach (Action callback in callbacksClone)
            {
                callback.Invoke();
            }
        }
    }
}
