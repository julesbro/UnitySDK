package com.playfab.unity.plugin;


import android.content.Context;
import android.util.Log;

import com.google.android.gcm.GCMBroadcastReceiver;


public class PushNotificationReceiver extends GCMBroadcastReceiver {

	private static final String TAG = PushNotificationReceiver.class.getSimpleName();
	
	private static final String SERVICE_NAME = "com.playfab.unity.plugin.PushNotificationIntentService";
	
	/**
	 * Get the fixed name of subclass of GCMBaseIntentService
	 */
	@Override
	protected String getGCMIntentServiceClassName(Context context) {
		Log.v(TAG, "getGCMIntentServcieClassName");
		return SERVICE_NAME;
	}
}