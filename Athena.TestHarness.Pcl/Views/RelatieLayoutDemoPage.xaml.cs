﻿using System;
using System.Collections.Generic;
using Athena.Core.Pcl.Views;
using Xamarin.Forms;

namespace Athena.TestHarness.Pcl.Views
{	
	public partial class RelatieLayoutDemoPage : ContentPageBase
	{	
		public RelatieLayoutDemoPage ()
		{
			InitializeComponent ();

			ViewModel.View = this;
		}
	}
}

