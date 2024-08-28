// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Contains information about a single player achievement.
	/// </summary>
	public class PlayerAchievement : ISettable
	{
		/// <summary>
		/// This achievement's unique identifier.
		/// </summary>
		public string AchievementId { get; set; }

		/// <summary>
		/// Progress towards completing this achievement (as a percentage).
		/// </summary>
		public double Progress { get; set; }

		/// <summary>
		/// The POSIX timestamp when the achievement was unlocked. If the achievement has not been unlocked, this value will be <see cref="AchievementsInterface.AchievementUnlocktimeUndefined" />.
		/// </summary>
		public System.DateTimeOffset? UnlockTime { get; set; }

		/// <summary>
		/// Array of <see cref="PlayerStatInfo" /> structures containing information about stat thresholds used to unlock the achievement and the player's current values for those stats.
		/// </summary>
		public PlayerStatInfo[] StatInfo { get; set; }

		/// <summary>
		/// Localized display name for the achievement based on this specific player's current progress on the achievement.
		/// @note The current progress is updated when <see cref="AchievementsInterface.QueryPlayerAchievements" /> succeeds and when an achievement is unlocked.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// Localized description for the achievement based on this specific player's current progress on the achievement.
		/// @note The current progress is updated when <see cref="AchievementsInterface.QueryPlayerAchievements" /> succeeds and when an achievement is unlocked.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// URL of an icon to display for the achievement based on this specific player's current progress on the achievement. This may be null if there is no data configured in the dev portal.
		/// @note The current progress is updated when <see cref="AchievementsInterface.QueryPlayerAchievements" /> succeeds and when an achievement is unlocked.
		/// </summary>
		public string IconURL { get; set; }

		/// <summary>
		/// Localized flavor text that can be used by the game in an arbitrary manner. This may be null if there is no data configured in the dev portal.
		/// </summary>
		public string FlavorText { get; set; }

		internal void Set(PlayerAchievementInternal? other)
		{
			if (other != null)
			{
				AchievementId = other.Value.AchievementId;
				Progress = other.Value.Progress;
				UnlockTime = other.Value.UnlockTime;
				StatInfo = other.Value.StatInfo;
				DisplayName = other.Value.DisplayName;
				Description = other.Value.Description;
				IconURL = other.Value.IconURL;
				FlavorText = other.Value.FlavorText;
			}
		}

		public void Set(object other)
		{
			Set(other as PlayerAchievementInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PlayerAchievementInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AchievementId;
		private double m_Progress;
		private long m_UnlockTime;
		private int m_StatInfoCount;
		private System.IntPtr m_StatInfo;
		private System.IntPtr m_DisplayName;
		private System.IntPtr m_Description;
		private System.IntPtr m_IconURL;
		private System.IntPtr m_FlavorText;

		public string AchievementId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_AchievementId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_AchievementId, value);
			}
		}

		public double Progress
		{
			get
			{
				return m_Progress;
			}

			set
			{
				m_Progress = value;
			}
		}

		public System.DateTimeOffset? UnlockTime
		{
			get
			{
				System.DateTimeOffset? value;
				Helper.TryMarshalGet(m_UnlockTime, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_UnlockTime, value);
			}
		}

		public PlayerStatInfo[] StatInfo
		{
			get
			{
				PlayerStatInfo[] value;
				Helper.TryMarshalGet<PlayerStatInfoInternal, PlayerStatInfo>(m_StatInfo, out value, m_StatInfoCount);
				return value;
			}

			set
			{
				Helper.TryMarshalSet<PlayerStatInfoInternal, PlayerStatInfo>(ref m_StatInfo, value, out m_StatInfoCount);
			}
		}

		public string DisplayName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_DisplayName, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_DisplayName, value);
			}
		}

		public string Description
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Description, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_Description, value);
			}
		}

		public string IconURL
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_IconURL, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_IconURL, value);
			}
		}

		public string FlavorText
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_FlavorText, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_FlavorText, value);
			}
		}

		public void Set(PlayerAchievement other)
		{
			if (other != null)
			{
				m_ApiVersion = AchievementsInterface.PlayerachievementApiLatest;
				AchievementId = other.AchievementId;
				Progress = other.Progress;
				UnlockTime = other.UnlockTime;
				StatInfo = other.StatInfo;
				DisplayName = other.DisplayName;
				Description = other.Description;
				IconURL = other.IconURL;
				FlavorText = other.FlavorText;
			}
		}

		public void Set(object other)
		{
			Set(other as PlayerAchievement);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_AchievementId);
			Helper.TryMarshalDispose(ref m_StatInfo);
			Helper.TryMarshalDispose(ref m_DisplayName);
			Helper.TryMarshalDispose(ref m_Description);
			Helper.TryMarshalDispose(ref m_IconURL);
			Helper.TryMarshalDispose(ref m_FlavorText);
		}
	}
}