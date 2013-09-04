﻿using System.Windows;
using System.Globalization;

namespace MessageBoxUtils
{
    public static class WPFMessageBox
    {
        //
        // Summary:
        //     Displays a message box that has a message and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText)
        {
            return ShowCore(null, new CultureInfo("en-Us"), messageBoxText);
        }

        //
        // Summary:
        //     Displays a message box that has a message and title bar caption; and that
        //     returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            return ShowCore(null, new CultureInfo("en-US"), messageBoxText, caption);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText)
        {
            return ShowCore(owner, culture, messageBoxText);
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, and button;
        //     and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText, string caption, WPFMessageBoxButton button)
        {
            return ShowCore(null, new CultureInfo("en-US"), messageBoxText, caption, button);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message and title bar caption; and it returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText, string caption)
        {
            return ShowCore(owner, culture, messageBoxText, caption);
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and
        //     icon; and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon)
        {
            return ShowCore(null, new CultureInfo("en-US"), messageBoxText, caption, button, icon);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message, title bar caption, and button; and it also returns a
        //     result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText, string caption, WPFMessageBoxButton button)
        {
            return ShowCore(owner, culture, messageBoxText, caption, button);
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and
        //     icon; and that accepts a default message box result and returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result
        //     of the message box.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return ShowCore(null, new CultureInfo("en-US"), messageBoxText, caption, button, icon, defaultResult);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message, title bar caption, button, and icon; and it also returns
        //     a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon)
        {
            return ShowCore(owner, culture, messageBoxText, caption, button, icon);
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and
        //     icon; and that accepts a default message box result, complies with the specified
        //     options, and returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result
        //     of the message box.
        //
        //   options:
        //     A System.Windows.MessageBoxOptions value object that specifies the options.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return ShowCore(null, new CultureInfo("en-US"), messageBoxText, caption, button, icon, defaultResult, options);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message, title bar caption, button, and icon; and accepts a default
        //     message box result and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result
        //     of the message box.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return ShowCore(owner, culture, messageBoxText, caption, button, icon, defaultResult);
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box
        //     displays a message, title bar caption, button, and icon; and accepts a default
        //     message box result, complies with the specified options, and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result
        //     of the message box.
        //
        //   options:
        //     A System.Windows.MessageBoxOptions value object that specifies the options.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box
        //     button is clicked by the user.
        public static MessageBoxResult Show(Window owner, CultureInfo culture, string messageBoxText, string caption, WPFMessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return ShowCore(owner, culture, messageBoxText, caption, button, icon, defaultResult, options);
        }

        private static MessageBoxResult ShowCore(
            Window owner,
            CultureInfo culture,
            string messageBoxText,
            string caption = "",
            WPFMessageBoxButton button = WPFMessageBoxButton.OK,
            MessageBoxImage icon = MessageBoxImage.None,
            MessageBoxResult defaultResult = MessageBoxResult.None,
            MessageBoxOptions options = MessageBoxOptions.None)
        {
            return WPFMessageBoxWindow.Show(
                delegate(Window messageBoxWindow)
                {
                    messageBoxWindow.Owner = owner;
                },
                culture, messageBoxText, caption, button, icon, defaultResult, options);
        }
    }
}