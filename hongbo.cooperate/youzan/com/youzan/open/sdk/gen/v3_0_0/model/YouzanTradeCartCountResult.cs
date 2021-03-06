﻿namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeCartCountResult : APIResult
	{



		/// <summary>
		/// 查询是否成功，true为成功，false为失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 购物车中商品个数
		/// </summary>
[Newtonsoft.Json.JsonProperty("data")]//) private Nullable<long> data;
		private long? data;

		public virtual bool? IsSuccess
		{
			set
			{
				this.isSuccess = value;
			}
			get
			{
				return this.isSuccess;
			}
		}

		public virtual long? Data
		{
			set
			{
				this.data = value;
			}
			get
			{
				return this.data;
			}
		}



	}
}