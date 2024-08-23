using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15
{
    public class systemErrorHandLer
    {
        public event EventHandler<string> systemErrorEventNotification;

        protected virtual void OnSystemErrorEventNotification(string message)
        {
            systemErrorEventNotification?.Invoke(this, message);
        }

        public void SendSystemErrorNotification(string message)
        {
            OnSystemErrorEventNotification(message);
        }
    }
}
