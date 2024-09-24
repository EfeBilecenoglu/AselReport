﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raporhafiza
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Aselrapor")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIslem(Islem instance);
    partial void UpdateIslem(Islem instance);
    partial void DeleteIslem(Islem instance);
    partial void InsertRapor(Rapor instance);
    partial void UpdateRapor(Rapor instance);
    partial void DeleteRapor(Rapor instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Raporhafiza.Properties.Settings.Default.AselraporConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Islem> Islems
		{
			get
			{
				return this.GetTable<Islem>();
			}
		}
		
		public System.Data.Linq.Table<Rapor> Rapors
		{
			get
			{
				return this.GetTable<Rapor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Islem")]
	public partial class Islem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Islem_id;
		
		private string _Aciklama;
		
		private System.Nullable<int> _rapor_id;
		
		private EntityRef<Rapor> _Rapor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIslem_idChanging(int value);
    partial void OnIslem_idChanged();
    partial void OnAciklamaChanging(string value);
    partial void OnAciklamaChanged();
    partial void Onrapor_idChanging(System.Nullable<int> value);
    partial void Onrapor_idChanged();
    #endregion
		
		public Islem()
		{
			this._Rapor = default(EntityRef<Rapor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Islem_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Islem_id
		{
			get
			{
				return this._Islem_id;
			}
			set
			{
				if ((this._Islem_id != value))
				{
					this.OnIslem_idChanging(value);
					this.SendPropertyChanging();
					this._Islem_id = value;
					this.SendPropertyChanged("Islem_id");
					this.OnIslem_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Aciklama", DbType="NVarChar(MAX)")]
		public string Aciklama
		{
			get
			{
				return this._Aciklama;
			}
			set
			{
				if ((this._Aciklama != value))
				{
					this.OnAciklamaChanging(value);
					this.SendPropertyChanging();
					this._Aciklama = value;
					this.SendPropertyChanged("Aciklama");
					this.OnAciklamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rapor_id", DbType="Int")]
		public System.Nullable<int> rapor_id
		{
			get
			{
				return this._rapor_id;
			}
			set
			{
				if ((this._rapor_id != value))
				{
					if (this._Rapor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onrapor_idChanging(value);
					this.SendPropertyChanging();
					this._rapor_id = value;
					this.SendPropertyChanged("rapor_id");
					this.Onrapor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rapor_Islem", Storage="_Rapor", ThisKey="rapor_id", OtherKey="id", IsForeignKey=true)]
		public Rapor Rapor
		{
			get
			{
				return this._Rapor.Entity;
			}
			set
			{
				Rapor previousValue = this._Rapor.Entity;
				if (((previousValue != value) 
							|| (this._Rapor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rapor.Entity = null;
						previousValue.Islems.Remove(this);
					}
					this._Rapor.Entity = value;
					if ((value != null))
					{
						value.Islems.Add(this);
						this._rapor_id = value.id;
					}
					else
					{
						this._rapor_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Rapor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rapor")]
	public partial class Rapor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Yer;
		
		private string _Gorevli_Personel;
		
		private System.Nullable<System.DateTime> _Tarih;
		
		private string _Gorev_Tipi;
		
		private string _Sehir;
		
		private EntitySet<Islem> _Islems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnYerChanging(string value);
    partial void OnYerChanged();
    partial void OnGorevli_PersonelChanging(string value);
    partial void OnGorevli_PersonelChanged();
    partial void OnTarihChanging(System.Nullable<System.DateTime> value);
    partial void OnTarihChanged();
    partial void OnGorev_TipiChanging(string value);
    partial void OnGorev_TipiChanged();
    partial void OnSehirChanging(string value);
    partial void OnSehirChanged();
    #endregion
		
		public Rapor()
		{
			this._Islems = new EntitySet<Islem>(new Action<Islem>(this.attach_Islems), new Action<Islem>(this.detach_Islems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yer", DbType="NVarChar(50)")]
		public string Yer
		{
			get
			{
				return this._Yer;
			}
			set
			{
				if ((this._Yer != value))
				{
					this.OnYerChanging(value);
					this.SendPropertyChanging();
					this._Yer = value;
					this.SendPropertyChanged("Yer");
					this.OnYerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gorevli_Personel", DbType="NVarChar(50)")]
		public string Gorevli_Personel
		{
			get
			{
				return this._Gorevli_Personel;
			}
			set
			{
				if ((this._Gorevli_Personel != value))
				{
					this.OnGorevli_PersonelChanging(value);
					this.SendPropertyChanging();
					this._Gorevli_Personel = value;
					this.SendPropertyChanged("Gorevli_Personel");
					this.OnGorevli_PersonelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarih", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Tarih
		{
			get
			{
				return this._Tarih;
			}
			set
			{
				if ((this._Tarih != value))
				{
					this.OnTarihChanging(value);
					this.SendPropertyChanging();
					this._Tarih = value;
					this.SendPropertyChanged("Tarih");
					this.OnTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gorev_Tipi", DbType="NVarChar(15)")]
		public string Gorev_Tipi
		{
			get
			{
				return this._Gorev_Tipi;
			}
			set
			{
				if ((this._Gorev_Tipi != value))
				{
					this.OnGorev_TipiChanging(value);
					this.SendPropertyChanging();
					this._Gorev_Tipi = value;
					this.SendPropertyChanged("Gorev_Tipi");
					this.OnGorev_TipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sehir", DbType="NVarChar(50)")]
		public string Sehir
		{
			get
			{
				return this._Sehir;
			}
			set
			{
				if ((this._Sehir != value))
				{
					this.OnSehirChanging(value);
					this.SendPropertyChanging();
					this._Sehir = value;
					this.SendPropertyChanged("Sehir");
					this.OnSehirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rapor_Islem", Storage="_Islems", ThisKey="id", OtherKey="rapor_id")]
		public EntitySet<Islem> Islems
		{
			get
			{
				return this._Islems;
			}
			set
			{
				this._Islems.Assign(value);
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
		
		private void attach_Islems(Islem entity)
		{
			this.SendPropertyChanging();
			entity.Rapor = this;
		}
		
		private void detach_Islems(Islem entity)
		{
			this.SendPropertyChanging();
			entity.Rapor = null;
		}
	}
}
#pragma warning restore 1591
