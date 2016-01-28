﻿using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism6Wpf2.Views;

namespace Prism6Wpf2
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterTypeForNavigation<ViewA>("ViewA");
            Container.RegisterTypeForNavigation<ViewB>("ViewB");
        }
    }
}