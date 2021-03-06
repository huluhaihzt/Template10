﻿using System.Threading.Tasks;

namespace Prism.Navigation
{
    /// <summary>
    /// Provides a way for ViewModels involved in navigation to be notified of navigation activities after the target Page has been added to the navigation stack.
    /// </summary>
    public interface INavigatedAwareAsync
    {
        /// <summary>
        /// Called when the implementer has been navigated away from.
        /// </summary>
        /// <param name="parameters">The navigation parameters.</param>
        Task OnNavigatedFromAsync(NavigationParameters parameters);

        /// <summary>
        /// Called when the implementer has been navigated to.
        /// </summary>
        /// <param name="parameters">The navigation parameters.</param>
        Task OnNavigatedToAsync(NavigationParameters parameters);
    }
}
