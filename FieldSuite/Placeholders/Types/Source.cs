﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Velir.SitecoreLibrary.Extensions;
using Sitecore.Data.Items;

namespace FieldSuite.Placeholders.Types
{
	public class Source : IFieldPlaceholder
	{
		/// <summary>
		/// Returns Field Placeholder Value
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public string Execute(FieldPlaceholderArgs args)
		{
			if (args == null || string.IsNullOrEmpty(args.ClickEvent) || string.IsNullOrEmpty(Key) || string.IsNullOrEmpty(args.Source))
			{
				return string.Empty;
			}

			string clickEvent = args.ClickEvent;
			clickEvent = clickEvent.Replace(Key, args.Source);

			return clickEvent;
		}

		/// <summary>
		/// Key
		/// </summary>
		public string Key
		{
			get;
			set;
		}
	}
}