﻿using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// ehay_privilegeshow 权限显示和编辑 
    /// </summary>
    public class ehay_privilege_show  : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_privilege_show(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.ehay_privilege_show)
        {

        }
        
    }
}
