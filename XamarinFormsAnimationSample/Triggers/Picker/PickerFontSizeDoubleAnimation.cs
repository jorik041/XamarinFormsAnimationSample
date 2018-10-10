﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class PickerFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Picker FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Picker).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as Picker).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(PickerFontSizeDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
