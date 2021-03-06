﻿using ChattingApp.Core;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static ChattingApp.DI;

namespace ChattingApp
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependency Properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public ApplicationPage CurrentPage
        {
            //get { return (BasePage)GetValue(CurrentPageProperty); }
            //set { SetValue(CurrentPageProperty, value); }
            // same as
            get => (ApplicationPage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(ApplicationPage), typeof(PageHost), new UIPropertyMetadata(default(ApplicationPage), null, CurrentPagePropertyChanged));

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public BaseViewModel CurrentPageViewModel
        {
            //get { return (BasePage)GetValue(CurrentPageProperty); }
            //set { SetValue(CurrentPageProperty, value); }
            // same as
            get => (BaseViewModel)GetValue(CurrentPageViewModelProperty);
            set => SetValue(CurrentPageViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        /// <summary>
        /// Registers <see cref="CurrentPageViewModel"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageViewModelProperty =
            DependencyProperty.Register(nameof(CurrentPageViewModel), typeof(BaseViewModel), typeof(PageHost), new UIPropertyMetadata());

        #endregion

        #region Constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();

            // If we are in designmode, show the current page
            // as the dependency property does not fire
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                NewPage.Content = ViewModelApplication.CurrentPage.ToBasePage();
            }
        }

        #endregion

        #region Property Changed Events

        /// <summary>
        /// Called when the <see cref="CurrentPage"/> has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static object CurrentPagePropertyChanged(DependencyObject d, object value)
        {
            // Get current values
            var currentPage = (ApplicationPage)d.GetValue(CurrentPageProperty);
            var currentPageViewModel = d.GetValue(CurrentPageViewModelProperty);

            // Get the frames
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            // If the current page hasn't changed
            if (newPageFrame.Content is BasePage page && page.ToApplicationPage() == currentPage)
            {
                // Just update the view model
                page.ViewModelObject = currentPageViewModel;

                return value;
            }

            // Store the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove current page from the new page frame
            newPageFrame.Content = null;

            // Move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // Animate out previous page when the loaded event fires
            // right after this call due to moving frames
            if (oldPageContent is BasePage oldPage)
            {
                // Tell old page to animate out
                oldPage.ShouldAnimateOut = true;

                // Once done, remove it
                Task.Delay((int)(oldPage.SlideSeconds * 1000)).ContinueWith((t) =>
                {
                    // Remove old page (Application.Current.Dispatcher.Invoke() puts us back on the single UI thread)
                    Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                }
                );
            }

            // Set the new page content
            newPageFrame.Content = currentPage.ToBasePage(currentPageViewModel);

            return value;
        }

        #endregion
    }
}
