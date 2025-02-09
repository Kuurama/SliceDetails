﻿using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Util;

namespace SliceDetails.UI
{
	internal class SettingsViewController : PersistentSingleton<SettingsViewController>
	{
		[UIValue("show-pause")]
		public bool ShowInPauseMenu {
			get { return Plugin.Settings.ShowInPauseMenu; }
			set { Plugin.Settings.ShowInPauseMenu = value; }
		}

		[UIValue("show-completion")]
		public bool ShowInCompletionScreen
		{
			get { return Plugin.Settings.ShowInCompletionScreen; }
			set { Plugin.Settings.ShowInCompletionScreen = value; }
		}

		[UIValue("show-handles")]
		public bool ShowHandle
		{
			get { return Plugin.Settings.ShowHandle; }
			set { Plugin.Settings.ShowHandle = value; }
		}

		[UIValue("show-counts")]
		public bool ShowSliceCounts
		{
			get { return Plugin.Settings.ShowSliceCounts; }
			set { Plugin.Settings.ShowSliceCounts = value; }
		}

		[UIValue("true-offsets")]
		public bool TrueCutOffsets
		{
			get { return Plugin.Settings.TrueCutOffsets; }
			set { Plugin.Settings.TrueCutOffsets = value; }
		}

		[UIValue("count-arcs")]
		public bool CountArcs
		{
			get { return Plugin.Settings.CountArcs; }
			set { Plugin.Settings.CountArcs = value; }
		}

		[UIValue("count-chains")]
		public bool CountChains
		{
			get { return Plugin.Settings.CountChains; }
			set { Plugin.Settings.CountChains = value; }
		}
	}
}
