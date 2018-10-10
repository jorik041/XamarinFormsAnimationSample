﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LayoutPaddingThicknessAnimation : AnimationBase<Thickness>
	{
		/// <summary>
		/// Invoke Layout Padding Animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Layout).Margin);

			sender.Animate(nameof(LayoutPaddingThicknessAnimation), new Animation((d) =>
			{
				(sender as Layout).Margin = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
