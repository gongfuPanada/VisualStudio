﻿using System;
using GitHub.Authentication;
using ReactiveUI;

namespace GitHub.ViewModels
{
    public interface ITwoFactorDialogViewModel : ITwoFactorViewModel
    {
        ReactiveCommand<object> OkCommand { get; }
        ReactiveCommand<RecoveryOptionResult> ShowHelpCommand { get; }
        ReactiveCommand<RecoveryOptionResult> ResendCodeCommand { get; }

        IObservable<RecoveryOptionResult> Show(TwoFactorRequiredUserError error);

        bool IsSms { get; }
        bool IsAuthenticationCodeSent { get; }
        string Description { get; }
        string AuthenticationCode { get; set; }
    }
}
