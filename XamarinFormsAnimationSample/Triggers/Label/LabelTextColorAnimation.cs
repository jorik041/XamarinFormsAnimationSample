﻿using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change Label TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("LabelTextColorAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				(sender as Label).TextColor = AnimationUtil.CalculateCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
