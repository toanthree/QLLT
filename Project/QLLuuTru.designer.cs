﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_luu_tru")]
	public partial class QLLuuTruDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public QLLuuTruDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_luu_truConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLLuuTruDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLuuTruDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLuuTruDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLuuTruDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hsrecord> Hsrecords
		{
			get
			{
				return this.GetTable<Hsrecord>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hsrecords")]
	public partial class Hsrecord
	{
		
		private int _Hsrecords_Id;
		
		private string _Tenphong;
		
		private string _Tenkho;
		
		private string _KHTT;
		
		private string _Namchinhly;
		
		private string _Donvi;
		
		private string _Vande;
		
		private string _Muclucso;
		
		private string _Hopso;
		
		private string _Hososo;
		
		private string _Tieude;
		
		private string _Chugiai;
		
		private string _ThoigianBD;
		
		private string _ThoigianKT;
		
		private string _Soluongto;
		
		private string _Ngonngu;
		
		private string _Buttich;
		
		private string _ThoihanBQ;
		
		private string _ChedoSD;
		
		private string _TinhtrangVL;
		
		private string _NguoilapHS;
		
		private string _Tencongtrinh;
		
		private string _Tenhangmuc;
		
		private string _Tengiaidoan;
		
		private string _Hopdongso;
		
		private string _DiadiemXD;
		
		private string _Domat;
		
		private string _Nam;
		
		private string _Vatmangtinkhac;
		
		private string _Tylebando;
		
		private string _Khobando;
		
		private string _Chatlieubando;
		
		private string _Hovaten;
		
		private string _Ngaysinh;
		
		private string _Quequan;
		
		private string _Dongho;
		
		private string _Thoiluongphat;
		
		private string _Tocdoghi;
		
		private string _Mucdotruycap;
		
		private string _Adduser;
		
		private string _Addtime;
		
		private System.Nullable<int> _Hsbooks_Id;
		
		private string _Hosocv;
		
		public Hsrecord()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hsrecords_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Hsrecords_Id
		{
			get
			{
				return this._Hsrecords_Id;
			}
			set
			{
				if ((this._Hsrecords_Id != value))
				{
					this._Hsrecords_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenphong", DbType="NVarChar(1000)")]
		public string Tenphong
		{
			get
			{
				return this._Tenphong;
			}
			set
			{
				if ((this._Tenphong != value))
				{
					this._Tenphong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenkho", DbType="NVarChar(1000)")]
		public string Tenkho
		{
			get
			{
				return this._Tenkho;
			}
			set
			{
				if ((this._Tenkho != value))
				{
					this._Tenkho = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KHTT", DbType="NVarChar(500)")]
		public string KHTT
		{
			get
			{
				return this._KHTT;
			}
			set
			{
				if ((this._KHTT != value))
				{
					this._KHTT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Namchinhly", DbType="NVarChar(50)")]
		public string Namchinhly
		{
			get
			{
				return this._Namchinhly;
			}
			set
			{
				if ((this._Namchinhly != value))
				{
					this._Namchinhly = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donvi", DbType="NVarChar(1000)")]
		public string Donvi
		{
			get
			{
				return this._Donvi;
			}
			set
			{
				if ((this._Donvi != value))
				{
					this._Donvi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vande", DbType="NVarChar(2000)")]
		public string Vande
		{
			get
			{
				return this._Vande;
			}
			set
			{
				if ((this._Vande != value))
				{
					this._Vande = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Muclucso", DbType="NVarChar(50)")]
		public string Muclucso
		{
			get
			{
				return this._Muclucso;
			}
			set
			{
				if ((this._Muclucso != value))
				{
					this._Muclucso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hopso", DbType="NVarChar(50)")]
		public string Hopso
		{
			get
			{
				return this._Hopso;
			}
			set
			{
				if ((this._Hopso != value))
				{
					this._Hopso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hososo", DbType="NVarChar(50)")]
		public string Hososo
		{
			get
			{
				return this._Hososo;
			}
			set
			{
				if ((this._Hososo != value))
				{
					this._Hososo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tieude", DbType="NVarChar(4000)")]
		public string Tieude
		{
			get
			{
				return this._Tieude;
			}
			set
			{
				if ((this._Tieude != value))
				{
					this._Tieude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chugiai", DbType="NVarChar(3000)")]
		public string Chugiai
		{
			get
			{
				return this._Chugiai;
			}
			set
			{
				if ((this._Chugiai != value))
				{
					this._Chugiai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoigianBD", DbType="NVarChar(50)")]
		public string ThoigianBD
		{
			get
			{
				return this._ThoigianBD;
			}
			set
			{
				if ((this._ThoigianBD != value))
				{
					this._ThoigianBD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoigianKT", DbType="NVarChar(50)")]
		public string ThoigianKT
		{
			get
			{
				return this._ThoigianKT;
			}
			set
			{
				if ((this._ThoigianKT != value))
				{
					this._ThoigianKT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluongto", DbType="NVarChar(50)")]
		public string Soluongto
		{
			get
			{
				return this._Soluongto;
			}
			set
			{
				if ((this._Soluongto != value))
				{
					this._Soluongto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngonngu", DbType="NVarChar(500)")]
		public string Ngonngu
		{
			get
			{
				return this._Ngonngu;
			}
			set
			{
				if ((this._Ngonngu != value))
				{
					this._Ngonngu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Buttich", DbType="NVarChar(500)")]
		public string Buttich
		{
			get
			{
				return this._Buttich;
			}
			set
			{
				if ((this._Buttich != value))
				{
					this._Buttich = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoihanBQ", DbType="NVarChar(50)")]
		public string ThoihanBQ
		{
			get
			{
				return this._ThoihanBQ;
			}
			set
			{
				if ((this._ThoihanBQ != value))
				{
					this._ThoihanBQ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChedoSD", DbType="NVarChar(500)")]
		public string ChedoSD
		{
			get
			{
				return this._ChedoSD;
			}
			set
			{
				if ((this._ChedoSD != value))
				{
					this._ChedoSD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhtrangVL", DbType="NVarChar(1000)")]
		public string TinhtrangVL
		{
			get
			{
				return this._TinhtrangVL;
			}
			set
			{
				if ((this._TinhtrangVL != value))
				{
					this._TinhtrangVL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoilapHS", DbType="NVarChar(500)")]
		public string NguoilapHS
		{
			get
			{
				return this._NguoilapHS;
			}
			set
			{
				if ((this._NguoilapHS != value))
				{
					this._NguoilapHS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tencongtrinh", DbType="NVarChar(3000)")]
		public string Tencongtrinh
		{
			get
			{
				return this._Tencongtrinh;
			}
			set
			{
				if ((this._Tencongtrinh != value))
				{
					this._Tencongtrinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenhangmuc", DbType="NVarChar(1000)")]
		public string Tenhangmuc
		{
			get
			{
				return this._Tenhangmuc;
			}
			set
			{
				if ((this._Tenhangmuc != value))
				{
					this._Tenhangmuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tengiaidoan", DbType="NVarChar(1000)")]
		public string Tengiaidoan
		{
			get
			{
				return this._Tengiaidoan;
			}
			set
			{
				if ((this._Tengiaidoan != value))
				{
					this._Tengiaidoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hopdongso", DbType="NVarChar(200)")]
		public string Hopdongso
		{
			get
			{
				return this._Hopdongso;
			}
			set
			{
				if ((this._Hopdongso != value))
				{
					this._Hopdongso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiadiemXD", DbType="NVarChar(2000)")]
		public string DiadiemXD
		{
			get
			{
				return this._DiadiemXD;
			}
			set
			{
				if ((this._DiadiemXD != value))
				{
					this._DiadiemXD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Domat", DbType="NVarChar(500)")]
		public string Domat
		{
			get
			{
				return this._Domat;
			}
			set
			{
				if ((this._Domat != value))
				{
					this._Domat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nam", DbType="NVarChar(50)")]
		public string Nam
		{
			get
			{
				return this._Nam;
			}
			set
			{
				if ((this._Nam != value))
				{
					this._Nam = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vatmangtinkhac", DbType="NVarChar(1000)")]
		public string Vatmangtinkhac
		{
			get
			{
				return this._Vatmangtinkhac;
			}
			set
			{
				if ((this._Vatmangtinkhac != value))
				{
					this._Vatmangtinkhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tylebando", DbType="NVarChar(100)")]
		public string Tylebando
		{
			get
			{
				return this._Tylebando;
			}
			set
			{
				if ((this._Tylebando != value))
				{
					this._Tylebando = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khobando", DbType="NVarChar(100)")]
		public string Khobando
		{
			get
			{
				return this._Khobando;
			}
			set
			{
				if ((this._Khobando != value))
				{
					this._Khobando = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chatlieubando", DbType="NVarChar(500)")]
		public string Chatlieubando
		{
			get
			{
				return this._Chatlieubando;
			}
			set
			{
				if ((this._Chatlieubando != value))
				{
					this._Chatlieubando = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hovaten", DbType="NVarChar(200)")]
		public string Hovaten
		{
			get
			{
				return this._Hovaten;
			}
			set
			{
				if ((this._Hovaten != value))
				{
					this._Hovaten = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="NVarChar(50)")]
		public string Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this._Ngaysinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quequan", DbType="NVarChar(1000)")]
		public string Quequan
		{
			get
			{
				return this._Quequan;
			}
			set
			{
				if ((this._Quequan != value))
				{
					this._Quequan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongho", DbType="NVarChar(500)")]
		public string Dongho
		{
			get
			{
				return this._Dongho;
			}
			set
			{
				if ((this._Dongho != value))
				{
					this._Dongho = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thoiluongphat", DbType="NVarChar(100)")]
		public string Thoiluongphat
		{
			get
			{
				return this._Thoiluongphat;
			}
			set
			{
				if ((this._Thoiluongphat != value))
				{
					this._Thoiluongphat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tocdoghi", DbType="NVarChar(100)")]
		public string Tocdoghi
		{
			get
			{
				return this._Tocdoghi;
			}
			set
			{
				if ((this._Tocdoghi != value))
				{
					this._Tocdoghi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mucdotruycap", DbType="NVarChar(50)")]
		public string Mucdotruycap
		{
			get
			{
				return this._Mucdotruycap;
			}
			set
			{
				if ((this._Mucdotruycap != value))
				{
					this._Mucdotruycap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adduser", DbType="NVarChar(200)")]
		public string Adduser
		{
			get
			{
				return this._Adduser;
			}
			set
			{
				if ((this._Adduser != value))
				{
					this._Adduser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Addtime", DbType="NVarChar(100)")]
		public string Addtime
		{
			get
			{
				return this._Addtime;
			}
			set
			{
				if ((this._Addtime != value))
				{
					this._Addtime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hsbooks_Id", DbType="Int")]
		public System.Nullable<int> Hsbooks_Id
		{
			get
			{
				return this._Hsbooks_Id;
			}
			set
			{
				if ((this._Hsbooks_Id != value))
				{
					this._Hsbooks_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hosocv", DbType="NVarChar(50)")]
		public string Hosocv
		{
			get
			{
				return this._Hosocv;
			}
			set
			{
				if ((this._Hosocv != value))
				{
					this._Hosocv = value;
				}
			}
		}
	}
}
#pragma warning restore 1591