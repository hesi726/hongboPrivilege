﻿using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanRetailProductUnitCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 状态（0表示禁用，1表示启用）
		/// </summary>
		private long? status;
		/// <summary>
		/// 单位名称
		/// </summary>
		private string unitName;

		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}


		public virtual long? Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}


		public virtual string UnitName
		{
			set
			{
				this.unitName = value;
			}
			get
			{
				return this.unitName;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (status != null)
			{
				@params["status"] = status;
			}
			if (!string.ReferenceEquals(unitName, null))
			{
				@params["unit_name"] = unitName;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}