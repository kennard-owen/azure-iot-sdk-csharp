﻿using Microsoft.Azure.Amqp;
using System;
using System.Threading.Tasks;

namespace Microsoft.Azure.Devices.Client.Transport.Amqp
{
    internal interface IAmqpConnectionHolder
    {
        IAmqpSessionHolder CreateAmqpSessionHolder(
            DeviceIdentity deviceIdentity, 
            Action retryTrigger, 
            Func<MethodRequestInternal, Task> methodHandler, 
            Action<AmqpMessage> desiredPropertyListener, 
            Func<string, Message, Task> messageListener);
        bool DisposeOnIdle();
        int GetNumberOfSessions();
    }
}
