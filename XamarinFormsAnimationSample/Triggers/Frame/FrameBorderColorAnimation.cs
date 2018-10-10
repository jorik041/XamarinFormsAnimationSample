﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class FrameBorderColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Frame BorderColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Frame).BorderColor);

			sender.Animate(nameof(FrameBorderColorAnimation), new Animation((d) =>
			{
				(sender as Frame).BorderColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
