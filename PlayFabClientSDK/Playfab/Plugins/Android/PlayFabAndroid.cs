#if UNITY_EDITOR

#elif UNITY_ANDROID
#define PLAYFAB_ANDROID_PLUGIN
#endif

using System;
using UnityEngine;

namespace PlayFab
{
	public class PlayFabAndroidPlugin
	{
		private static PlayFabGameObject PlayFabGO;

#if PLAYFAB_ANDROID_PLUGIN

		private static AndroidJavaClass AndroidPlugin;
		private static AndroidJavaClass PlayServicesUtils;

		public static bool isAvailable() { return true; }
#else
		public static bool isAvailable() { return false; }
#endif

		public static void init()
		{
			if (PlayFabGO != null)
				return;

			GameObject playfabHolder = GameObject.Find ("_PlayFabGO");
			if(playfabHolder == null)
				playfabHolder = new GameObject ("_PlayFabGO");
			UnityEngine.Object.DontDestroyOnLoad(playfabHolder);

			PlayFabGO = playfabHolder.GetComponent<PlayFabGameObject> ();
			if(PlayFabGO == null)
				PlayFabGO = playfabHolder.AddComponent<PlayFabGameObject> ();

#if PLAYFAB_ANDROID_PLUGIN
			AndroidPlugin = new AndroidJavaClass("com.playfab.unity.plugin.AndroidPlugin");
			AndroidPlugin.CallStatic("init");

			PlayServicesUtils = new AndroidJavaClass("com.playfab.unity.plugin.PlayServicesUtils");
#endif
			PlayFabGoogleCloudMessaging.init ();
		}

#if PLAYFAB_ANDROID_PLUGIN

		public static bool isPlayServicesAvailable()
		{
			return PlayServicesUtils.CallStatic<bool> ("isPlayServicesAvailable");
		}
#else
		public static bool isPlayServicesAvailable()
		{
			return false;
		}
#endif
	}

	public class PlayFabGoogleCloudMessaging
	{
		public delegate void GCMRegisterComplete(string id, string error);

		private static GCMRegisterComplete RegistrationCallback;

#if PLAYFAB_ANDROID_PLUGIN

		private static AndroidJavaClass PlayFabGCMClass;

		public static void init()
		{
			PlayFabGCMClass = new AndroidJavaClass("com.playfab.unity.plugin.GoogleCloudMessaging"); 
		}

		public static void registerAsync(string senderId, GCMRegisterComplete callback)
		{
			if (RegistrationCallback != null)
				throw new Exception ("GCM Registration already in progress");

			RegistrationCallback = callback;
			PlayFabGCMClass.CallStatic ("registerInBackground", new object[] {senderId});
		}


		public static bool isRegistered()
		{
			return getRegistrationId() != null;
		}

		public static string getRegistrationId()
		{
			return PlayFabGCMClass.CallStatic<string> ("getRegistrationId");
		}


	#else

		public static void init()
		{

		}
		
		public static void registerAsync(string senderId, GCMRegisterComplete callback)
		{
			registrationComplete(null, "Google Cloud Messaging not available");
		}

		public static bool isRegistered()
		{
			return false;
		}
		
		public static string getRegistrationId()
		{
			return null;
		}

	#endif
		internal static void registrationComplete(string id, string error)
		{
			if (RegistrationCallback == null)
				return;

			RegistrationCallback (id, error);
			RegistrationCallback = null;
		}
	}
}