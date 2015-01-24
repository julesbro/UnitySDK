#!/bin/bash
set -x
export JAVA_HOME="$JAVA6_HOME"
ant jar
cp release/PlayFabUnityAndroid.jar ../../PlayFabClientSDK/Playfab/Plugins/Android
