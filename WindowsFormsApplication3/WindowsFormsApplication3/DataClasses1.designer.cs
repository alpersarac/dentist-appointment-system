﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication3
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
	
	
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbilgiler(bilgiler instance);
    partial void Updatebilgiler(bilgiler instance);
    partial void Deletebilgiler(bilgiler instance);
    partial void Insertkayit(kayit instance);
    partial void Updatekayit(kayit instance);
    partial void Deletekayit(kayit instance);
    partial void Insertdoktor(doktor instance);
    partial void Updatedoktor(doktor instance);
    partial void Deletedoktor(doktor instance);
    #endregion
		
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
		
		public System.Data.Linq.Table<bilgiler> bilgilers
		{
			get
			{
				return this.GetTable<bilgiler>();
			}
		}
		
		public System.Data.Linq.Table<kayit> kayits
		{
			get
			{
				return this.GetTable<kayit>();
			}
		}
		
		public System.Data.Linq.Table<doktor> doktors
		{
			get
			{
				return this.GetTable<doktor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class bilgiler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ad;
		
		private string _soyad;
		
		private string _ilet;
		
		private string _dipnot;
		
		private int _tc;
		
		private string _tedavi;
		
		private System.DateTime _tarih;
		
		private string _saat;
		
		private bool _kutu;
		
		private int _hastaid;
		
		private bool _kutu1;
		
		private bool _kutu2;
		
		private bool _kutu3;
		
		private bool _kutu4;
		
		private bool _kutu5;
		
		private bool _kutu6;
		
		private bool _kutu7;
		
		private bool _kutu8;
		
		private bool _kutu9;
		
		private bool _kutu10;
		
		private bool _kutu11;
		
		private bool _kutu12;
		
		private bool _kutu13;
		
		private bool _kutu14;
		
		private bool _kutu15;
		
		private bool _kutu16;
		
		private bool _kutu17;
		
		private bool _kutu18;
		
		private bool _kutu19;
		
		private bool _kutu20;
		
		private bool _kutu21;
		
		private bool _kutu22;
		
		private bool _kutu23;
		
		private bool _kutu24;
		
		private bool _kutu25;
		
		private bool _kutu26;
		
		private bool _kutu27;
		
		private bool _kutu28;
		
		private bool _kutu29;
		
		private bool _kutu30;
		
		private bool _kutu31;
		
		private bool _kutu32;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnsoyadChanging(string value);
    partial void OnsoyadChanged();
    partial void OniletChanging(string value);
    partial void OniletChanged();
    partial void OndipnotChanging(string value);
    partial void OndipnotChanged();
    partial void OntcChanging(int value);
    partial void OntcChanged();
    partial void OntedaviChanging(string value);
    partial void OntedaviChanged();
    partial void OntarihChanging(System.DateTime value);
    partial void OntarihChanged();
    partial void OnsaatChanging(string value);
    partial void OnsaatChanged();
    partial void OnkutuChanging(bool value);
    partial void OnkutuChanged();
    partial void OnhastaidChanging(int value);
    partial void OnhastaidChanged();
    partial void Onkutu1Changing(bool value);
    partial void Onkutu1Changed();
    partial void Onkutu2Changing(bool value);
    partial void Onkutu2Changed();
    partial void Onkutu3Changing(bool value);
    partial void Onkutu3Changed();
    partial void Onkutu4Changing(bool value);
    partial void Onkutu4Changed();
    partial void Onkutu5Changing(bool value);
    partial void Onkutu5Changed();
    partial void Onkutu6Changing(bool value);
    partial void Onkutu6Changed();
    partial void Onkutu7Changing(bool value);
    partial void Onkutu7Changed();
    partial void Onkutu8Changing(bool value);
    partial void Onkutu8Changed();
    partial void Onkutu9Changing(bool value);
    partial void Onkutu9Changed();
    partial void Onkutu10Changing(bool value);
    partial void Onkutu10Changed();
    partial void Onkutu11Changing(bool value);
    partial void Onkutu11Changed();
    partial void Onkutu12Changing(bool value);
    partial void Onkutu12Changed();
    partial void Onkutu13Changing(bool value);
    partial void Onkutu13Changed();
    partial void Onkutu14Changing(bool value);
    partial void Onkutu14Changed();
    partial void Onkutu15Changing(bool value);
    partial void Onkutu15Changed();
    partial void Onkutu16Changing(bool value);
    partial void Onkutu16Changed();
    partial void Onkutu17Changing(bool value);
    partial void Onkutu17Changed();
    partial void Onkutu18Changing(bool value);
    partial void Onkutu18Changed();
    partial void Onkutu19Changing(bool value);
    partial void Onkutu19Changed();
    partial void Onkutu20Changing(bool value);
    partial void Onkutu20Changed();
    partial void Onkutu21Changing(bool value);
    partial void Onkutu21Changed();
    partial void Onkutu22Changing(bool value);
    partial void Onkutu22Changed();
    partial void Onkutu23Changing(bool value);
    partial void Onkutu23Changed();
    partial void Onkutu24Changing(bool value);
    partial void Onkutu24Changed();
    partial void Onkutu25Changing(bool value);
    partial void Onkutu25Changed();
    partial void Onkutu26Changing(bool value);
    partial void Onkutu26Changed();
    partial void Onkutu27Changing(bool value);
    partial void Onkutu27Changed();
    partial void Onkutu28Changing(bool value);
    partial void Onkutu28Changed();
    partial void Onkutu29Changing(bool value);
    partial void Onkutu29Changed();
    partial void Onkutu30Changing(bool value);
    partial void Onkutu30Changed();
    partial void Onkutu31Changing(bool value);
    partial void Onkutu31Changed();
    partial void Onkutu32Changing(bool value);
    partial void Onkutu32Changed();
    #endregion
		
		public bilgiler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", CanBeNull=false)]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soyad", CanBeNull=false)]
		public string soyad
		{
			get
			{
				return this._soyad;
			}
			set
			{
				if ((this._soyad != value))
				{
					this.OnsoyadChanging(value);
					this.SendPropertyChanging();
					this._soyad = value;
					this.SendPropertyChanged("soyad");
					this.OnsoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilet", CanBeNull=false)]
		public string ilet
		{
			get
			{
				return this._ilet;
			}
			set
			{
				if ((this._ilet != value))
				{
					this.OniletChanging(value);
					this.SendPropertyChanging();
					this._ilet = value;
					this.SendPropertyChanged("ilet");
					this.OniletChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dipnot", CanBeNull=false)]
		public string dipnot
		{
			get
			{
				return this._dipnot;
			}
			set
			{
				if ((this._dipnot != value))
				{
					this.OndipnotChanging(value);
					this.SendPropertyChanging();
					this._dipnot = value;
					this.SendPropertyChanged("dipnot");
					this.OndipnotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tc", IsPrimaryKey=true)]
		public int tc
		{
			get
			{
				return this._tc;
			}
			set
			{
				if ((this._tc != value))
				{
					this.OntcChanging(value);
					this.SendPropertyChanging();
					this._tc = value;
					this.SendPropertyChanged("tc");
					this.OntcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tedavi", CanBeNull=false)]
		public string tedavi
		{
			get
			{
				return this._tedavi;
			}
			set
			{
				if ((this._tedavi != value))
				{
					this.OntedaviChanging(value);
					this.SendPropertyChanging();
					this._tedavi = value;
					this.SendPropertyChanged("tedavi");
					this.OntedaviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih")]
		public System.DateTime tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saat", CanBeNull=false)]
		public string saat
		{
			get
			{
				return this._saat;
			}
			set
			{
				if ((this._saat != value))
				{
					this.OnsaatChanging(value);
					this.SendPropertyChanging();
					this._saat = value;
					this.SendPropertyChanged("saat");
					this.OnsaatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu")]
		public bool kutu
		{
			get
			{
				return this._kutu;
			}
			set
			{
				if ((this._kutu != value))
				{
					this.OnkutuChanging(value);
					this.SendPropertyChanging();
					this._kutu = value;
					this.SendPropertyChanged("kutu");
					this.OnkutuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hastaid", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int hastaid
		{
			get
			{
				return this._hastaid;
			}
			set
			{
				if ((this._hastaid != value))
				{
					this.OnhastaidChanging(value);
					this.SendPropertyChanging();
					this._hastaid = value;
					this.SendPropertyChanged("hastaid");
					this.OnhastaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu1")]
		public bool kutu1
		{
			get
			{
				return this._kutu1;
			}
			set
			{
				if ((this._kutu1 != value))
				{
					this.Onkutu1Changing(value);
					this.SendPropertyChanging();
					this._kutu1 = value;
					this.SendPropertyChanged("kutu1");
					this.Onkutu1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu2")]
		public bool kutu2
		{
			get
			{
				return this._kutu2;
			}
			set
			{
				if ((this._kutu2 != value))
				{
					this.Onkutu2Changing(value);
					this.SendPropertyChanging();
					this._kutu2 = value;
					this.SendPropertyChanged("kutu2");
					this.Onkutu2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu3")]
		public bool kutu3
		{
			get
			{
				return this._kutu3;
			}
			set
			{
				if ((this._kutu3 != value))
				{
					this.Onkutu3Changing(value);
					this.SendPropertyChanging();
					this._kutu3 = value;
					this.SendPropertyChanged("kutu3");
					this.Onkutu3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu4")]
		public bool kutu4
		{
			get
			{
				return this._kutu4;
			}
			set
			{
				if ((this._kutu4 != value))
				{
					this.Onkutu4Changing(value);
					this.SendPropertyChanging();
					this._kutu4 = value;
					this.SendPropertyChanged("kutu4");
					this.Onkutu4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu5")]
		public bool kutu5
		{
			get
			{
				return this._kutu5;
			}
			set
			{
				if ((this._kutu5 != value))
				{
					this.Onkutu5Changing(value);
					this.SendPropertyChanging();
					this._kutu5 = value;
					this.SendPropertyChanged("kutu5");
					this.Onkutu5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu6")]
		public bool kutu6
		{
			get
			{
				return this._kutu6;
			}
			set
			{
				if ((this._kutu6 != value))
				{
					this.Onkutu6Changing(value);
					this.SendPropertyChanging();
					this._kutu6 = value;
					this.SendPropertyChanged("kutu6");
					this.Onkutu6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu7")]
		public bool kutu7
		{
			get
			{
				return this._kutu7;
			}
			set
			{
				if ((this._kutu7 != value))
				{
					this.Onkutu7Changing(value);
					this.SendPropertyChanging();
					this._kutu7 = value;
					this.SendPropertyChanged("kutu7");
					this.Onkutu7Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu8")]
		public bool kutu8
		{
			get
			{
				return this._kutu8;
			}
			set
			{
				if ((this._kutu8 != value))
				{
					this.Onkutu8Changing(value);
					this.SendPropertyChanging();
					this._kutu8 = value;
					this.SendPropertyChanged("kutu8");
					this.Onkutu8Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu9")]
		public bool kutu9
		{
			get
			{
				return this._kutu9;
			}
			set
			{
				if ((this._kutu9 != value))
				{
					this.Onkutu9Changing(value);
					this.SendPropertyChanging();
					this._kutu9 = value;
					this.SendPropertyChanged("kutu9");
					this.Onkutu9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu10")]
		public bool kutu10
		{
			get
			{
				return this._kutu10;
			}
			set
			{
				if ((this._kutu10 != value))
				{
					this.Onkutu10Changing(value);
					this.SendPropertyChanging();
					this._kutu10 = value;
					this.SendPropertyChanged("kutu10");
					this.Onkutu10Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu11")]
		public bool kutu11
		{
			get
			{
				return this._kutu11;
			}
			set
			{
				if ((this._kutu11 != value))
				{
					this.Onkutu11Changing(value);
					this.SendPropertyChanging();
					this._kutu11 = value;
					this.SendPropertyChanged("kutu11");
					this.Onkutu11Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu12")]
		public bool kutu12
		{
			get
			{
				return this._kutu12;
			}
			set
			{
				if ((this._kutu12 != value))
				{
					this.Onkutu12Changing(value);
					this.SendPropertyChanging();
					this._kutu12 = value;
					this.SendPropertyChanged("kutu12");
					this.Onkutu12Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu13")]
		public bool kutu13
		{
			get
			{
				return this._kutu13;
			}
			set
			{
				if ((this._kutu13 != value))
				{
					this.Onkutu13Changing(value);
					this.SendPropertyChanging();
					this._kutu13 = value;
					this.SendPropertyChanged("kutu13");
					this.Onkutu13Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu14")]
		public bool kutu14
		{
			get
			{
				return this._kutu14;
			}
			set
			{
				if ((this._kutu14 != value))
				{
					this.Onkutu14Changing(value);
					this.SendPropertyChanging();
					this._kutu14 = value;
					this.SendPropertyChanged("kutu14");
					this.Onkutu14Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu15")]
		public bool kutu15
		{
			get
			{
				return this._kutu15;
			}
			set
			{
				if ((this._kutu15 != value))
				{
					this.Onkutu15Changing(value);
					this.SendPropertyChanging();
					this._kutu15 = value;
					this.SendPropertyChanged("kutu15");
					this.Onkutu15Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu16")]
		public bool kutu16
		{
			get
			{
				return this._kutu16;
			}
			set
			{
				if ((this._kutu16 != value))
				{
					this.Onkutu16Changing(value);
					this.SendPropertyChanging();
					this._kutu16 = value;
					this.SendPropertyChanged("kutu16");
					this.Onkutu16Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu17")]
		public bool kutu17
		{
			get
			{
				return this._kutu17;
			}
			set
			{
				if ((this._kutu17 != value))
				{
					this.Onkutu17Changing(value);
					this.SendPropertyChanging();
					this._kutu17 = value;
					this.SendPropertyChanged("kutu17");
					this.Onkutu17Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu18")]
		public bool kutu18
		{
			get
			{
				return this._kutu18;
			}
			set
			{
				if ((this._kutu18 != value))
				{
					this.Onkutu18Changing(value);
					this.SendPropertyChanging();
					this._kutu18 = value;
					this.SendPropertyChanged("kutu18");
					this.Onkutu18Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu19")]
		public bool kutu19
		{
			get
			{
				return this._kutu19;
			}
			set
			{
				if ((this._kutu19 != value))
				{
					this.Onkutu19Changing(value);
					this.SendPropertyChanging();
					this._kutu19 = value;
					this.SendPropertyChanged("kutu19");
					this.Onkutu19Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu20")]
		public bool kutu20
		{
			get
			{
				return this._kutu20;
			}
			set
			{
				if ((this._kutu20 != value))
				{
					this.Onkutu20Changing(value);
					this.SendPropertyChanging();
					this._kutu20 = value;
					this.SendPropertyChanged("kutu20");
					this.Onkutu20Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu21")]
		public bool kutu21
		{
			get
			{
				return this._kutu21;
			}
			set
			{
				if ((this._kutu21 != value))
				{
					this.Onkutu21Changing(value);
					this.SendPropertyChanging();
					this._kutu21 = value;
					this.SendPropertyChanged("kutu21");
					this.Onkutu21Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu22")]
		public bool kutu22
		{
			get
			{
				return this._kutu22;
			}
			set
			{
				if ((this._kutu22 != value))
				{
					this.Onkutu22Changing(value);
					this.SendPropertyChanging();
					this._kutu22 = value;
					this.SendPropertyChanged("kutu22");
					this.Onkutu22Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu23")]
		public bool kutu23
		{
			get
			{
				return this._kutu23;
			}
			set
			{
				if ((this._kutu23 != value))
				{
					this.Onkutu23Changing(value);
					this.SendPropertyChanging();
					this._kutu23 = value;
					this.SendPropertyChanged("kutu23");
					this.Onkutu23Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu24")]
		public bool kutu24
		{
			get
			{
				return this._kutu24;
			}
			set
			{
				if ((this._kutu24 != value))
				{
					this.Onkutu24Changing(value);
					this.SendPropertyChanging();
					this._kutu24 = value;
					this.SendPropertyChanged("kutu24");
					this.Onkutu24Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu25")]
		public bool kutu25
		{
			get
			{
				return this._kutu25;
			}
			set
			{
				if ((this._kutu25 != value))
				{
					this.Onkutu25Changing(value);
					this.SendPropertyChanging();
					this._kutu25 = value;
					this.SendPropertyChanged("kutu25");
					this.Onkutu25Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu26")]
		public bool kutu26
		{
			get
			{
				return this._kutu26;
			}
			set
			{
				if ((this._kutu26 != value))
				{
					this.Onkutu26Changing(value);
					this.SendPropertyChanging();
					this._kutu26 = value;
					this.SendPropertyChanged("kutu26");
					this.Onkutu26Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu27")]
		public bool kutu27
		{
			get
			{
				return this._kutu27;
			}
			set
			{
				if ((this._kutu27 != value))
				{
					this.Onkutu27Changing(value);
					this.SendPropertyChanging();
					this._kutu27 = value;
					this.SendPropertyChanged("kutu27");
					this.Onkutu27Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu28")]
		public bool kutu28
		{
			get
			{
				return this._kutu28;
			}
			set
			{
				if ((this._kutu28 != value))
				{
					this.Onkutu28Changing(value);
					this.SendPropertyChanging();
					this._kutu28 = value;
					this.SendPropertyChanged("kutu28");
					this.Onkutu28Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu29")]
		public bool kutu29
		{
			get
			{
				return this._kutu29;
			}
			set
			{
				if ((this._kutu29 != value))
				{
					this.Onkutu29Changing(value);
					this.SendPropertyChanging();
					this._kutu29 = value;
					this.SendPropertyChanged("kutu29");
					this.Onkutu29Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu30")]
		public bool kutu30
		{
			get
			{
				return this._kutu30;
			}
			set
			{
				if ((this._kutu30 != value))
				{
					this.Onkutu30Changing(value);
					this.SendPropertyChanging();
					this._kutu30 = value;
					this.SendPropertyChanged("kutu30");
					this.Onkutu30Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu31")]
		public bool kutu31
		{
			get
			{
				return this._kutu31;
			}
			set
			{
				if ((this._kutu31 != value))
				{
					this.Onkutu31Changing(value);
					this.SendPropertyChanging();
					this._kutu31 = value;
					this.SendPropertyChanged("kutu31");
					this.Onkutu31Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kutu32")]
		public bool kutu32
		{
			get
			{
				return this._kutu32;
			}
			set
			{
				if ((this._kutu32 != value))
				{
					this.Onkutu32Changing(value);
					this.SendPropertyChanging();
					this._kutu32 = value;
					this.SendPropertyChanged("kutu32");
					this.Onkutu32Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class kayit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kuladi;
		
		private string _sifre;
		
		private int _kulid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkuladiChanging(string value);
    partial void OnkuladiChanged();
    partial void OnsifreChanging(string value);
    partial void OnsifreChanged();
    partial void OnkulidChanging(int value);
    partial void OnkulidChanged();
    #endregion
		
		public kayit()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kuladi", CanBeNull=false)]
		public string kuladi
		{
			get
			{
				return this._kuladi;
			}
			set
			{
				if ((this._kuladi != value))
				{
					this.OnkuladiChanging(value);
					this.SendPropertyChanging();
					this._kuladi = value;
					this.SendPropertyChanged("kuladi");
					this.OnkuladiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifre", CanBeNull=false)]
		public string sifre
		{
			get
			{
				return this._sifre;
			}
			set
			{
				if ((this._sifre != value))
				{
					this.OnsifreChanging(value);
					this.SendPropertyChanging();
					this._sifre = value;
					this.SendPropertyChanged("sifre");
					this.OnsifreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kulid", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int kulid
		{
			get
			{
				return this._kulid;
			}
			set
			{
				if ((this._kulid != value))
				{
					this.OnkulidChanging(value);
					this.SendPropertyChanging();
					this._kulid = value;
					this.SendPropertyChanged("kulid");
					this.OnkulidChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class doktor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _adi;
		
		private string _soyadi;
		
		private int _tc1;
		
		private int _telefon;
		
		private string _eposta;
		
		private string _cinsiyet;
		
		private int _doktorid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadiChanging(string value);
    partial void OnadiChanged();
    partial void OnsoyadiChanging(string value);
    partial void OnsoyadiChanged();
    partial void Ontc1Changing(int value);
    partial void Ontc1Changed();
    partial void OntelefonChanging(int value);
    partial void OntelefonChanged();
    partial void OnepostaChanging(string value);
    partial void OnepostaChanged();
    partial void OncinsiyetChanging(string value);
    partial void OncinsiyetChanged();
    partial void OndoktoridChanging(int value);
    partial void OndoktoridChanged();
    #endregion
		
		public doktor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adi", CanBeNull=false)]
		public string adi
		{
			get
			{
				return this._adi;
			}
			set
			{
				if ((this._adi != value))
				{
					this.OnadiChanging(value);
					this.SendPropertyChanging();
					this._adi = value;
					this.SendPropertyChanged("adi");
					this.OnadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soyadi", CanBeNull=false)]
		public string soyadi
		{
			get
			{
				return this._soyadi;
			}
			set
			{
				if ((this._soyadi != value))
				{
					this.OnsoyadiChanging(value);
					this.SendPropertyChanging();
					this._soyadi = value;
					this.SendPropertyChanged("soyadi");
					this.OnsoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tc1", IsPrimaryKey=true)]
		public int tc1
		{
			get
			{
				return this._tc1;
			}
			set
			{
				if ((this._tc1 != value))
				{
					this.Ontc1Changing(value);
					this.SendPropertyChanging();
					this._tc1 = value;
					this.SendPropertyChanged("tc1");
					this.Ontc1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon")]
		public int telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eposta", CanBeNull=false)]
		public string eposta
		{
			get
			{
				return this._eposta;
			}
			set
			{
				if ((this._eposta != value))
				{
					this.OnepostaChanging(value);
					this.SendPropertyChanging();
					this._eposta = value;
					this.SendPropertyChanged("eposta");
					this.OnepostaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cinsiyet", CanBeNull=false)]
		public string cinsiyet
		{
			get
			{
				return this._cinsiyet;
			}
			set
			{
				if ((this._cinsiyet != value))
				{
					this.OncinsiyetChanging(value);
					this.SendPropertyChanging();
					this._cinsiyet = value;
					this.SendPropertyChanged("cinsiyet");
					this.OncinsiyetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doktorid", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int doktorid
		{
			get
			{
				return this._doktorid;
			}
			set
			{
				if ((this._doktorid != value))
				{
					this.OndoktoridChanging(value);
					this.SendPropertyChanging();
					this._doktorid = value;
					this.SendPropertyChanged("doktorid");
					this.OndoktoridChanged();
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
}
#pragma warning restore 1591
