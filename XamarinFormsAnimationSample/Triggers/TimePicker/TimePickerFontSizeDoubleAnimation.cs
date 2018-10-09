﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class TimePickerFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change TimePicker FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as TimePicker).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as TimePicker).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("TimePickerFontSizeDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
