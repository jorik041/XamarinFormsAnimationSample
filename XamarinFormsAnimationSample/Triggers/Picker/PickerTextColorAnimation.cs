﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class PickerTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Picker TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Picker).TextColor);

			sender.Animate(nameof(PickerTextColorAnimation), new Animation((d) =>
			{
				(sender as Picker).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
