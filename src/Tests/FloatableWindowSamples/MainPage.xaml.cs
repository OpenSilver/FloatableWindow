using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FloatableWindowSamples
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new FloatableWindow
            {
                ParentLayoutRoot = LayoutRoot,
                Content = new Border
                {
                    Width = 200,
                    Height = 200,
                    Background = new SolidColorBrush(Colors.Red),
                    Child = new TextBlock
                    {
                        Text = "This is a non-modal FloatableWindow",
                        FontSize = 20,
                        TextAlignment = TextAlignment.Center,
                        TextWrapping = TextWrapping.Wrap,
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Center,
                    },
                },
            };

            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new FloatableWindow
            {
                ParentLayoutRoot = LayoutRoot,
                Content = new Border
                {
                    Width = 200,
                    Height = 200,
                    Background = new SolidColorBrush(Colors.Yellow),
                    Child = new TextBlock
                    {
                        Text = "This is a modal FloatableWindow",
                        FontSize = 20,
                        TextAlignment = TextAlignment.Center,
                        TextWrapping = TextWrapping.Wrap,
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Center,
                    },
                },
            };

            window.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double.TryParse(hOffsetTB.Text, out double hOffset);
            double.TryParse(vOffsetTB.Text, out double vOffset);

            var window = new FloatableWindow
            {
                ParentLayoutRoot = LayoutRoot,
                Content = new Border
                {
                    Width = 200,
                    Height = 200,
                    Background = new SolidColorBrush(Colors.LightGreen),
                    Child = new TextBlock
                    {
                        Text = "This is a non-modal FloatableWindow",
                        FontSize = 20,
                        TextAlignment = TextAlignment.Center,
                        TextWrapping = TextWrapping.Wrap,
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Center,
                    },
                },
            };

            window.Show(hOffset, vOffset);
        }
    }
}
