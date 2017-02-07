﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

using System.Text;
using System.Threading.Tasks;

namespace ArkBot.Database 
{
    public partial class DatabaseContext : BrightstarEntityContext {
    	
    	static DatabaseContext() 
    	{
            InitializeEntityMappingStore();
        }
        
        /// <summary>
        /// Initialize the internal cache of entity attribute information.
        /// </summary>
        /// <remarks>
        /// This method is normally invoked from the static constructor for the generated context class.
        /// It is provided as a public static method to enable the use of the cached entity attribute 
        /// information without the need to construct a context (typically in test code). 
        /// In normal application code you should never need to explicitly call this method.
        /// </remarks>
        public static void InitializeEntityMappingStore()
        {
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(ArkBot.Database.IUser));
    		EntityMappingStore.Instance.SetImplMapping<ArkBot.Database.IUser, ArkBot.Database.User>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified BrightstarDB
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the BrightstarDB Data Object Store that will provide the entity objects</param>
    	public DatabaseContext(IDataObjectStore dataObjectStore) : base(dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
        /// <param name="updateGraphUri">OPTIONAL: The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// not defined, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">OPTIONAL: The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If not defined, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">OPTIONAL: The URI identifier of the graph that contains version number statements for entities. 
        /// If not defined, the <paramref name="updateGraphUri"/> will be used.</param>
    	public DatabaseContext(
    	    string connectionString, 
    		bool? enableOptimisticLocking=null,
    		string updateGraphUri = null,
    		IEnumerable<string> datasetGraphUris = null,
    		string versionGraphUri = null
        ) : base(connectionString, enableOptimisticLocking, updateGraphUri, datasetGraphUris, versionGraphUri)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public DatabaseContext() : base()
    	{
    		InitializeContext();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration and the
    	//  specified target graphs
    	/// </summary>
        /// <param name="updateGraphUri">The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// set to null, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If set to null, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">The URI identifier of the graph that contains version number statements for entities. 
        /// If set to null, the value of <paramref name="updateGraphUri"/> will be used.</param>
    	public DatabaseContext(
    		string updateGraphUri,
    		IEnumerable<string> datasetGraphUris,
    		string versionGraphUri
    	) : base(updateGraphUri:updateGraphUri, datasetGraphUris:datasetGraphUris, versionGraphUri:versionGraphUri)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Users = 	new BrightstarEntitySet<ArkBot.Database.IUser>(this);
    	}
    	
    	public IEntitySet<ArkBot.Database.IUser> Users
    	{
    		get; private set;
    	}
    	
        public IEntitySet<T> EntitySet<T>() where T : class {
            var itemType = typeof(T);
            if (typeof(T).Equals(typeof(ArkBot.Database.IUser))) {
                return (IEntitySet<T>)this.Users;
            }
            throw new InvalidOperationException(typeof(T).FullName + " is not a recognized entity interface type.");
        }
    
        } // end class DatabaseContext
        
}
namespace ArkBot.Database 
{
    
    public partial class User : BrightstarEntityObject, IUser 
    {
    	public User(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
        public User(BrightstarEntityContext context) : base(context, typeof(User)) { }
    	public User() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of ArkBot.Database.IUser
    
    	public System.UInt64 DiscordId
    	{
            		get { return GetRelatedProperty<System.UInt64>("DiscordId"); }
            		set { SetRelatedProperty("DiscordId", value); }
    	}
    
    	public System.UInt64 SteamId
    	{
            		get { return GetRelatedProperty<System.UInt64>("SteamId"); }
            		set { SetRelatedProperty("SteamId", value); }
    	}
    
    	public System.String RealName
    	{
            		get { return GetRelatedProperty<System.String>("RealName"); }
            		set { SetRelatedProperty("RealName", value); }
    	}
    
    	public System.String SteamDisplayName
    	{
            		get { return GetRelatedProperty<System.String>("SteamDisplayName"); }
            		set { SetRelatedProperty("SteamDisplayName", value); }
    	}
    	#endregion
    }
}