#if UNITY_EDITOR

#elif UNITY_ANDROID
#define PLAYFAB_ANDROID_PLUGIN
#endif

using UnityEngine;

namespace PlayFab
{
	public class PlayFabGoogleCloudNotification
	{
	#if PLAYFAB_ANDROID_PLUGIN

		public static bool isAvailable() { return true; }

		private static AndroidJavaClass PushMessageClass;

		public static void init()
		{
			PushMessageClass = new AndroidJavaClass("com.playfab.unity.plugin.PushNotification"); 
		}

		public static void register(string senderIds)
		{
			PushMessageClass.CallStatic ("register", new object[] {senderIds});
		}

		public static void unregister(string senderIds)
		{
			PushMessageClass.CallStatic ("unregister");
		}

		public static bool isRegistered()
		{
			return PushMessageClass.CallStatic<bool>("isRegistered");
		}

		public static string getRegistrationId()
		{
			return PushMessageClass.CallStatic<string>("getRegistrationId");
		}

		public static void setRegisteredOnServer(bool isRegistered)
		{
			PushMessageClass.CallStatic("setRegisteredOnServer", new object[] {isRegistered});
		}

		public static bool isRegisteredOnServer()
		{
			return PushMessageClass.CallStatic<bool>("isRegisteredOnServer");
		}

		public static void setRegisterOnServerLifespan(long lifespan)
		{
			PushMessageClass.CallStatic ("setRegisterOnServerLifespan", new object[] {lifespan});
		}

		public static long getRegisterOnServerLifespan()
		{
			return PushMessageClass.CallStatic<long>("getRegisterOnServerLifespan");
		}

		public static void setNotificationsEnabled(bool enabled)
		{
			PushMessageClass.CallStatic("setNotificationsEnabled", new object[] {enabled});
		}

	#else

		public static bool isAvailable() { return false; }

		public static void init()
		{

		}
		
		public static void register(string senderIds)
		{

		}
		
		public static void unregister(string senderIds)
		{

		}
		
		public static bool isRegistered()
		{
			return false;
		}
		
		public static string getRegistrationId()
		{
			return null;
		}
		
		public static void setRegisteredOnServer(bool isRegistered)
		{

		}
		
		public static bool isRegisteredOnServer()
		{
			return false;
		}
		
		public static void setRegisterOnServerLifespan(long lifespan)
		{

		}
		
		public static long getRegisterOnServerLifespan()
		{
			return 0;
		}
		
		public static void setNotificationsEnabled(bool enabled)
		{

		}
	#endif
	}
}