﻿#pragma warning disable 1591

namespace BubbleSearchDataContext
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BubbleSearch")]
	public partial class BubbleBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertWord(Word instance);
    partial void UpdateWord(Word instance);
    partial void DeleteWord(Word instance);
    partial void InsertOccurrence(Occurrence instance);
    partial void UpdateOccurrence(Occurrence instance);
    partial void DeleteOccurrence(Occurrence instance);
    partial void InsertPage(Page instance);
    partial void UpdatePage(Page instance);
    partial void DeletePage(Page instance);
    partial void InsertReference(Reference instance);
    partial void UpdateReference(Reference instance);
    partial void DeleteReference(Reference instance);
    partial void InsertResource(Resource instance);
    partial void UpdateResource(Resource instance);
    partial void DeleteResource(Resource instance);
    partial void InsertSite(Site instance);
    partial void UpdateSite(Site instance);
    partial void DeleteSite(Site instance);
    #endregion
		
		public BubbleBaseDataContext() : 
				base(global::BubbleSearchDataContext.Properties.Settings.Default.BubbleSearchConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BubbleBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BubbleBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BubbleBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BubbleBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Word> Words
		{
			get
			{
				return this.GetTable<Word>();
			}
		}
		
		public System.Data.Linq.Table<Occurrence> Occurrences
		{
			get
			{
				return this.GetTable<Occurrence>();
			}
		}
		
		public System.Data.Linq.Table<Page> Pages
		{
			get
			{
				return this.GetTable<Page>();
			}
		}
		
		public System.Data.Linq.Table<Reference> References
		{
			get
			{
				return this.GetTable<Reference>();
			}
		}
		
		public System.Data.Linq.Table<Resource> Resources
		{
			get
			{
				return this.GetTable<Resource>();
			}
		}
		
		public System.Data.Linq.Table<Site> Sites
		{
			get
			{
				return this.GetTable<Site>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddCategory")]
		public int AddCategory([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(75)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateWords")]
		public int UpdateWords([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_w, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string txt_w)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_w, txt_w);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddOccurrence")]
		public int AddOccurrence([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_o, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_w, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nb_occur)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_o, id_p, id_w, nb_occur);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddPage")]
		public int AddPage([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_site_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string url_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(150)")] string title_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string desc_p)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_p, id_site_p, url_p, title_p, desc_p);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddReferences")]
		public int AddReferences([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_r, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_site_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_site_d)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_r, id_site_s, id_site_d);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddResources")]
		public int AddResources([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_r, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_p, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string type_r, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string name_r)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_r, id_p, type_r, name_r);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddSite")]
		public int AddSite([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string url_site, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_cat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string desc, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iq)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_s, url_site, id_cat, desc, title, iq);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddWords")]
		public int AddWords([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_w, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string txt_w)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_w, txt_w);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveCategory")]
		public int RemoveCategory([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveOccurrence")]
		public int RemoveOccurrence([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemovePages")]
		public int RemovePages([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveReferences")]
		public int RemoveReferences([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveResources")]
		public int RemoveResources([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveSite")]
		public int RemoveSite([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RemoveWords")]
		public int RemoveWords([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateCategory")]
		public int UpdateCategory([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(75)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateOccurence")]
		public int UpdateOccurence([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_occur, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nb_occur)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_occur, nb_occur);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdatePage")]
		public int UpdatePage([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_page, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(250)")] string url_page, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(150)")] string title_page, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string description_page)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_page, url_page, title_page, description_page);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateResources")]
		public int UpdateResources([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_res, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string type_r, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string name_r)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_res, type_r, name_r);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateSite")]
		public int UpdateSite([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string url_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string desc_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string title_s, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> qi_s)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_s, url_s, desc_s, title_s, qi_s);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_category;
		
		private string _name_category;
		
		private EntitySet<Site> _Sites;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_categoryChanging(System.Guid value);
    partial void Onid_categoryChanged();
    partial void Onname_categoryChanging(string value);
    partial void Onname_categoryChanged();
    #endregion
		
		public Category()
		{
			this._Sites = new EntitySet<Site>(new Action<Site>(this.attach_Sites), new Action<Site>(this.detach_Sites));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_category", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_category
		{
			get
			{
				return this._id_category;
			}
			set
			{
				if ((this._id_category != value))
				{
					this.Onid_categoryChanging(value);
					this.SendPropertyChanging();
					this._id_category = value;
					this.SendPropertyChanged("id_category");
					this.Onid_categoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_category", DbType="NVarChar(75) NOT NULL", CanBeNull=false)]
		public string name_category
		{
			get
			{
				return this._name_category;
			}
			set
			{
				if ((this._name_category != value))
				{
					this.Onname_categoryChanging(value);
					this.SendPropertyChanging();
					this._name_category = value;
					this.SendPropertyChanged("name_category");
					this.Onname_categoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Site", Storage="_Sites", ThisKey="id_category", OtherKey="ID_CATEGORY")]
		public EntitySet<Site> Sites
		{
			get
			{
				return this._Sites;
			}
			set
			{
				this._Sites.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Sites(Site entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Sites(Site entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Words")]
	public partial class Word : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_word;
		
		private string _txt_word;
		
		private EntitySet<Occurrence> _Occurrences;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_wordChanging(System.Guid value);
    partial void Onid_wordChanged();
    partial void Ontxt_wordChanging(string value);
    partial void Ontxt_wordChanged();
    #endregion
		
		public Word()
		{
			this._Occurrences = new EntitySet<Occurrence>(new Action<Occurrence>(this.attach_Occurrences), new Action<Occurrence>(this.detach_Occurrences));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_word", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_word
		{
			get
			{
				return this._id_word;
			}
			set
			{
				if ((this._id_word != value))
				{
					this.Onid_wordChanging(value);
					this.SendPropertyChanging();
					this._id_word = value;
					this.SendPropertyChanged("id_word");
					this.Onid_wordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txt_word", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string txt_word
		{
			get
			{
				return this._txt_word;
			}
			set
			{
				if ((this._txt_word != value))
				{
					this.Ontxt_wordChanging(value);
					this.SendPropertyChanging();
					this._txt_word = value;
					this.SendPropertyChanged("txt_word");
					this.Ontxt_wordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Word_Occurrence", Storage="_Occurrences", ThisKey="id_word", OtherKey="id_word")]
		public EntitySet<Occurrence> Occurrences
		{
			get
			{
				return this._Occurrences;
			}
			set
			{
				this._Occurrences.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Occurrences(Occurrence entity)
		{
			this.SendPropertyChanging();
			entity.Word = this;
		}
		
		private void detach_Occurrences(Occurrence entity)
		{
			this.SendPropertyChanging();
			entity.Word = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Occurrence")]
	public partial class Occurrence : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_occur;
		
		private System.Guid _id_page;
		
		private System.Guid _id_word;
		
		private System.Nullable<int> _nb_occur;
		
		private EntityRef<Word> _Word;
		
		private EntityRef<Page> _Page;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_occurChanging(System.Guid value);
    partial void Onid_occurChanged();
    partial void Onid_pageChanging(System.Guid value);
    partial void Onid_pageChanged();
    partial void Onid_wordChanging(System.Guid value);
    partial void Onid_wordChanged();
    partial void Onnb_occurChanging(System.Nullable<int> value);
    partial void Onnb_occurChanged();
    #endregion
		
		public Occurrence()
		{
			this._Word = default(EntityRef<Word>);
			this._Page = default(EntityRef<Page>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_occur", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_occur
		{
			get
			{
				return this._id_occur;
			}
			set
			{
				if ((this._id_occur != value))
				{
					this.Onid_occurChanging(value);
					this.SendPropertyChanging();
					this._id_occur = value;
					this.SendPropertyChanged("id_occur");
					this.Onid_occurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_page", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_page
		{
			get
			{
				return this._id_page;
			}
			set
			{
				if ((this._id_page != value))
				{
					if (this._Page.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pageChanging(value);
					this.SendPropertyChanging();
					this._id_page = value;
					this.SendPropertyChanged("id_page");
					this.Onid_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_word", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_word
		{
			get
			{
				return this._id_word;
			}
			set
			{
				if ((this._id_word != value))
				{
					if (this._Word.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_wordChanging(value);
					this.SendPropertyChanging();
					this._id_word = value;
					this.SendPropertyChanged("id_word");
					this.Onid_wordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nb_occur", DbType="Int")]
		public System.Nullable<int> nb_occur
		{
			get
			{
				return this._nb_occur;
			}
			set
			{
				if ((this._nb_occur != value))
				{
					this.Onnb_occurChanging(value);
					this.SendPropertyChanging();
					this._nb_occur = value;
					this.SendPropertyChanged("nb_occur");
					this.Onnb_occurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Word_Occurrence", Storage="_Word", ThisKey="id_word", OtherKey="id_word", IsForeignKey=true)]
		public Word Word
		{
			get
			{
				return this._Word.Entity;
			}
			set
			{
				Word previousValue = this._Word.Entity;
				if (((previousValue != value) 
							|| (this._Word.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Word.Entity = null;
						previousValue.Occurrences.Remove(this);
					}
					this._Word.Entity = value;
					if ((value != null))
					{
						value.Occurrences.Add(this);
						this._id_word = value.id_word;
					}
					else
					{
						this._id_word = default(System.Guid);
					}
					this.SendPropertyChanged("Word");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Occurrence", Storage="_Page", ThisKey="id_page", OtherKey="id_page", IsForeignKey=true)]
		public Page Page
		{
			get
			{
				return this._Page.Entity;
			}
			set
			{
				Page previousValue = this._Page.Entity;
				if (((previousValue != value) 
							|| (this._Page.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Page.Entity = null;
						previousValue.Occurrences.Remove(this);
					}
					this._Page.Entity = value;
					if ((value != null))
					{
						value.Occurrences.Add(this);
						this._id_page = value.id_page;
					}
					else
					{
						this._id_page = default(System.Guid);
					}
					this.SendPropertyChanged("Page");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Page")]
	public partial class Page : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_page;
		
		private System.Guid _id_site_parent;
		
		private string _url_page;
		
		private string _title_page;
		
		private string _description_page;
		
		private EntitySet<Occurrence> _Occurrences;
		
		private EntitySet<Resource> _Resources;
		
		private EntityRef<Site> _Site;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pageChanging(System.Guid value);
    partial void Onid_pageChanged();
    partial void Onid_site_parentChanging(System.Guid value);
    partial void Onid_site_parentChanged();
    partial void Onurl_pageChanging(string value);
    partial void Onurl_pageChanged();
    partial void Ontitle_pageChanging(string value);
    partial void Ontitle_pageChanged();
    partial void Ondescription_pageChanging(string value);
    partial void Ondescription_pageChanged();
    #endregion
		
		public Page()
		{
			this._Occurrences = new EntitySet<Occurrence>(new Action<Occurrence>(this.attach_Occurrences), new Action<Occurrence>(this.detach_Occurrences));
			this._Resources = new EntitySet<Resource>(new Action<Resource>(this.attach_Resources), new Action<Resource>(this.detach_Resources));
			this._Site = default(EntityRef<Site>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_page", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_page
		{
			get
			{
				return this._id_page;
			}
			set
			{
				if ((this._id_page != value))
				{
					this.Onid_pageChanging(value);
					this.SendPropertyChanging();
					this._id_page = value;
					this.SendPropertyChanged("id_page");
					this.Onid_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_site_parent", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_site_parent
		{
			get
			{
				return this._id_site_parent;
			}
			set
			{
				if ((this._id_site_parent != value))
				{
					if (this._Site.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_site_parentChanging(value);
					this.SendPropertyChanging();
					this._id_site_parent = value;
					this.SendPropertyChanged("id_site_parent");
					this.Onid_site_parentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_page", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string url_page
		{
			get
			{
				return this._url_page;
			}
			set
			{
				if ((this._url_page != value))
				{
					this.Onurl_pageChanging(value);
					this.SendPropertyChanging();
					this._url_page = value;
					this.SendPropertyChanged("url_page");
					this.Onurl_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title_page", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string title_page
		{
			get
			{
				return this._title_page;
			}
			set
			{
				if ((this._title_page != value))
				{
					this.Ontitle_pageChanging(value);
					this.SendPropertyChanging();
					this._title_page = value;
					this.SendPropertyChanged("title_page");
					this.Ontitle_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description_page", DbType="NVarChar(MAX)")]
		public string description_page
		{
			get
			{
				return this._description_page;
			}
			set
			{
				if ((this._description_page != value))
				{
					this.Ondescription_pageChanging(value);
					this.SendPropertyChanging();
					this._description_page = value;
					this.SendPropertyChanged("description_page");
					this.Ondescription_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Occurrence", Storage="_Occurrences", ThisKey="id_page", OtherKey="id_page")]
		public EntitySet<Occurrence> Occurrences
		{
			get
			{
				return this._Occurrences;
			}
			set
			{
				this._Occurrences.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Resource", Storage="_Resources", ThisKey="id_page", OtherKey="id_page")]
		public EntitySet<Resource> Resources
		{
			get
			{
				return this._Resources;
			}
			set
			{
				this._Resources.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Page", Storage="_Site", ThisKey="id_site_parent", OtherKey="ID_SITE", IsForeignKey=true)]
		public Site Site
		{
			get
			{
				return this._Site.Entity;
			}
			set
			{
				Site previousValue = this._Site.Entity;
				if (((previousValue != value) 
							|| (this._Site.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Site.Entity = null;
						previousValue.Pages.Remove(this);
					}
					this._Site.Entity = value;
					if ((value != null))
					{
						value.Pages.Add(this);
						this._id_site_parent = value.ID_SITE;
					}
					else
					{
						this._id_site_parent = default(System.Guid);
					}
					this.SendPropertyChanged("Site");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Occurrences(Occurrence entity)
		{
			this.SendPropertyChanging();
			entity.Page = this;
		}
		
		private void detach_Occurrences(Occurrence entity)
		{
			this.SendPropertyChanging();
			entity.Page = null;
		}
		
		private void attach_Resources(Resource entity)
		{
			this.SendPropertyChanging();
			entity.Page = this;
		}
		
		private void detach_Resources(Resource entity)
		{
			this.SendPropertyChanging();
			entity.Page = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[References]")]
	public partial class Reference : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_ref;
		
		private System.Guid _id_site_source;
		
		private System.Guid _id_site_destination;
		
		private EntityRef<Site> _Site;
		
		private EntityRef<Site> _Site1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_refChanging(System.Guid value);
    partial void Onid_refChanged();
    partial void Onid_site_sourceChanging(System.Guid value);
    partial void Onid_site_sourceChanged();
    partial void Onid_site_destinationChanging(System.Guid value);
    partial void Onid_site_destinationChanged();
    #endregion
		
		public Reference()
		{
			this._Site = default(EntityRef<Site>);
			this._Site1 = default(EntityRef<Site>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_ref", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_ref
		{
			get
			{
				return this._id_ref;
			}
			set
			{
				if ((this._id_ref != value))
				{
					this.Onid_refChanging(value);
					this.SendPropertyChanging();
					this._id_ref = value;
					this.SendPropertyChanged("id_ref");
					this.Onid_refChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_site_source", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_site_source
		{
			get
			{
				return this._id_site_source;
			}
			set
			{
				if ((this._id_site_source != value))
				{
					if (this._Site1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_site_sourceChanging(value);
					this.SendPropertyChanging();
					this._id_site_source = value;
					this.SendPropertyChanged("id_site_source");
					this.Onid_site_sourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_site_destination", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_site_destination
		{
			get
			{
				return this._id_site_destination;
			}
			set
			{
				if ((this._id_site_destination != value))
				{
					if (this._Site.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_site_destinationChanging(value);
					this.SendPropertyChanging();
					this._id_site_destination = value;
					this.SendPropertyChanged("id_site_destination");
					this.Onid_site_destinationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Reference", Storage="_Site", ThisKey="id_site_destination", OtherKey="ID_SITE", IsForeignKey=true)]
		public Site Site
		{
			get
			{
				return this._Site.Entity;
			}
			set
			{
				Site previousValue = this._Site.Entity;
				if (((previousValue != value) 
							|| (this._Site.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Site.Entity = null;
						previousValue.References.Remove(this);
					}
					this._Site.Entity = value;
					if ((value != null))
					{
						value.References.Add(this);
						this._id_site_destination = value.ID_SITE;
					}
					else
					{
						this._id_site_destination = default(System.Guid);
					}
					this.SendPropertyChanged("Site");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Reference1", Storage="_Site1", ThisKey="id_site_source", OtherKey="ID_SITE", IsForeignKey=true)]
		public Site Site1
		{
			get
			{
				return this._Site1.Entity;
			}
			set
			{
				Site previousValue = this._Site1.Entity;
				if (((previousValue != value) 
							|| (this._Site1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Site1.Entity = null;
						previousValue.References1.Remove(this);
					}
					this._Site1.Entity = value;
					if ((value != null))
					{
						value.References1.Add(this);
						this._id_site_source = value.ID_SITE;
					}
					else
					{
						this._id_site_source = default(System.Guid);
					}
					this.SendPropertyChanged("Site1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Resources")]
	public partial class Resource : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id_resource;
		
		private System.Guid _id_page;
		
		private string _type_resx;
		
		private string _name_resx;
		
		private string _url_resx;
		
		private EntityRef<Page> _Page;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_resourceChanging(System.Guid value);
    partial void Onid_resourceChanged();
    partial void Onid_pageChanging(System.Guid value);
    partial void Onid_pageChanged();
    partial void Ontype_resxChanging(string value);
    partial void Ontype_resxChanged();
    partial void Onname_resxChanging(string value);
    partial void Onname_resxChanged();
    partial void Onurl_resxChanging(string value);
    partial void Onurl_resxChanged();
    #endregion
		
		public Resource()
		{
			this._Page = default(EntityRef<Page>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_resource", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid id_resource
		{
			get
			{
				return this._id_resource;
			}
			set
			{
				if ((this._id_resource != value))
				{
					this.Onid_resourceChanging(value);
					this.SendPropertyChanging();
					this._id_resource = value;
					this.SendPropertyChanged("id_resource");
					this.Onid_resourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_page", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid id_page
		{
			get
			{
				return this._id_page;
			}
			set
			{
				if ((this._id_page != value))
				{
					if (this._Page.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pageChanging(value);
					this.SendPropertyChanging();
					this._id_page = value;
					this.SendPropertyChanged("id_page");
					this.Onid_pageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_resx", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string type_resx
		{
			get
			{
				return this._type_resx;
			}
			set
			{
				if ((this._type_resx != value))
				{
					this.Ontype_resxChanging(value);
					this.SendPropertyChanging();
					this._type_resx = value;
					this.SendPropertyChanged("type_resx");
					this.Ontype_resxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_resx", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name_resx
		{
			get
			{
				return this._name_resx;
			}
			set
			{
				if ((this._name_resx != value))
				{
					this.Onname_resxChanging(value);
					this.SendPropertyChanging();
					this._name_resx = value;
					this.SendPropertyChanged("name_resx");
					this.Onname_resxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_resx", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string url_resx
		{
			get
			{
				return this._url_resx;
			}
			set
			{
				if ((this._url_resx != value))
				{
					this.Onurl_resxChanging(value);
					this.SendPropertyChanging();
					this._url_resx = value;
					this.SendPropertyChanged("url_resx");
					this.Onurl_resxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Resource", Storage="_Page", ThisKey="id_page", OtherKey="id_page", IsForeignKey=true)]
		public Page Page
		{
			get
			{
				return this._Page.Entity;
			}
			set
			{
				Page previousValue = this._Page.Entity;
				if (((previousValue != value) 
							|| (this._Page.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Page.Entity = null;
						previousValue.Resources.Remove(this);
					}
					this._Page.Entity = value;
					if ((value != null))
					{
						value.Resources.Add(this);
						this._id_page = value.id_page;
					}
					else
					{
						this._id_page = default(System.Guid);
					}
					this.SendPropertyChanged("Page");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Site")]
	public partial class Site : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID_SITE;
		
		private string _URL_SITE;
		
		private System.Guid _ID_CATEGORY;
		
		private string _DESCRIPTION;
		
		private string _TITLE;
		
		private System.Nullable<int> _QI;
		
		private EntitySet<Page> _Pages;
		
		private EntitySet<Reference> _References;
		
		private EntitySet<Reference> _References1;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_SITEChanging(System.Guid value);
    partial void OnID_SITEChanged();
    partial void OnURL_SITEChanging(string value);
    partial void OnURL_SITEChanged();
    partial void OnID_CATEGORYChanging(System.Guid value);
    partial void OnID_CATEGORYChanged();
    partial void OnDESCRIPTIONChanging(string value);
    partial void OnDESCRIPTIONChanged();
    partial void OnTITLEChanging(string value);
    partial void OnTITLEChanged();
    partial void OnQIChanging(System.Nullable<int> value);
    partial void OnQIChanged();
    #endregion
		
		public Site()
		{
			this._Pages = new EntitySet<Page>(new Action<Page>(this.attach_Pages), new Action<Page>(this.detach_Pages));
			this._References = new EntitySet<Reference>(new Action<Reference>(this.attach_References), new Action<Reference>(this.detach_References));
			this._References1 = new EntitySet<Reference>(new Action<Reference>(this.attach_References1), new Action<Reference>(this.detach_References1));
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SITE", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID_SITE
		{
			get
			{
				return this._ID_SITE;
			}
			set
			{
				if ((this._ID_SITE != value))
				{
					this.OnID_SITEChanging(value);
					this.SendPropertyChanging();
					this._ID_SITE = value;
					this.SendPropertyChanged("ID_SITE");
					this.OnID_SITEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL_SITE", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string URL_SITE
		{
			get
			{
				return this._URL_SITE;
			}
			set
			{
				if ((this._URL_SITE != value))
				{
					this.OnURL_SITEChanging(value);
					this.SendPropertyChanging();
					this._URL_SITE = value;
					this.SendPropertyChanged("URL_SITE");
					this.OnURL_SITEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CATEGORY", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ID_CATEGORY
		{
			get
			{
				return this._ID_CATEGORY;
			}
			set
			{
				if ((this._ID_CATEGORY != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_CATEGORYChanging(value);
					this.SendPropertyChanging();
					this._ID_CATEGORY = value;
					this.SendPropertyChanged("ID_CATEGORY");
					this.OnID_CATEGORYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPTION", DbType="NVarChar(MAX)")]
		public string DESCRIPTION
		{
			get
			{
				return this._DESCRIPTION;
			}
			set
			{
				if ((this._DESCRIPTION != value))
				{
					this.OnDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPTION = value;
					this.SendPropertyChanged("DESCRIPTION");
					this.OnDESCRIPTIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITLE", DbType="NVarChar(100)")]
		public string TITLE
		{
			get
			{
				return this._TITLE;
			}
			set
			{
				if ((this._TITLE != value))
				{
					this.OnTITLEChanging(value);
					this.SendPropertyChanging();
					this._TITLE = value;
					this.SendPropertyChanged("TITLE");
					this.OnTITLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QI", DbType="Int")]
		public System.Nullable<int> QI
		{
			get
			{
				return this._QI;
			}
			set
			{
				if ((this._QI != value))
				{
					this.OnQIChanging(value);
					this.SendPropertyChanging();
					this._QI = value;
					this.SendPropertyChanged("QI");
					this.OnQIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Page", Storage="_Pages", ThisKey="ID_SITE", OtherKey="id_site_parent")]
		public EntitySet<Page> Pages
		{
			get
			{
				return this._Pages;
			}
			set
			{
				this._Pages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Reference", Storage="_References", ThisKey="ID_SITE", OtherKey="id_site_destination")]
		public EntitySet<Reference> References
		{
			get
			{
				return this._References;
			}
			set
			{
				this._References.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Site_Reference1", Storage="_References1", ThisKey="ID_SITE", OtherKey="id_site_source")]
		public EntitySet<Reference> References1
		{
			get
			{
				return this._References1;
			}
			set
			{
				this._References1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Site", Storage="_Category", ThisKey="ID_CATEGORY", OtherKey="id_category", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Sites.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Sites.Add(this);
						this._ID_CATEGORY = value.id_category;
					}
					else
					{
						this._ID_CATEGORY = default(System.Guid);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Pages(Page entity)
		{
			this.SendPropertyChanging();
			entity.Site = this;
		}
		
		private void detach_Pages(Page entity)
		{
			this.SendPropertyChanging();
			entity.Site = null;
		}
		
		private void attach_References(Reference entity)
		{
			this.SendPropertyChanging();
			entity.Site = this;
		}
		
		private void detach_References(Reference entity)
		{
			this.SendPropertyChanging();
			entity.Site = null;
		}
		
		private void attach_References1(Reference entity)
		{
			this.SendPropertyChanging();
			entity.Site1 = this;
		}
		
		private void detach_References1(Reference entity)
		{
			this.SendPropertyChanging();
			entity.Site1 = null;
		}
	}
}
#pragma warning restore 1591
