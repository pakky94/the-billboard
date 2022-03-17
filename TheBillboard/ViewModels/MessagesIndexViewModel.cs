﻿using TheBillboard.Models;

namespace TheBillboard.ViewModels
{
    public record MessagesIndexViewModel(MessageCreationViewModel MessageCreationViewModel, IEnumerable<MessageWithAuthor> Messages);
}
