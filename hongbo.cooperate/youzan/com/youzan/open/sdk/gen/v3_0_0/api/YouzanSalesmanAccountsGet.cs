﻿using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanAccountsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountsGetResult;
    using YouzanSalesmanAccountsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountsGetParams;

    public class YouzanSalesmanAccountsGet : AbstractAPI <YouzanSalesmanAccountsGetParams, YouzanSalesmanAccountsGetResult>
	{

		public YouzanSalesmanAccountsGet()
		{
		}

		public YouzanSalesmanAccountsGet(YouzanSalesmanAccountsGetParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "GET";
			}
		}

		public override string Version
		{
			get
			{
				return "3.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.salesman.accounts.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}