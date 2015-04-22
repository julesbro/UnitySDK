UnitySDK README
========
1. Overview:
----
This document describes the process of configuring and building the PlayFab Unity plugin binary and distribution package. The document also contains instructions for developers to start using the plugin in their Unity games.


2. Prerequisites:
----
This document assumes familiarity with the Unity game engine, MonoDevelop Unity .NET programming environment, and Mac OS X operating system environment.

* Users should also be very familiar with the topics covered in our [getting started guide](https://playfab.com/getting-started).

3. Source Code & Key Repository Components:
----
The source code repository **playfab-unity** contains two main projects: PlayFabClientSDK and PlayFabServerSDK. The PlayFabClientSDK is the SDK you will integrate into your game project. The Server SDK is less commonly needed and is used to create custom administration tools.


4. Installation & Configuration Instructions:
----
#### Installation:
Create a new Unity project or open an existing Unity project. From the PlayFabClientSDK directory, drag the playfab/PlayFabSDK folder into your project's assets (anywhere is ok). You may optionally also install the Unity Editor tools by dragging the playfab/Editor directory into your project's assets.

After adding the PlayFabSDK directory, you will also want to install our native iOS and Android plugins. To do this, drag the Plugins folder to the root(Assets/Plugins) of the Unity project. 

With projects running on Unity3d < 5.0, you will want to stick to the standard folder structure (Assets/Plugins/iOS & Assets/Plugins/Android). This means that if you are already using plugins, you will need to merge the PlayFab files into your existing folder structure. 

#### Configuration:
You must configure the SDK with your unique TitleId, as assigned by the PlayFab developer portal. Your TitleId will be a short string that looks something like "8D34" in your Title URL.

Use 8D34 as a demonstration TitleId if you would like to try the various pre-made scenes without making and configurating your own title.

If you have installed the PlayFab editor tools, go to PlayFab->GameConfig and type in your TitleId and current CatalogVersion then Click Save.

If you'd prefer to configure the SDK via code, then somewhere in your game's startup code, add the following:

```
using PlayFab;

PlayFabSettings.TitleId = "your title id here";
```


5. Usage Instructions:
----
You are now ready to begin making API calls using the PlayFabClientAPI singleton. See the mini example for an idea of how this works, and check out the online documentation at http://api.playfab.com/Documentation/Client for a complete list of available APIs.


6. Troubleshooting:
----
For a complete list of available APIs, check out the [online documentation](http://api.playfab.com/Documentation/).

#### Contact Us
We love to hear from our developer community! 
Do you have ideas on how we can make our products and services better? 

Our Developer Success Team can assist with answering any questions as well as process any feedback you have about PlayFab services.

[Forums, Support and Knowlage Base](https://support.playfab.com/support/home)


7. Copyright and Licensing Information:
----
  Apache License -- 
  Version 2.0, January 2004
  http://www.apache.org/licenses/

  Full details available within the LICENSE file.

8. Version History:
----
* (v0.00) -- Initial upload