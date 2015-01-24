package com.playfab.unity.plugin;

import java.util.Set;

import org.json.JSONException;
import org.json.JSONObject;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import com.google.android.gcm.GCMBaseIntentService;


public class PushNotificationIntentService extends GCMBaseIntentService {

	private static final String TAG = PushNotificationIntentService.class.getSimpleName();

	private static final String ON_ERROR = "OnError";
	private static final String ON_MESSAGE = "OnMessage";
	private static final String ON_REGISTERED = "OnRegistered";
	private static final String ON_UNREGISTERED = "OnUnregistered";
	
	private static final String ON_DELETE_MESSAGES = "OnDeleteMessages";

	@Override
	protected void onError(Context context, String errorId) {
		Log.v(TAG, "onError");
		PushNotificationUtil.sendMessage(ON_ERROR, errorId);
	}

	@Override
	protected void onMessage(Context context, Intent intent) {
		Log.v(TAG, "onMessage");
		// Notify to C# layer
		Bundle bundle = intent.getExtras();
		Set<String> keys = bundle.keySet();
		JSONObject json = new JSONObject();
		try {
			for (String key : keys) {
				Log.v(TAG, key + ": " + bundle.get(key));
				json.put(key, bundle.get(key));
			}
			PushNotificationUtil.sendMessage(ON_MESSAGE, json.toString());
		} catch (JSONException e) {
			e.printStackTrace();
		}
		
		if (!PushNotificationUtil.notificationsEnabled) {
			return;
		}
		
		// Show native notification view in status bar if defined fields are put.
		String contentTitle;
		try {
			contentTitle = json.getString("content_title");
			String contentText;
			try {
				contentText = json.getString("content_text");
			} catch (JSONException e) {
				contentText = "";
			}
			String ticker;
			try {
				ticker = json.getString("ticker");
			} catch (JSONException e) {
				ticker = contentTitle; // If no ticker specified, use title
			}
			PushNotificationManager.showNotification(this, contentTitle, contentText, ticker);
		} catch (JSONException e) {
			// Title is mandatory, do not display in status bar
			Log.v(TAG, "No content_title specified, not showing anything in Android status bar");
		}
	}

	@Override
	protected void onRegistered(Context context, String registrationId) {
		Log.v(TAG, "onRegistered");
		PushNotificationUtil.sendMessage(ON_REGISTERED, registrationId);
	}

	@Override
	protected void onUnregistered(Context context, String registrationId) {
		Log.v(TAG, "onUnregistered");
		PushNotificationUtil.sendMessage(ON_UNREGISTERED, registrationId);
	}
	
	@Override
	protected void onDeletedMessages (Context context, int total) {
		Log.v(TAG, "onDeleteMessages");
		PushNotificationUtil.sendMessage(ON_DELETE_MESSAGES, Integer.toString(total));
	}

}