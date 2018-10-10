﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class GridColumnSpacingDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Grid ColumnSpacing animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Grid).ColumnSpacing);

			var animation = new Animation((d) =>
			{
				(sender as Grid).ColumnSpacing = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(GridColumnSpacingDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
