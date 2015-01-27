package com.playfab.unity.plugin;

import java.io.IOException;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.util.Log;

import com.unity3d.player.UnityPlayer;

public class GoogleCloudMessaging {
	
	public static final String PROPERTY_REG_ID = "_PlayFab_GCM_RegistrationId";
	
	private static 	com.google.android.gms.gcm.GoogleCloudMessaging GCM;
	
	public static String getRegistrationId() {

	    final SharedPreferences prefs = AndroidPlugin.getPluginPreferences();
	    String registrationId = prefs.getString(PROPERTY_REG_ID, "");
	    if (registrationId.isEmpty()) {
	        Log.i(AndroidPlugin.TAG, "GCM Registration not found.");
	        return null;
	    }
	    // Check if app was updated; if so, it must clear the registration ID
	    // since the existing regID is not guaranteed to work with the new
	    // app version.
	    int registeredVersion = prefs.getInt(AndroidPlugin.PROPERTY_APP_VERSION, Integer.MIN_VALUE);
	    int currentVersion = AndroidPlugin.getAppVersion();
	    if (registeredVersion != currentVersion) {
	        Log.i(AndroidPlugin.TAG, "App version changed.");
	        return null;
	    }
	    return registrationId;
	}
	
	private static void storeRegistrationId(String regId) {
	    final SharedPreferences prefs = AndroidPlugin.getPluginPreferences();
	    int appVersion = AndroidPlugin.getAppVersion();
	    Log.i(AndroidPlugin.TAG, "Saving GCM regId on app version " + appVersion);
	    SharedPreferences.Editor editor = prefs.edit();
	    editor.putString(PROPERTY_REG_ID, regId);
	    editor.putInt(AndroidPlugin.PROPERTY_APP_VERSION, appVersion);
	    editor.commit();
	}
	
	/**
	 * Registers the application with GCM servers asynchronously.
	 * <p>
	 * Stores the registration ID and app versionCode in the application's
	 * shared preferences.
	 */
	public static void registerInBackground(final String senderId) {
	    new AsyncTask<Void, Void, Void>() {

			@Override
			protected Void doInBackground(Void... arg0) {
				Context context = UnityPlayer.currentActivity;
				
	            try {
	                if (GCM == null) {
	                	GCM = com.google.android.gms.gcm.GoogleCloudMessaging.getInstance(context);
	                }
	                
	                String regid = GCM.register(senderId);
	                
	                // Persist the regID - no need to register again.
	                storeRegistrationId( regid);
	                
	                UnityPlayer.UnitySendMessage("_PlayFabGO", "GCMRegistered", regid);
	                
	            } catch (IOException ex) {
	            	UnityPlayer.UnitySendMessage("_PlayFabGO", "GCMRegisterError", ex.getMessage());
	            }
				return null;  
			}
	        
	    }.execute(null, null, null);
	    
	}
}
