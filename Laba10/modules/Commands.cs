﻿using System.Windows.Input;

namespace Laba10.modules
{
    public static class CustomCommands
	{
		public static readonly RoutedUICommand Save = new RoutedUICommand
			(
				"Save",
				"SaveFromComboBox",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Return)
				}
			);

		public static readonly RoutedUICommand Exit = new RoutedUICommand
			(
				"Exit",
				"Exit",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.F4, ModifierKeys.Alt)
				}
			);
	}
}
