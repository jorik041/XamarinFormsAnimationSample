﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class EditorPlaceholderColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Editor PlaceholderColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Editor).PlaceholderColor);

			sender.Animate(nameof(EditorPlaceholderColorAnimation), new Animation((d) =>
			{
				(sender as Editor).PlaceholderColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
