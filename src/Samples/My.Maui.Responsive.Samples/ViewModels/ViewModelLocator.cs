﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace My.Maui.Responsive.Samples.ViewModels
{
    internal static class ViewModelLocator
    {
        private static IServiceProvider _serviceProvider;

        internal static void UseServiceProvider(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        internal static LandPageViewModel LandingPage => Get<LandPageViewModel>();

        internal static TViewModel Get<TViewModel>() where TViewModel : ViewModel 
            => _serviceProvider.GetRequiredService<TViewModel>();
    }
}
