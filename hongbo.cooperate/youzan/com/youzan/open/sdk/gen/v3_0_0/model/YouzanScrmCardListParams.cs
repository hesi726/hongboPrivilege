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

    public class YouzanScrmCardListParams : APIParams, FileParams
	{

		/// <summary>
		/// 页码
		/// </summary>
		private long? page;

		public virtual long? Page
		{
			set
			{
				this.page = value;
			}
			get
			{
				return this.page;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (page != null)
			{
				@params["page"] = page;
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