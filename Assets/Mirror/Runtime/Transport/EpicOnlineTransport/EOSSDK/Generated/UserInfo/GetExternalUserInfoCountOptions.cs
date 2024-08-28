// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Input parameters for the <see cref="UserInfoInterface.GetExternalUserInfoCount" /> function.
	/// </summary>
	public class GetExternalUserInfoCountOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Online Services Account ID of the player whose information is being retrieved
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetExternalUserInfoCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public EpicAccountId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public void Set(GetExternalUserInfoCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = UserInfoInterface.GetexternaluserinfocountApiLatest;
				LocalUserId = other.LocalUserId;
				TargetUserId = other.TargetUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as GetExternalUserInfoCountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_TargetUserId);
		}
	}
}