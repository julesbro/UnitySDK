using System;
using System.Collections.Generic;
using PlayFab.Internal;
using PlayFab.Serialization.JsonFx;

namespace PlayFab.AdminModels
{
	
	
	
	public class AddNewsRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Time this news was published. If not set, defaults to now.
		/// </summary>
		
		public DateTime? Timestamp { get; set;}
		
		/// <summary>
		/// Title (headline) of the news item
		/// </summary>
		
		public string Title { get; set;}
		
		/// <summary>
		/// Body text of the news
		/// </summary>
		
		public string Body { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Timestamp", Timestamp);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Title", Title);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Body", Body);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Timestamp = (DateTime?)JsonUtil.GetDateTime(json, "Timestamp");
			Title = (string)JsonUtil.Get<string>(json, "Title");
			Body = (string)JsonUtil.Get<string>(json, "Body");
		}
	}
	
	
	
	public class AddNewsResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Unique id of the new news item
		/// </summary>
		
		public string NewsId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("NewsId", NewsId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			NewsId = (string)JsonUtil.Get<string>(json, "NewsId");
		}
	}
	
	
	
	public class AddServerBuildRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for the build executable
		/// </summary>
		
		public string BuildId { get; set;}
		
		/// <summary>
		/// appended to the end of the command line when starting game servers
		/// </summary>
		
		public string CommandLineTemplate { get; set;}
		
		/// <summary>
		/// path to the game server executable. Defaults to gameserver.exe
		/// </summary>
		
		public string ExecutablePath { get; set;}
		
		/// <summary>
		/// server host regions in which this build should be running and available
		/// </summary>
		
		public List<Region> ActiveRegions { get; set;}
		
		/// <summary>
		/// developer comment(s) for this build
		/// </summary>
		
		public string Comment { get; set;}
		
		/// <summary>
		/// maximum number of game server instances that can run on a single host machine
		/// </summary>
		
		public int MaxGamesPerHost { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CommandLineTemplate", CommandLineTemplate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ExecutablePath", ExecutablePath);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ActiveRegions", ActiveRegions);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Comment", Comment);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxGamesPerHost", MaxGamesPerHost);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
			CommandLineTemplate = (string)JsonUtil.Get<string>(json, "CommandLineTemplate");
			ExecutablePath = (string)JsonUtil.Get<string>(json, "ExecutablePath");
			ActiveRegions = JsonUtil.GetListEnum<Region>(json, "ActiveRegions");
			Comment = (string)JsonUtil.Get<string>(json, "Comment");
			MaxGamesPerHost = (int)JsonUtil.Get<double>(json, "MaxGamesPerHost");
		}
	}
	
	
	
	public class AddServerBuildResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for this build executable
		/// </summary>
		
		public string BuildId { get; set;}
		
		/// <summary>
		/// array of regions where this build can used, when it is active
		/// </summary>
		
		public List<Region> ActiveRegions { get; set;}
		
		/// <summary>
		/// maximum number of game server instances that can run on a single host machine
		/// </summary>
		
		public int MaxGamesPerHost { get; set;}
		
		/// <summary>
		/// appended to the end of the command line when starting game servers
		/// </summary>
		
		public string CommandLineTemplate { get; set;}
		
		/// <summary>
		/// path to the game server executable. Defaults to gameserver.exe
		/// </summary>
		
		public string ExecutablePath { get; set;}
		
		/// <summary>
		/// developer comment(s) for this build
		/// </summary>
		
		public string Comment { get; set;}
		
		/// <summary>
		/// time this build was last modified (or uploaded, if this build has never been modified)
		/// </summary>
		
		public DateTime Timestamp { get; set;}
		
		
		public string TitleId { get; set;}
		
		/// <summary>
		/// the current status of the build validation and processing steps
		/// </summary>
		
		public GameBuildStatus? Status { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ActiveRegions", ActiveRegions);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxGamesPerHost", MaxGamesPerHost);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CommandLineTemplate", CommandLineTemplate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ExecutablePath", ExecutablePath);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Comment", Comment);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Timestamp", Timestamp);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleId", TitleId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Status", Status);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
			ActiveRegions = JsonUtil.GetListEnum<Region>(json, "ActiveRegions");
			MaxGamesPerHost = (int)JsonUtil.Get<double>(json, "MaxGamesPerHost");
			CommandLineTemplate = (string)JsonUtil.Get<string>(json, "CommandLineTemplate");
			ExecutablePath = (string)JsonUtil.Get<string>(json, "ExecutablePath");
			Comment = (string)JsonUtil.Get<string>(json, "Comment");
			Timestamp = (DateTime)JsonUtil.GetDateTime(json, "Timestamp");
			TitleId = (string)JsonUtil.Get<string>(json, "TitleId");
			Status = (GameBuildStatus?)JsonUtil.GetEnum<GameBuildStatus>(json, "Status");
		}
	}
	
	
	
	public class AddUserVirtualCurrencyRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose virtual currency balance is to be increased.
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Name of the virtual currency which is to be incremented.
		/// </summary>
		
		public string VirtualCurrency { get; set;}
		
		/// <summary>
		/// Amount to be added to the user balance of the specified virtual currency.
		/// </summary>
		
		public int Amount { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrency", VirtualCurrency);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Amount", Amount);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			VirtualCurrency = (string)JsonUtil.Get<string>(json, "VirtualCurrency");
			Amount = (int)JsonUtil.Get<double>(json, "Amount");
		}
	}
	
	
	
	public class AddVirtualCurrencyTypesRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// List of virtual currencies and their initial deposits (the amount a user is granted when signing in for the first time) to the title
		/// </summary>
		
		public List<VirtualCurrencyData> VirtualCurrencies { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("VirtualCurrencies", VirtualCurrencies);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			VirtualCurrencies = JsonUtil.GetObjectList<VirtualCurrencyData>(json, "VirtualCurrencies");
		}
	}
	
	
	
	public class BlankResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	/// <summary>
	/// A purchasable item from the item catalog
	/// </summary>
	public class CatalogItem : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for this item
		/// </summary>
		
		public string ItemId { get; set;}
		
		/// <summary>
		/// class to which the item belongs
		/// </summary>
		
		public string ItemClass { get; set;}
		
		/// <summary>
		/// catalog item for this item
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		/// <summary>
		/// text name for the item, to show in-game
		/// </summary>
		
		public string DisplayName { get; set;}
		
		/// <summary>
		/// text description of item, to show in-game
		/// </summary>
		
		public string Description { get; set;}
		
		/// <summary>
		/// price of this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
		/// </summary>
		
		public Dictionary<string,uint> VirtualCurrencyPrices { get; set;}
		
		/// <summary>
		/// override prices for this item for specific currencies
		/// </summary>
		
		public Dictionary<string,uint> RealCurrencyPrices { get; set;}
		
		/// <summary>
		/// list of item tags
		/// </summary>
		
		public List<string> Tags { get; set;}
		
		/// <summary>
		/// game specific custom data
		/// </summary>
		
		public string CustomData { get; set;}
		
		/// <summary>
		/// array of ItemId values which are evaluated when any item is added to the player inventory - if all items in this array are present, the this item will also be added to the player inventory
		/// </summary>
		
		public List<string> GrantedIfPlayerHas { get; set;}
		
		/// <summary>
		/// defines the consumable properties (number of uses, timeout) for the item
		/// </summary>
		
		public CatalogItemConsumableInfo Consumable { get; set;}
		
		/// <summary>
		/// defines the container properties for the item - what items it contains, including random drop tables and virtual currencies, and what item (if any) is required to open it via the UnlockContainerItem API
		/// </summary>
		
		public CatalogItemContainerInfo Container { get; set;}
		
		/// <summary>
		/// defines the bundle properties for the item - bundles are items which contain other items, including random drop tables and virtual currencies
		/// </summary>
		
		public CatalogItemBundleInfo Bundle { get; set;}
		
		/// <summary>
		/// if true, then this item instance can be used to grant a character to a user.
		/// </summary>
		
		public bool CanBecomeCharacter { get; set;}
		
		/// <summary>
		/// if true, then only one item instance of this type will exist and its remaininguses will be incremented instead
		/// </summary>
		
		public bool IsStackable { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ItemId", ItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemClass", ItemClass);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("DisplayName", DisplayName);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Description", Description);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrencyPrices", VirtualCurrencyPrices);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RealCurrencyPrices", RealCurrencyPrices);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Tags", Tags);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CustomData", CustomData);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("GrantedIfPlayerHas", GrantedIfPlayerHas);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Consumable", Consumable);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Container", Container);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Bundle", Bundle);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CanBecomeCharacter", CanBecomeCharacter);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("IsStackable", IsStackable);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ItemId = (string)JsonUtil.Get<string>(json, "ItemId");
			ItemClass = (string)JsonUtil.Get<string>(json, "ItemClass");
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
			DisplayName = (string)JsonUtil.Get<string>(json, "DisplayName");
			Description = (string)JsonUtil.Get<string>(json, "Description");
			VirtualCurrencyPrices = JsonUtil.GetDictionaryUInt32(json, "VirtualCurrencyPrices");
			RealCurrencyPrices = JsonUtil.GetDictionaryUInt32(json, "RealCurrencyPrices");
			Tags = JsonUtil.GetList<string>(json, "Tags");
			CustomData = (string)JsonUtil.Get<string>(json, "CustomData");
			GrantedIfPlayerHas = JsonUtil.GetList<string>(json, "GrantedIfPlayerHas");
			Consumable = JsonUtil.GetObject<CatalogItemConsumableInfo>(json, "Consumable");
			Container = JsonUtil.GetObject<CatalogItemContainerInfo>(json, "Container");
			Bundle = JsonUtil.GetObject<CatalogItemBundleInfo>(json, "Bundle");
			CanBecomeCharacter = (bool)JsonUtil.Get<bool>(json, "CanBecomeCharacter");
			IsStackable = (bool)JsonUtil.Get<bool>(json, "IsStackable");
		}
	}
	
	
	
	public class CatalogItemBundleInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique ItemId values for all items which will be added to the player inventory when the bundle is added
		/// </summary>
		
		public List<string> BundledItems { get; set;}
		
		/// <summary>
		/// unique TableId values for all RandomResultTable objects which are part of the bundle (random tables will be resolved and add the relevant items to the player inventory when the bundle is added)
		/// </summary>
		
		public List<string> BundledResultTables { get; set;}
		
		/// <summary>
		/// virtual currency types and balances which will be added to the player inventory when the bundle is added
		/// </summary>
		
		public Dictionary<string,uint> BundledVirtualCurrencies { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BundledItems", BundledItems);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("BundledResultTables", BundledResultTables);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("BundledVirtualCurrencies", BundledVirtualCurrencies);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BundledItems = JsonUtil.GetList<string>(json, "BundledItems");
			BundledResultTables = JsonUtil.GetList<string>(json, "BundledResultTables");
			BundledVirtualCurrencies = JsonUtil.GetDictionaryUInt32(json, "BundledVirtualCurrencies");
		}
	}
	
	
	
	public class CatalogItemConsumableInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// number of times this object can be used, after which it will be removed from the player inventory
		/// </summary>
		
		public uint? UsageCount { get; set;}
		
		/// <summary>
		/// duration in seconds for how long the item will remain in the player inventory - once elapsed, the item will be removed
		/// </summary>
		
		public uint? UsagePeriod { get; set;}
		
		/// <summary>
		/// all inventory item instances in the player inventory sharing a non-null UsagePeriodGroup have their UsagePeriod values added together, and share the result - when that period has elapsed, all the items in the group will be removed
		/// </summary>
		
		public string UsagePeriodGroup { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("UsageCount", UsageCount);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("UsagePeriod", UsagePeriod);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("UsagePeriodGroup", UsagePeriodGroup);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			UsageCount = (uint?)JsonUtil.Get<double?>(json, "UsageCount");
			UsagePeriod = (uint?)JsonUtil.Get<double?>(json, "UsagePeriod");
			UsagePeriodGroup = (string)JsonUtil.Get<string>(json, "UsagePeriodGroup");
		}
	}
	
	
	
	/// <summary>
	/// Containers are inventory items that can hold other items defined in the catalog, as well as virtual currency, which is added to the player inventory when the container is unlocked, using the UnlockContainerItem API. The items can be anything defined in the catalog, as well as RandomResultTable objects which will be resolved when the container is unlocked. Containers and their keys should be defined as Consumable (having a limited number of uses) in their catalog defintiions, unless the intent is for the player to be able to re-use them infinitely.
	/// </summary>
	public class CatalogItemContainerInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// ItemId for the catalog item used to unlock the container, if any (if not specified, a call to UnlockContainerItem will open the container, adding the contents to the player inventory and currency balances)
		/// </summary>
		
		public string KeyItemId { get; set;}
		
		/// <summary>
		/// unique ItemId values for all items which will be added to the player inventory, once the container has been unlocked
		/// </summary>
		
		public List<string> ItemContents { get; set;}
		
		/// <summary>
		/// unique TableId values for all RandomResultTable objects which are part of the container (once unlocked, random tables will be resolved and add the relevant items to the player inventory)
		/// </summary>
		
		public List<string> ResultTableContents { get; set;}
		
		/// <summary>
		/// virtual currency types and balances which will be added to the player inventory when the container is unlocked
		/// </summary>
		
		public Dictionary<string,uint> VirtualCurrencyContents { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("KeyItemId", KeyItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemContents", ItemContents);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ResultTableContents", ResultTableContents);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrencyContents", VirtualCurrencyContents);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			KeyItemId = (string)JsonUtil.Get<string>(json, "KeyItemId");
			ItemContents = JsonUtil.GetList<string>(json, "ItemContents");
			ResultTableContents = JsonUtil.GetList<string>(json, "ResultTableContents");
			VirtualCurrencyContents = JsonUtil.GetDictionaryUInt32(json, "VirtualCurrencyContents");
		}
	}
	
	
	
	public class CloudScriptFile : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Name of the javascript file. These names are not used internally by the server, they are only for developer organizational purposes.
		/// </summary>
		
		public string Filename { get; set;}
		
		/// <summary>
		/// Contents of the Cloud Script javascript. Must be string-escaped javascript.
		/// </summary>
		
		public string FileContents { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Filename", Filename);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("FileContents", FileContents);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Filename = (string)JsonUtil.Get<string>(json, "Filename");
			FileContents = (string)JsonUtil.Get<string>(json, "FileContents");
		}
	}
	
	
	
	public class CloudScriptVersionStatus : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Version number
		/// </summary>
		
		public int Version { get; set;}
		
		/// <summary>
		/// Published code revision for this Cloud Script version
		/// </summary>
		
		public int PublishedRevision { get; set;}
		
		/// <summary>
		/// Most recent revision for this Cloud Script version
		/// </summary>
		
		public int LatestRevision { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PublishedRevision", PublishedRevision);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("LatestRevision", LatestRevision);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int)JsonUtil.Get<double>(json, "Version");
			PublishedRevision = (int)JsonUtil.Get<double>(json, "PublishedRevision");
			LatestRevision = (int)JsonUtil.Get<double>(json, "LatestRevision");
		}
	}
	
	
	
	public class ContentInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Key of the content
		/// </summary>
		
		public string Key { get; set;}
		
		/// <summary>
		/// Size of the content in bytes
		/// </summary>
		
		public long Size { get; set;}
		
		/// <summary>
		/// Last modified time
		/// </summary>
		
		public DateTime LastModified { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Size", Size);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("LastModified", LastModified);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Key = (string)JsonUtil.Get<string>(json, "Key");
			Size = (long)JsonUtil.Get<double>(json, "Size");
			LastModified = (DateTime)JsonUtil.GetDateTime(json, "LastModified");
		}
	}
	
	
	
	public enum Currency
	{
		USD,
		GBP,
		EUR,
		RUB,
		BRL,
		CIS,
		CAD
	}
	
	
	
	public class DeleteContentRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Key of the content item to be deleted
		/// </summary>
		
		public string Key { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Key = (string)JsonUtil.Get<string>(json, "Key");
		}
	}
	
	
	
	public enum GameBuildStatus
	{
		Available,
		Validating,
		InvalidBuildPackage,
		Processing,
		FailedToProcess
	}
	
	
	
	public class GameModeInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// specific game mode type
		/// </summary>
		
		public string Gamemode { get; set;}
		
		/// <summary>
		/// minimum user count required for this Game Server Instance to continue (usually 1)
		/// </summary>
		
		public uint MinPlayerCount { get; set;}
		
		/// <summary>
		/// maximum user count a specific Game Server Instance can support
		/// </summary>
		
		public uint MaxPlayerCount { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Gamemode", Gamemode);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MinPlayerCount", MinPlayerCount);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxPlayerCount", MaxPlayerCount);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Gamemode = (string)JsonUtil.Get<string>(json, "Gamemode");
			MinPlayerCount = (uint)JsonUtil.Get<double>(json, "MinPlayerCount");
			MaxPlayerCount = (uint)JsonUtil.Get<double>(json, "MaxPlayerCount");
		}
	}
	
	
	
	public class GetCatalogItemsRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// which catalog is being requested
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
		}
	}
	
	
	
	public class GetCatalogItemsResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of items which can be purchased
		/// </summary>
		
		public List<CatalogItem> Catalog { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Catalog", Catalog);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Catalog = JsonUtil.GetObjectList<CatalogItem>(json, "Catalog");
		}
	}
	
	
	
	public class GetCloudScriptRevisionRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Version number. If left null, defaults to the latest version
		/// </summary>
		
		public int? Version { get; set;}
		
		/// <summary>
		/// Revision number. If left null, defaults to the latest revision
		/// </summary>
		
		public int? Revision { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Revision", Revision);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int?)JsonUtil.Get<double?>(json, "Version");
			Revision = (int?)JsonUtil.Get<double?>(json, "Revision");
		}
	}
	
	
	
	public class GetCloudScriptRevisionResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Version number.
		/// </summary>
		
		public int Version { get; set;}
		
		/// <summary>
		/// Revision number.
		/// </summary>
		
		public int Revision { get; set;}
		
		/// <summary>
		/// Time this revision was created
		/// </summary>
		
		public DateTime CreatedAt { get; set;}
		
		/// <summary>
		/// List of Cloud Script files in this revision.
		/// </summary>
		
		public List<CloudScriptFile> Files { get; set;}
		
		/// <summary>
		/// True if this is the currently published revision
		/// </summary>
		
		public bool IsPublished { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Revision", Revision);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CreatedAt", CreatedAt);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Files", Files);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("IsPublished", IsPublished);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int)JsonUtil.Get<double>(json, "Version");
			Revision = (int)JsonUtil.Get<double>(json, "Revision");
			CreatedAt = (DateTime)JsonUtil.GetDateTime(json, "CreatedAt");
			Files = JsonUtil.GetObjectList<CloudScriptFile>(json, "Files");
			IsPublished = (bool)JsonUtil.Get<bool>(json, "IsPublished");
		}
	}
	
	
	
	public class GetCloudScriptVersionsRequest : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class GetCloudScriptVersionsResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// List of versions
		/// </summary>
		
		public List<CloudScriptVersionStatus> Versions { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Versions", Versions);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Versions = JsonUtil.GetObjectList<CloudScriptVersionStatus>(json, "Versions");
		}
	}
	
	
	
	public class GetContentListRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Limits the response to keys that begin with the specified prefix. You can use prefixes to list contents under a folder, or for a specified version, etc.
		/// </summary>
		
		public string Prefix { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Prefix", Prefix);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Prefix = (string)JsonUtil.Get<string>(json, "Prefix");
		}
	}
	
	
	
	public class GetContentListResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Number of content items returned. We currently have a maximum of 1000 items limit.
		/// </summary>
		
		public long ItemCount { get; set;}
		
		/// <summary>
		/// The total size of listed contents in bytes
		/// </summary>
		
		public long TotalSize { get; set;}
		
		
		public List<ContentInfo> Contents { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ItemCount", ItemCount);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TotalSize", TotalSize);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Contents", Contents);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ItemCount = (long)JsonUtil.Get<double>(json, "ItemCount");
			TotalSize = (long)JsonUtil.Get<double>(json, "TotalSize");
			Contents = JsonUtil.GetObjectList<ContentInfo>(json, "Contents");
		}
	}
	
	
	
	public class GetContentUploadUrlRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Key of the content item to upload, usually formatted as a path, e.g. images/a.png
		/// </summary>
		
		public string Key { get; set;}
		
		/// <summary>
		/// A standard MIME type describing the format of the contents. The same MIME type has to be set in the header when uploading the content.
		/// </summary>
		
		public string ContentType { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ContentType", ContentType);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Key = (string)JsonUtil.Get<string>(json, "Key");
			ContentType = (string)JsonUtil.Get<string>(json, "ContentType");
		}
	}
	
	
	
	public class GetContentUploadUrlResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// URL for uploading content via HTTP PUT method. The URL will expire in 1 hour.
		/// </summary>
		
		public string URL { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("URL", URL);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			URL = (string)JsonUtil.Get<string>(json, "URL");
		}
	}
	
	
	
	public class GetDataReportRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Report name
		/// </summary>
		
		public string ReportName { get; set;}
		
		/// <summary>
		/// Reporting year (UTC)
		/// </summary>
		
		public int Year { get; set;}
		
		/// <summary>
		/// Reporting month (UTC)
		/// </summary>
		
		public int Month { get; set;}
		
		/// <summary>
		/// Reporting year (UTC)
		/// </summary>
		
		public int Day { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ReportName", ReportName);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Year", Year);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Month", Month);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Day", Day);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ReportName = (string)JsonUtil.Get<string>(json, "ReportName");
			Year = (int)JsonUtil.Get<double>(json, "Year");
			Month = (int)JsonUtil.Get<double>(json, "Month");
			Day = (int)JsonUtil.Get<double>(json, "Day");
		}
	}
	
	
	
	public class GetDataReportResult : PlayFabModelBase
	{
		
		
		
		public string DownloadUrl { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("DownloadUrl", DownloadUrl);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			DownloadUrl = (string)JsonUtil.Get<string>(json, "DownloadUrl");
		}
	}
	
	
	
	public class GetMatchmakerGameInfoRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the lobby for which info is being requested
		/// </summary>
		
		public string LobbyId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("LobbyId", LobbyId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			LobbyId = (string)JsonUtil.Get<string>(json, "LobbyId");
		}
	}
	
	
	
	public class GetMatchmakerGameInfoResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the lobby 
		/// </summary>
		
		public string LobbyId { get; set;}
		
		/// <summary>
		/// unique identifier of the Game Server Instance for this lobby
		/// </summary>
		
		public string TitleId { get; set;}
		
		/// <summary>
		/// time when the Game Server Instance was created
		/// </summary>
		
		public DateTime StartTime { get; set;}
		
		/// <summary>
		/// time when Game Server Instance is currently scheduled to end
		/// </summary>
		
		public DateTime? EndTime { get; set;}
		
		/// <summary>
		/// game mode for this Game Server Instance
		/// </summary>
		
		public string Mode { get; set;}
		
		/// <summary>
		/// version identifier of the game server executable binary being run
		/// </summary>
		
		public string BuildVersion { get; set;}
		
		/// <summary>
		/// region in which the Game Server Instance is running
		/// </summary>
		
		public Region? Region { get; set;}
		
		/// <summary>
		/// array of unique PlayFab identifiers for users currently connected to this Game Server Instance
		/// </summary>
		
		public List<string> Players { get; set;}
		
		/// <summary>
		/// IP address for this Game Server Instance
		/// </summary>
		
		public string ServerAddress { get; set;}
		
		/// <summary>
		/// communication port for this Game Server Instance
		/// </summary>
		
		public uint ServerPort { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("LobbyId", LobbyId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleId", TitleId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("StartTime", StartTime);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("EndTime", EndTime);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Mode", Mode);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("BuildVersion", BuildVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Region", Region);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Players", Players);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ServerAddress", ServerAddress);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ServerPort", ServerPort);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			LobbyId = (string)JsonUtil.Get<string>(json, "LobbyId");
			TitleId = (string)JsonUtil.Get<string>(json, "TitleId");
			StartTime = (DateTime)JsonUtil.GetDateTime(json, "StartTime");
			EndTime = (DateTime?)JsonUtil.GetDateTime(json, "EndTime");
			Mode = (string)JsonUtil.Get<string>(json, "Mode");
			BuildVersion = (string)JsonUtil.Get<string>(json, "BuildVersion");
			Region = (Region?)JsonUtil.GetEnum<Region>(json, "Region");
			Players = JsonUtil.GetList<string>(json, "Players");
			ServerAddress = (string)JsonUtil.Get<string>(json, "ServerAddress");
			ServerPort = (uint)JsonUtil.Get<double>(json, "ServerPort");
		}
	}
	
	
	
	public class GetMatchmakerGameModesRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// previously uploaded build version for which game modes are being requested
		/// </summary>
		
		public string BuildVersion { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildVersion", BuildVersion);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildVersion = (string)JsonUtil.Get<string>(json, "BuildVersion");
		}
	}
	
	
	
	public class GetMatchmakerGameModesResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of game modes available for the specified build
		/// </summary>
		
		public List<GameModeInfo> GameModes { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("GameModes", GameModes);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			GameModes = JsonUtil.GetObjectList<GameModeInfo>(json, "GameModes");
		}
	}
	
	
	
	public class GetPublisherDataRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		///  array of keys to get back data from the Publisher data blob, set by the admin tools
		/// </summary>
		
		public List<string> Keys { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Keys", Keys);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Keys = JsonUtil.GetList<string>(json, "Keys");
		}
	}
	
	
	
	public class GetPublisherDataResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// a dictionary object of key / value pairs
		/// </summary>
		
		public Dictionary<string,string> Data { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Data", Data);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Data = JsonUtil.GetDictionary<string>(json, "Data");
		}
	}
	
	
	
	public class GetRandomResultTablesRequest : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class GetRandomResultTablesResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of random result tables currently available
		/// </summary>
		
		public Dictionary<string,RandomResultTable> Tables { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Tables", Tables);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Tables = JsonUtil.GetObjectDictionary<RandomResultTable>(json, "Tables");
		}
	}
	
	
	
	public class GetServerBuildInfoRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the previously uploaded build executable for which information is being requested
		/// </summary>
		
		public string BuildId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
		}
	}
	
	
	
	/// <summary>
	/// Information about a particular server build
	/// </summary>
	public class GetServerBuildInfoResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for this build executable
		/// </summary>
		
		public string BuildId { get; set;}
		
		/// <summary>
		/// array of regions where this build can used, when it is active
		/// </summary>
		
		public List<Region> ActiveRegions { get; set;}
		
		/// <summary>
		/// maximum number of game server instances that can run on a single host machine
		/// </summary>
		
		public int MaxGamesPerHost { get; set;}
		
		/// <summary>
		/// developer comment(s) for this build
		/// </summary>
		
		public string Comment { get; set;}
		
		/// <summary>
		/// time this build was last modified (or uploaded, if this build has never been modified)
		/// </summary>
		
		public DateTime Timestamp { get; set;}
		
		
		public string TitleId { get; set;}
		
		/// <summary>
		/// the current status of the build validation and processing steps
		/// </summary>
		
		public GameBuildStatus? Status { get; set;}
		
		/// <summary>
		/// error message, if any, about this build
		/// </summary>
		
		public string ErrorMessage { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ActiveRegions", ActiveRegions);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxGamesPerHost", MaxGamesPerHost);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Comment", Comment);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Timestamp", Timestamp);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleId", TitleId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Status", Status);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ErrorMessage", ErrorMessage);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
			ActiveRegions = JsonUtil.GetListEnum<Region>(json, "ActiveRegions");
			MaxGamesPerHost = (int)JsonUtil.Get<double>(json, "MaxGamesPerHost");
			Comment = (string)JsonUtil.Get<string>(json, "Comment");
			Timestamp = (DateTime)JsonUtil.GetDateTime(json, "Timestamp");
			TitleId = (string)JsonUtil.Get<string>(json, "TitleId");
			Status = (GameBuildStatus?)JsonUtil.GetEnum<GameBuildStatus>(json, "Status");
			ErrorMessage = (string)JsonUtil.Get<string>(json, "ErrorMessage");
		}
	}
	
	
	
	public class GetServerBuildUploadURLRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the game server build to upload
		/// </summary>
		
		public string BuildId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
		}
	}
	
	
	
	public class GetServerBuildUploadURLResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// pre-authorized URL for uploading the game server build package
		/// </summary>
		
		public string URL { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("URL", URL);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			URL = (string)JsonUtil.Get<string>(json, "URL");
		}
	}
	
	
	
	public class GetStoreItemsRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unqiue identifier for the store which is being requested
		/// </summary>
		
		public string StoreId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("StoreId", StoreId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			StoreId = (string)JsonUtil.Get<string>(json, "StoreId");
		}
	}
	
	
	
	public class GetStoreItemsResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of items which can be purchased from this store
		/// </summary>
		
		public List<StoreItem> Store { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Store", Store);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Store = JsonUtil.GetObjectList<StoreItem>(json, "Store");
		}
	}
	
	
	
	public class GetTitleDataRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		///  array of keys to get back data from the TitleData data blob, set by the admin tools
		/// </summary>
		
		public List<string> Keys { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Keys", Keys);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Keys = JsonUtil.GetList<string>(json, "Keys");
		}
	}
	
	
	
	public class GetTitleDataResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// a dictionary object of key / value pairs
		/// </summary>
		
		public Dictionary<string,string> Data { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Data", Data);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Data = JsonUtil.GetDictionary<string>(json, "Data");
		}
	}
	
	
	
	public class GetUserDataRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Specific keys to search for in the custom user data.
		/// </summary>
		
		public List<string> Keys { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Keys", Keys);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Keys = JsonUtil.GetList<string>(json, "Keys");
		}
	}
	
	
	
	public class GetUserDataResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose custom data is being returned.
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// User specific data for this title.
		/// </summary>
		
		public Dictionary<string,UserDataRecord> Data { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Data", Data);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Data = JsonUtil.GetObjectDictionary<UserDataRecord>(json, "Data");
		}
	}
	
	
	
	public class GetUserInventoryRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// used to limit results to only those from a specific catalog version
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
		}
	}
	
	
	
	public class GetUserInventoryResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of inventory items belonging to the user
		/// </summary>
		
		public List<ItemInstance> Inventory { get; set;}
		
		/// <summary>
		/// array of virtual currency balance(s) belonging to the user
		/// </summary>
		
		public Dictionary<string,int> VirtualCurrency { get; set;}
		
		/// <summary>
		/// Array of remaining times and timestamps for virtual currencies.
		/// </summary>
		
		public Dictionary<string,VirtualCurrencyRechargeTime> VirtualCurrencyRechargeTimes { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Inventory", Inventory);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrency", VirtualCurrency);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrencyRechargeTimes", VirtualCurrencyRechargeTimes);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Inventory = JsonUtil.GetObjectList<ItemInstance>(json, "Inventory");
			VirtualCurrency = JsonUtil.GetDictionaryInt32(json, "VirtualCurrency");
			VirtualCurrencyRechargeTimes = JsonUtil.GetObjectDictionary<VirtualCurrencyRechargeTime>(json, "VirtualCurrencyRechargeTimes");
		}
	}
	
	
	
	public class GrantItemsToUsersRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Catalog version from which items are to be granted.
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		/// <summary>
		/// Array of items to grant and the users to whom the items are to be granted.
		/// </summary>
		
		public List<ItemGrant> ItemGrants { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemGrants", ItemGrants);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
			ItemGrants = JsonUtil.GetObjectList<ItemGrant>(json, "ItemGrants");
		}
	}
	
	
	
	public class GrantItemsToUsersResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Array of items granted to users.
		/// </summary>
		
		public List<ItemGrantResult> ItemGrantResults { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ItemGrantResults", ItemGrantResults);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ItemGrantResults = JsonUtil.GetObjectList<ItemGrantResult>(json, "ItemGrantResults");
		}
	}
	
	
	
	public class ItemGrant : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Unique identifier of the catalog item to be granted to the user.
		/// </summary>
		
		public string ItemId { get; set;}
		
		/// <summary>
		/// String detailing any additional information concerning this operation.
		/// </summary>
		
		public string Annotation { get; set;}
		
		
		public string CharacterId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemId", ItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Annotation", Annotation);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CharacterId", CharacterId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			ItemId = (string)JsonUtil.Get<string>(json, "ItemId");
			Annotation = (string)JsonUtil.Get<string>(json, "Annotation");
			CharacterId = (string)JsonUtil.Get<string>(json, "CharacterId");
		}
	}
	
	
	
	/// <summary>
	/// Result of granting an item to a user
	/// </summary>
	public class ItemGrantResult : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Unique identifier of the catalog item to be granted to the user.
		/// </summary>
		
		public string ItemId { get; set;}
		
		/// <summary>
		/// Unique instance Id of the granted item.
		/// </summary>
		
		public string ItemInstanceId { get; set;}
		
		/// <summary>
		/// String detailing any additional information concerning this operation.
		/// </summary>
		
		public string Annotation { get; set;}
		
		/// <summary>
		/// Result of this operation.
		/// </summary>
		
		public bool Result { get; set;}
		
		
		public string CharacterId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemId", ItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemInstanceId", ItemInstanceId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Annotation", Annotation);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Result", Result);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CharacterId", CharacterId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			ItemId = (string)JsonUtil.Get<string>(json, "ItemId");
			ItemInstanceId = (string)JsonUtil.Get<string>(json, "ItemInstanceId");
			Annotation = (string)JsonUtil.Get<string>(json, "Annotation");
			Result = (bool)JsonUtil.Get<bool>(json, "Result");
			CharacterId = (string)JsonUtil.Get<string>(json, "CharacterId");
		}
	}
	
	
	
	/// <summary>
	/// A unique instance of an item in a user's inventory
	/// </summary>
	public class ItemInstance : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for the inventory item, as defined in the catalog
		/// </summary>
		
		public string ItemId { get; set;}
		
		/// <summary>
		/// unique item identifier for this specific instance of the item
		/// </summary>
		
		public string ItemInstanceId { get; set;}
		
		/// <summary>
		/// class name for the inventory item, as defined in the catalog
		/// </summary>
		
		public string ItemClass { get; set;}
		
		/// <summary>
		/// timestamp for when this instance was purchased
		/// </summary>
		
		public DateTime? PurchaseDate { get; set;}
		
		/// <summary>
		/// timestamp for when this instance will expire
		/// </summary>
		
		public DateTime? Expiration { get; set;}
		
		/// <summary>
		/// total number of remaining uses, if this is a consumable item
		/// </summary>
		
		public int? RemainingUses { get; set;}
		
		/// <summary>
		/// game specific comment associated with this instance when it was added to the user inventory
		/// </summary>
		
		public string Annotation { get; set;}
		
		/// <summary>
		/// catalog version for the inventory item, when this instance was created
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		/// <summary>
		/// unique identifier for the parent inventory item, as defined in the catalog, for object which were added from a bundle or container
		/// </summary>
		
		public string BundleParent { get; set;}
		
		/// <summary>
		/// a set of custom key-value pairs on the inventory item
		/// </summary>
		
		public Dictionary<string,string> CustomData { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ItemId", ItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemInstanceId", ItemInstanceId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemClass", ItemClass);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PurchaseDate", PurchaseDate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Expiration", Expiration);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RemainingUses", RemainingUses);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Annotation", Annotation);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("BundleParent", BundleParent);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CustomData", CustomData);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ItemId = (string)JsonUtil.Get<string>(json, "ItemId");
			ItemInstanceId = (string)JsonUtil.Get<string>(json, "ItemInstanceId");
			ItemClass = (string)JsonUtil.Get<string>(json, "ItemClass");
			PurchaseDate = (DateTime?)JsonUtil.GetDateTime(json, "PurchaseDate");
			Expiration = (DateTime?)JsonUtil.GetDateTime(json, "Expiration");
			RemainingUses = (int?)JsonUtil.Get<double?>(json, "RemainingUses");
			Annotation = (string)JsonUtil.Get<string>(json, "Annotation");
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
			BundleParent = (string)JsonUtil.Get<string>(json, "BundleParent");
			CustomData = JsonUtil.GetDictionary<string>(json, "CustomData");
		}
	}
	
	
	
	public class ListBuildsRequest : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class ListBuildsResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of uploaded game server builds
		/// </summary>
		
		public List<GetServerBuildInfoResult> Builds { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Builds", Builds);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Builds = JsonUtil.GetObjectList<GetServerBuildInfoResult>(json, "Builds");
		}
	}
	
	
	
	public class ListVirtualCurrencyTypesRequest : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class ListVirtualCurrencyTypesResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// List of virtual currency names defined for this title
		/// </summary>
		
		public List<VirtualCurrencyData> VirtualCurrencies { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("VirtualCurrencies", VirtualCurrencies);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			VirtualCurrencies = JsonUtil.GetObjectList<VirtualCurrencyData>(json, "VirtualCurrencies");
		}
	}
	
	
	
	public class LookupUserAccountInfoRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		
		public string Email { get; set;}
		
		
		public string Username { get; set;}
		
		/// <summary>
		/// title-specific username to match against existing user accounts
		/// </summary>
		
		public string TitleDisplayName { get; set;}
		
		
		public string PublisherId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Email", Email);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Username", Username);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleDisplayName", TitleDisplayName);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PublisherId", PublisherId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Email = (string)JsonUtil.Get<string>(json, "Email");
			Username = (string)JsonUtil.Get<string>(json, "Username");
			TitleDisplayName = (string)JsonUtil.Get<string>(json, "TitleDisplayName");
			PublisherId = (string)JsonUtil.Get<string>(json, "PublisherId");
		}
	}
	
	
	
	public class LookupUserAccountInfoResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// user info for the user matching the request
		/// </summary>
		
		public UserAccountInfo UserInfo { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("UserInfo", UserInfo);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			UserInfo = JsonUtil.GetObject<UserAccountInfo>(json, "UserInfo");
		}
	}
	
	
	
	public class ModifyMatchmakerGameModesRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// previously uploaded build version for which game modes are being specified
		/// </summary>
		
		public string BuildVersion { get; set;}
		
		/// <summary>
		/// array of game modes (Note: this will replace all game modes for the indicated build version)
		/// </summary>
		
		public List<GameModeInfo> GameModes { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildVersion", BuildVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("GameModes", GameModes);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildVersion = (string)JsonUtil.Get<string>(json, "BuildVersion");
			GameModes = JsonUtil.GetObjectList<GameModeInfo>(json, "GameModes");
		}
	}
	
	
	
	public class ModifyMatchmakerGameModesResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class ModifyServerBuildRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the previously uploaded build executable to be updated
		/// </summary>
		
		public string BuildId { get; set;}
		
		/// <summary>
		/// new timestamp
		/// </summary>
		
		public DateTime? Timestamp { get; set;}
		
		/// <summary>
		/// array of regions where this build can used, when it is active
		/// </summary>
		
		public List<Region> ActiveRegions { get; set;}
		
		/// <summary>
		/// maximum number of game server instances that can run on a single host machine
		/// </summary>
		
		public int MaxGamesPerHost { get; set;}
		
		/// <summary>
		/// appended to the end of the command line when starting game servers
		/// </summary>
		
		public string CommandLineTemplate { get; set;}
		
		/// <summary>
		/// path to the game server executable. Defaults to gameserver.exe
		/// </summary>
		
		public string ExecutablePath { get; set;}
		
		/// <summary>
		/// developer comment(s) for this build
		/// </summary>
		
		public string Comment { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Timestamp", Timestamp);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ActiveRegions", ActiveRegions);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxGamesPerHost", MaxGamesPerHost);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CommandLineTemplate", CommandLineTemplate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ExecutablePath", ExecutablePath);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Comment", Comment);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
			Timestamp = (DateTime?)JsonUtil.GetDateTime(json, "Timestamp");
			ActiveRegions = JsonUtil.GetListEnum<Region>(json, "ActiveRegions");
			MaxGamesPerHost = (int)JsonUtil.Get<double>(json, "MaxGamesPerHost");
			CommandLineTemplate = (string)JsonUtil.Get<string>(json, "CommandLineTemplate");
			ExecutablePath = (string)JsonUtil.Get<string>(json, "ExecutablePath");
			Comment = (string)JsonUtil.Get<string>(json, "Comment");
		}
	}
	
	
	
	public class ModifyServerBuildResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for this build executable
		/// </summary>
		
		public string BuildId { get; set;}
		
		/// <summary>
		/// array of regions where this build can used, when it is active
		/// </summary>
		
		public List<Region> ActiveRegions { get; set;}
		
		/// <summary>
		/// maximum number of game server instances that can run on a single host machine
		/// </summary>
		
		public int MaxGamesPerHost { get; set;}
		
		/// <summary>
		/// appended to the end of the command line when starting game servers
		/// </summary>
		
		public string CommandLineTemplate { get; set;}
		
		/// <summary>
		/// path to the game server executable. Defaults to gameserver.exe
		/// </summary>
		
		public string ExecutablePath { get; set;}
		
		/// <summary>
		/// developer comment(s) for this build
		/// </summary>
		
		public string Comment { get; set;}
		
		/// <summary>
		/// time this build was last modified (or uploaded, if this build has never been modified)
		/// </summary>
		
		public DateTime Timestamp { get; set;}
		
		
		public string TitleId { get; set;}
		
		/// <summary>
		/// the current status of the build validation and processing steps
		/// </summary>
		
		public GameBuildStatus? Status { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ActiveRegions", ActiveRegions);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("MaxGamesPerHost", MaxGamesPerHost);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("CommandLineTemplate", CommandLineTemplate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ExecutablePath", ExecutablePath);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Comment", Comment);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Timestamp", Timestamp);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleId", TitleId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Status", Status);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
			ActiveRegions = JsonUtil.GetListEnum<Region>(json, "ActiveRegions");
			MaxGamesPerHost = (int)JsonUtil.Get<double>(json, "MaxGamesPerHost");
			CommandLineTemplate = (string)JsonUtil.Get<string>(json, "CommandLineTemplate");
			ExecutablePath = (string)JsonUtil.Get<string>(json, "ExecutablePath");
			Comment = (string)JsonUtil.Get<string>(json, "Comment");
			Timestamp = (DateTime)JsonUtil.GetDateTime(json, "Timestamp");
			TitleId = (string)JsonUtil.Get<string>(json, "TitleId");
			Status = (GameBuildStatus?)JsonUtil.GetEnum<GameBuildStatus>(json, "Status");
		}
	}
	
	
	
	public class ModifyUserVirtualCurrencyResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// User currency was subtracted from.
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Name of the virtual currency which was modified.
		/// </summary>
		
		public string VirtualCurrency { get; set;}
		
		/// <summary>
		/// Amount added or subtracted from the user's virtual currency.
		/// </summary>
		
		public int BalanceChange { get; set;}
		
		/// <summary>
		/// Balance of the virtual currency after modification.
		/// </summary>
		
		public int Balance { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrency", VirtualCurrency);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("BalanceChange", BalanceChange);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Balance", Balance);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			VirtualCurrency = (string)JsonUtil.Get<string>(json, "VirtualCurrency");
			BalanceChange = (int)JsonUtil.Get<double>(json, "BalanceChange");
			Balance = (int)JsonUtil.Get<double>(json, "Balance");
		}
	}
	
	
	
	public class RandomResultTable : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Unique name for this drop table
		/// </summary>
		
		public string TableId { get; set;}
		
		/// <summary>
		/// Child nodes that indicate what kind of drop table item this actually is.
		/// </summary>
		
		public List<ResultTableNode> Nodes { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("TableId", TableId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Nodes", Nodes);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			TableId = (string)JsonUtil.Get<string>(json, "TableId");
			Nodes = JsonUtil.GetObjectList<ResultTableNode>(json, "Nodes");
		}
	}
	
	
	
	public enum Region
	{
		USCentral,
		USEast,
		EUWest,
		Singapore,
		Japan,
		Brazil,
		Australia
	}
	
	
	
	public class RemoveServerBuildRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the previously uploaded build executable to be removed
		/// </summary>
		
		public string BuildId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("BuildId", BuildId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			BuildId = (string)JsonUtil.Get<string>(json, "BuildId");
		}
	}
	
	
	
	public class RemoveServerBuildResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class ResetUsersRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Array of users to reset
		/// </summary>
		
		public List<UserCredentials> Users { get; set;}
		
		
		public string PublisherId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Users", Users);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PublisherId", PublisherId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Users = JsonUtil.GetObjectList<UserCredentials>(json, "Users");
			PublisherId = (string)JsonUtil.Get<string>(json, "PublisherId");
		}
	}
	
	
	
	public class ResetUserStatisticsRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
		}
	}
	
	
	
	public class ResetUserStatisticsResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class ResultTableNode : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Whether this entry in the table is an item or a link to another table
		/// </summary>
		
		public ResultTableNodeType ResultItemType { get; set;}
		
		/// <summary>
		/// Either an ItemId, or the TableId of another random result table
		/// </summary>
		
		public string ResultItem { get; set;}
		
		/// <summary>
		/// How likely this is to be rolled - larger numbers add more weight
		/// </summary>
		
		public int Weight { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ResultItemType", ResultItemType);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ResultItem", ResultItem);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Weight", Weight);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ResultItemType = (ResultTableNodeType)JsonUtil.GetEnum<ResultTableNodeType>(json, "ResultItemType");
			ResultItem = (string)JsonUtil.Get<string>(json, "ResultItem");
			Weight = (int)JsonUtil.Get<double>(json, "Weight");
		}
	}
	
	
	
	public enum ResultTableNodeType
	{
		ItemId,
		TableId
	}
	
	
	
	public class RevokeInventoryItemRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique PlayFab identifier for the user account which is to have the specified item removed
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// unique PlayFab identifier for the item instance to be removed
		/// </summary>
		
		public string ItemInstanceId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("ItemInstanceId", ItemInstanceId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			ItemInstanceId = (string)JsonUtil.Get<string>(json, "ItemInstanceId");
		}
	}
	
	
	
	public class RevokeInventoryResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class SendAccountRecoveryEmailRequest : PlayFabModelBase
	{
		
		
		
		public string Email { get; set;}
		
		
		public string PublisherId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Email", Email);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PublisherId", PublisherId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Email = (string)JsonUtil.Get<string>(json, "Email");
			PublisherId = (string)JsonUtil.Get<string>(json, "PublisherId");
		}
	}
	
	
	
	public class SendAccountRecoveryEmailResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class SetPublishedRevisionRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Version number
		/// </summary>
		
		public int Version { get; set;}
		
		/// <summary>
		/// Revision to make the current published revision
		/// </summary>
		
		public int Revision { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Revision", Revision);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int)JsonUtil.Get<double>(json, "Version");
			Revision = (int)JsonUtil.Get<double>(json, "Revision");
		}
	}
	
	
	
	public class SetPublishedRevisionResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class SetPublisherDataRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// key we want to set a value on (note, this is additive - will only replace an existing key's value if they are the same name.) Keys are trimmed of whitespace. Keys may not begin with the '!' character.
		/// </summary>
		
		public string Key { get; set;}
		
		/// <summary>
		/// new value to set. Set to null to remove a value
		/// </summary>
		
		public string Value { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Value", Value);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Key = (string)JsonUtil.Get<string>(json, "Key");
			Value = (string)JsonUtil.Get<string>(json, "Value");
		}
	}
	
	
	
	public class SetPublisherDataResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class SetTitleDataRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// key we want to set a value on (note, this is additive - will only replace an existing key's value if they are the same name.) Keys are trimmed of whitespace. Keys may not begin with the '!' character.
		/// </summary>
		
		public string Key { get; set;}
		
		/// <summary>
		/// new value to set. Set to null to remove a value
		/// </summary>
		
		public string Value { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Value", Value);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Key = (string)JsonUtil.Get<string>(json, "Key");
			Value = (string)JsonUtil.Get<string>(json, "Value");
		}
	}
	
	
	
	public class SetTitleDataResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class SetupPushNotificationRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// name of the application sending the message (application names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, hyphens, and periods, and must be between 1 and 256 characters long)
		/// </summary>
		
		public string Name { get; set;}
		
		/// <summary>
		/// supported notification platforms are Apple Push Notification Service (APNS and APNS_SANDBOX) for iOS and Google Cloud Messaging (GCM) for Android
		/// </summary>
		
		public string Platform { get; set;}
		
		/// <summary>
		/// for APNS, this is the PlatformPrincipal (SSL Certificate)
		/// </summary>
		
		public string Key { get; set;}
		
		/// <summary>
		/// Credential is the Private Key for APNS/APNS_SANDBOX, and the API Key for GCM
		/// </summary>
		
		public string Credential { get; set;}
		
		/// <summary>
		/// replace any existing ARN with the newly generated one. If this is set to false, an error will be returned if notifications have already setup for this platform.
		/// </summary>
		
		public bool OverwriteOldARN { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Name", Name);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Platform", Platform);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Key", Key);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Credential", Credential);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("OverwriteOldARN", OverwriteOldARN);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Name = (string)JsonUtil.Get<string>(json, "Name");
			Platform = (string)JsonUtil.Get<string>(json, "Platform");
			Key = (string)JsonUtil.Get<string>(json, "Key");
			Credential = (string)JsonUtil.Get<string>(json, "Credential");
			OverwriteOldARN = (bool)JsonUtil.Get<bool>(json, "OverwriteOldARN");
		}
	}
	
	
	
	public class SetupPushNotificationResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Amazon Resource Name for the created notification topic.
		/// </summary>
		
		public string ARN { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ARN", ARN);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ARN = (string)JsonUtil.Get<string>(json, "ARN");
		}
	}
	
	
	
	/// <summary>
	/// A store entry that list a catalog item at a particular price
	/// </summary>
	public class StoreItem : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the item as it exists in the catalog - note that this must exactly match the ItemId from the catalog
		/// </summary>
		
		public string ItemId { get; set;}
		
		/// <summary>
		/// price of this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
		/// </summary>
		
		public Dictionary<string,uint> VirtualCurrencyPrices { get; set;}
		
		/// <summary>
		/// override prices for this item for specific currencies
		/// </summary>
		
		public Dictionary<string,uint> RealCurrencyPrices { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("ItemId", ItemId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrencyPrices", VirtualCurrencyPrices);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RealCurrencyPrices", RealCurrencyPrices);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ItemId = (string)JsonUtil.Get<string>(json, "ItemId");
			VirtualCurrencyPrices = JsonUtil.GetDictionaryUInt32(json, "VirtualCurrencyPrices");
			RealCurrencyPrices = JsonUtil.GetDictionaryUInt32(json, "RealCurrencyPrices");
		}
	}
	
	
	
	public class SubtractUserVirtualCurrencyRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose virtual currency balance is to be decreased.
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Name of the virtual currency which is to be decremented.
		/// </summary>
		
		public string VirtualCurrency { get; set;}
		
		/// <summary>
		/// Amount to be subtracted from the user balance of the specified virtual currency.
		/// </summary>
		
		public int Amount { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("VirtualCurrency", VirtualCurrency);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Amount", Amount);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			VirtualCurrency = (string)JsonUtil.Get<string>(json, "VirtualCurrency");
			Amount = (int)JsonUtil.Get<double>(json, "Amount");
		}
	}
	
	
	
	public enum TitleActivationStatus
	{
		None,
		ActivatedTitleKey,
		PendingSteam,
		ActivatedSteam,
		RevokedSteam
	}
	
	
	
	public class UpdateCatalogItemsRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// which catalog is being updated
		/// </summary>
		
		public string CatalogVersion { get; set;}
		
		/// <summary>
		/// array of catalog items to be submitted
		/// </summary>
		
		public List<CatalogItem> Catalog { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("CatalogVersion", CatalogVersion);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Catalog", Catalog);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			CatalogVersion = (string)JsonUtil.Get<string>(json, "CatalogVersion");
			Catalog = JsonUtil.GetObjectList<CatalogItem>(json, "Catalog");
		}
	}
	
	
	
	public class UpdateCatalogItemsResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class UpdateCloudScriptRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Cloud Script version to update. If null, defaults to most recent version
		/// </summary>
		
		public int? Version { get; set;}
		
		/// <summary>
		/// List of Cloud Script files to upload to create the new revision. Must have at least one file.
		/// </summary>
		
		public List<CloudScriptFile> Files { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Files", Files);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int?)JsonUtil.Get<double?>(json, "Version");
			Files = JsonUtil.GetObjectList<CloudScriptFile>(json, "Files");
		}
	}
	
	
	
	public class UpdateCloudScriptResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Cloud Script version updated
		/// </summary>
		
		public int Version { get; set;}
		
		/// <summary>
		/// New revision number created
		/// </summary>
		
		public int Revision { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Version", Version);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Revision", Revision);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Version = (int)JsonUtil.Get<double>(json, "Version");
			Revision = (int)JsonUtil.Get<double>(json, "Revision");
		}
	}
	
	
	
	public class UpdateRandomResultTablesRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// array of random result tables to make available (Note: specifying an existing TableId will result in overwriting that table, while any others will be added to the available set)
		/// </summary>
		
		public List<RandomResultTable> Tables { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Tables", Tables);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Tables = JsonUtil.GetObjectList<RandomResultTable>(json, "Tables");
		}
	}
	
	
	
	public class UpdateRandomResultTablesResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class UpdateStoreItemsRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unqiue identifier for the store which is to be updated
		/// </summary>
		
		public string StoreId { get; set;}
		
		/// <summary>
		/// array of store items - references to catalog items, with specific pricing - to be added
		/// </summary>
		
		public List<StoreItem> Store { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("StoreId", StoreId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Store", Store);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			StoreId = (string)JsonUtil.Get<string>(json, "StoreId");
			Store = JsonUtil.GetObjectList<StoreItem>(json, "Store");
		}
	}
	
	
	
	public class UpdateStoreItemsResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class UpdateUserDataRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Data to be written to the user's custom data. Note that keys are trimmed of whitespace, are limited to 1024 characters, and may not begin with a '!' character.
		/// </summary>
		
		public Dictionary<string,string> Data { get; set;}
		
		/// <summary>
		/// Permission to be applied to all user data keys written in this request. Defaults to "private" if not set.
		/// </summary>
		
		public UserDataPermission? Permission { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Data", Data);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Permission", Permission);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Data = JsonUtil.GetDictionary<string>(json, "Data");
			Permission = (UserDataPermission?)JsonUtil.GetEnum<UserDataPermission>(json, "Permission");
		}
	}
	
	
	
	public class UpdateUserDataResult : PlayFabModelBase
	{
		
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
		}
	}
	
	
	
	public class UpdateUserInternalDataRequest : PlayFabModelBase
	{
		
		
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// Data to be written to the user's custom data.
		/// </summary>
		
		public Dictionary<string,string> Data { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Data", Data);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Data = JsonUtil.GetDictionary<string>(json, "Data");
		}
	}
	
	
	
	public class UpdateUserTitleDisplayNameRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose title specific display name is to be changed
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// new title display name for the user - must be between 3 and 25 characters
		/// </summary>
		
		public string DisplayName { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("DisplayName", DisplayName);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			DisplayName = (string)JsonUtil.Get<string>(json, "DisplayName");
		}
	}
	
	
	
	public class UpdateUserTitleDisplayNameResult : PlayFabModelBase
	{
		
		
		/// <summary>
		/// current title display name for the user (this will be the original display name if the rename attempt failed)
		/// </summary>
		
		public string DisplayName { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("DisplayName", DisplayName);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			DisplayName = (string)JsonUtil.Get<string>(json, "DisplayName");
		}
	}
	
	
	
	public class UserAccountInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier for the user account
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// timestamp indicating when the user account was created
		/// </summary>
		
		public DateTime Created { get; set;}
		
		/// <summary>
		/// user account name in the PlayFab service
		/// </summary>
		
		public string Username { get; set;}
		
		/// <summary>
		/// title-specific information for the user account
		/// </summary>
		
		public UserTitleInfo TitleInfo { get; set;}
		
		/// <summary>
		/// personal information for the user which is considered more sensitive
		/// </summary>
		
		public UserPrivateAccountInfo PrivateInfo { get; set;}
		
		/// <summary>
		/// user Facebook information, if a Facebook account has been linked
		/// </summary>
		
		public UserFacebookInfo FacebookInfo { get; set;}
		
		/// <summary>
		/// user Steam information, if a Steam account has been linked
		/// </summary>
		
		public UserSteamInfo SteamInfo { get; set;}
		
		/// <summary>
		/// user Gamecenter information, if a Gamecenter account has been linked
		/// </summary>
		
		public UserGameCenterInfo GameCenterInfo { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("PlayFabId", PlayFabId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Created", Created);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Username", Username);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("TitleInfo", TitleInfo);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("PrivateInfo", PrivateInfo);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("FacebookInfo", FacebookInfo);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("SteamInfo", SteamInfo);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("GameCenterInfo", GameCenterInfo);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
			Created = (DateTime)JsonUtil.GetDateTime(json, "Created");
			Username = (string)JsonUtil.Get<string>(json, "Username");
			TitleInfo = JsonUtil.GetObject<UserTitleInfo>(json, "TitleInfo");
			PrivateInfo = JsonUtil.GetObject<UserPrivateAccountInfo>(json, "PrivateInfo");
			FacebookInfo = JsonUtil.GetObject<UserFacebookInfo>(json, "FacebookInfo");
			SteamInfo = JsonUtil.GetObject<UserSteamInfo>(json, "SteamInfo");
			GameCenterInfo = JsonUtil.GetObject<UserGameCenterInfo>(json, "GameCenterInfo");
		}
	}
	
	
	
	public class UserCredentials : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Username of user to reset
		/// </summary>
		
		public string Username { get; set;}
		
		
		public string Password { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Username", Username);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Password", Password);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Username = (string)JsonUtil.Get<string>(json, "Username");
			Password = (string)JsonUtil.Get<string>(json, "Password");
		}
	}
	
	
	
	public enum UserDataPermission
	{
		Private,
		Public
	}
	
	
	
	public class UserDataRecord : PlayFabModelBase
	{
		
		
		/// <summary>
		/// User-supplied data for this user data key.
		/// </summary>
		
		public string Value { get; set;}
		
		/// <summary>
		/// Timestamp indicating when this data was last updated.
		/// </summary>
		
		public DateTime LastUpdated { get; set;}
		
		/// <summary>
		/// Permissions on this data key.
		/// </summary>
		
		public UserDataPermission? Permission { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Value", Value);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("LastUpdated", LastUpdated);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Permission", Permission);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Value = (string)JsonUtil.Get<string>(json, "Value");
			LastUpdated = (DateTime)JsonUtil.GetDateTime(json, "LastUpdated");
			Permission = (UserDataPermission?)JsonUtil.GetEnum<UserDataPermission>(json, "Permission");
		}
	}
	
	
	
	public class UserFacebookInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Facebook identifier
		/// </summary>
		
		public string FacebookId { get; set;}
		
		/// <summary>
		/// Facebook full name
		/// </summary>
		
		public string FullName { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("FacebookId", FacebookId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("FullName", FullName);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			FacebookId = (string)JsonUtil.Get<string>(json, "FacebookId");
			FullName = (string)JsonUtil.Get<string>(json, "FullName");
		}
	}
	
	
	
	public class UserGameCenterInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Gamecenter identifier
		/// </summary>
		
		public string GameCenterId { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("GameCenterId", GameCenterId);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			GameCenterId = (string)JsonUtil.Get<string>(json, "GameCenterId");
		}
	}
	
	
	
	public enum UserOrigination
	{
		Organic,
		Steam,
		Google,
		Amazon,
		Facebook,
		Kongregate,
		GamersFirst,
		Unknown,
		IOS,
		LoadTest,
		Android,
		PSN,
		GameCenter
	}
	
	
	
	public class UserPrivateAccountInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// user email address
		/// </summary>
		
		public string Email { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("Email", Email);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			Email = (string)JsonUtil.Get<string>(json, "Email");
		}
	}
	
	
	
	public class UserSteamInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Steam identifier
		/// </summary>
		
		public string SteamId { get; set;}
		
		/// <summary>
		/// the country in which the player resides, from Steam data
		/// </summary>
		
		public string SteamCountry { get; set;}
		
		/// <summary>
		/// currency type set in the user Steam account
		/// </summary>
		
		public Currency? SteamCurrency { get; set;}
		
		/// <summary>
		/// what stage of game ownership the user is listed as being in, from Steam
		/// </summary>
		
		public TitleActivationStatus? SteamActivationStatus { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("SteamId", SteamId);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("SteamCountry", SteamCountry);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("SteamCurrency", SteamCurrency);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("SteamActivationStatus", SteamActivationStatus);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			SteamId = (string)JsonUtil.Get<string>(json, "SteamId");
			SteamCountry = (string)JsonUtil.Get<string>(json, "SteamCountry");
			SteamCurrency = (Currency?)JsonUtil.GetEnum<Currency>(json, "SteamCurrency");
			SteamActivationStatus = (TitleActivationStatus?)JsonUtil.GetEnum<TitleActivationStatus>(json, "SteamActivationStatus");
		}
	}
	
	
	
	public class UserTitleInfo : PlayFabModelBase
	{
		
		
		/// <summary>
		/// name of the user, as it is displayed in-game
		/// </summary>
		
		public string DisplayName { get; set;}
		
		/// <summary>
		/// source by which the user first joined the game, if known
		/// </summary>
		
		public UserOrigination? Origination { get; set;}
		
		/// <summary>
		/// timestamp indicating when the user was first associated with this game (this can differ significantly from when the user first registered with PlayFab)
		/// </summary>
		
		public DateTime Created { get; set;}
		
		/// <summary>
		/// timestamp for the last user login for this title
		/// </summary>
		
		public DateTime? LastLogin { get; set;}
		
		/// <summary>
		/// timestamp indicating when the user first signed into this game (this can differ from the Created timestamp, as other events, such as issuing a beta key to the user, can associate the title to the user)
		/// </summary>
		
		public DateTime? FirstLogin { get; set;}
		
		/// <summary>
		/// boolean indicating whether or not the user is currently banned for a title
		/// </summary>
		
		public bool? isBanned { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("DisplayName", DisplayName);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Origination", Origination);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("Created", Created);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("LastLogin", LastLogin);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("FirstLogin", FirstLogin);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("isBanned", isBanned);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			DisplayName = (string)JsonUtil.Get<string>(json, "DisplayName");
			Origination = (UserOrigination?)JsonUtil.GetEnum<UserOrigination>(json, "Origination");
			Created = (DateTime)JsonUtil.GetDateTime(json, "Created");
			LastLogin = (DateTime?)JsonUtil.GetDateTime(json, "LastLogin");
			FirstLogin = (DateTime?)JsonUtil.GetDateTime(json, "FirstLogin");
			isBanned = (bool?)JsonUtil.Get<bool?>(json, "isBanned");
		}
	}
	
	
	
	public class VirtualCurrencyData : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique two-character identifier for this currency type (e.g.: "CC", "GC")
		/// </summary>
		
		public string CurrencyCode { get; set;}
		
		/// <summary>
		/// friendly name to show in the developer portal, reports, etc.
		/// </summary>
		
		public string DisplayName { get; set;}
		
		/// <summary>
		/// amount to automatically grant users upon first login to the tilte
		/// </summary>
		
		public int? InitialDeposit { get; set;}
		
		/// <summary>
		/// rate at which the currency automatically be added to over time, in units per day (24 hours)
		/// </summary>
		
		public int? RechargeRate { get; set;}
		
		/// <summary>
		/// maximum amount to which the currency will recharge (cannot exceed MaxAmount, but can be less)
		/// </summary>
		
		public int? RechargeMax { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("CurrencyCode", CurrencyCode);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("DisplayName", DisplayName);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("InitialDeposit", InitialDeposit);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RechargeRate", RechargeRate);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RechargeMax", RechargeMax);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			CurrencyCode = (string)JsonUtil.Get<string>(json, "CurrencyCode");
			DisplayName = (string)JsonUtil.Get<string>(json, "DisplayName");
			InitialDeposit = (int?)JsonUtil.Get<double?>(json, "InitialDeposit");
			RechargeRate = (int?)JsonUtil.Get<double?>(json, "RechargeRate");
			RechargeMax = (int?)JsonUtil.Get<double?>(json, "RechargeMax");
		}
	}
	
	
	
	public class VirtualCurrencyRechargeTime : PlayFabModelBase
	{
		
		
		/// <summary>
		/// Time remaining (in seconds) before the next recharge increment of the virtual currency.
		/// </summary>
		
		public int SecondsToRecharge { get; set;}
		
		/// <summary>
		/// Server timestamp in UTC indicating the next time the virtual currency will be incremented
		/// </summary>
		
		public DateTime RechargeTime { get; set;}
		
		public override void WriteJson(JsonWriter writer)
		{
			writer.Writer.Write(JsonReader.OperatorObjectStart);
			
			writer.WriteObjectProperty("SecondsToRecharge", SecondsToRecharge);
			
			writer.Writer.Write(JsonReader.OperatorValueDelim);
			
			writer.WriteObjectProperty("RechargeTime", RechargeTime);
			
			writer.Writer.Write(JsonReader.OperatorObjectEnd);
		}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			SecondsToRecharge = (int)JsonUtil.Get<double>(json, "SecondsToRecharge");
			RechargeTime = (DateTime)JsonUtil.GetDateTime(json, "RechargeTime");
		}
	}
	
}
