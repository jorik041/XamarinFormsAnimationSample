﻿using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Interfaces;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeDoubleAnimation : TriggerAction<VisualElement>, ITriggerAction<double>
	{
		// Animation Parameter
		public double From { get; set; }
		public double To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		/// <summary>
		/// Calculates the font-size gap.
		/// </summary>
		/// <returns>The gap.</returns>
		/// <param name="from">From.</param>
		/// <param name="to">To.</param>
		public double CalculateGap(double from, double to)
		{
			return to - from;
		}

		/// <summary>
		/// Invoke change font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			var gap = CalculateGap(From, To);

			var animation = new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var currentSize = gap * animationRatio;
				(sender as Label).FontSize = From + currentSize;
			});
			sender.Animate("LabelFontSizeAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
