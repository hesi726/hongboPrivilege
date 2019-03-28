﻿namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductCategoryDeleteResult : APIResult
	{



		/// <summary>
		/// 是否成功删除分类
		/// </summary>
[Newtonsoft.Json.JsonProperty("delete_result")]//) private Nullable<bool> deleteResult;
		private bool? deleteResult;

		public virtual bool? DeleteResult
		{
			set
			{
				this.deleteResult = value;
			}
			get
			{
				return this.deleteResult;
			}
		}



	}
}