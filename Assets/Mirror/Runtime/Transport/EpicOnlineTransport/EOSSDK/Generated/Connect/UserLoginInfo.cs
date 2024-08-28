// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Additional information about the local user.
	/// 
	/// As the information passed here is client-controlled and not part of the user authentication tokens,
	/// it is only treated as non-authoritative informational data to be used by some of the feature services.
	/// For example displaying player names in Leaderboards rankings.
	/// </summary>
	public class UserLoginInfo : ISettable
	{
		/// <summary>
		/// The user's display name on the identity provider systems as UTF-8 encoded null-terminated string.
		/// The length of the name can be at maximum up to <see cref="ConnectInterface.UserlogininfoDisplaynameMaxLength" /> bytes.
		/// </summary>
		public string DisplayName { get; set; }

		internal void Set(UserLoginInfoInternal? other)
		{
			if (other != null)
			{
				DisplayName = other.Value.DisplayName;
			}
		}

		public void Set(object other)
		{
			Set(other as UserLoginInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UserLoginInfoInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_DisplayName;

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

		public void Set(UserLoginInfo other)
		{
			if (other != null)
			{
				m_ApiVersion = ConnectInterface.UserlogininfoApiLatest;
				DisplayName = other.DisplayName;
			}
		}

		public void Set(object other)
		{
			Set(other as UserLoginInfo);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_DisplayName);
		}
	}
}