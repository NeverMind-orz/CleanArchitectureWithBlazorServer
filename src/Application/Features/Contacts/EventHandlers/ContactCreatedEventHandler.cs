﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This file is part of the CleanArchitecture.Blazor project.
//     Licensed to the .NET Foundation under one or more agreements.
//     The .NET Foundation licenses this file to you under the MIT license.
//     See the LICENSE file in the project root for more information.
//
//     Author: neozhu
//     Created Date: 2024-11-12
//     Last Modified: 2024-11-12
//     Description: 
//       Handles the `ContactCreatedEvent` which occurs when a new contact is created.
//       This event handler can be extended to trigger additional actions, such as 
//       sending notifications or updating other systems.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanArchitecture.Blazor.Application.Features.Contacts.EventHandlers;

public class ContactCreatedEventHandler : INotificationHandler<ContactCreatedEvent>
{
        private readonly ILogger<ContactCreatedEventHandler> _logger;

        public ContactCreatedEventHandler(
            ILogger<ContactCreatedEventHandler> logger
            )
        {
            _logger = logger;
        }
        public Task Handle(ContactCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handled domain event '{EventType}' with notification: {@Notification} ", notification.GetType().Name, notification);
            return Task.CompletedTask;
        }
}
