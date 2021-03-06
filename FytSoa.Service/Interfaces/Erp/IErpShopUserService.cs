﻿using FytSoa.Common;
using FytSoa.Core.Model.Erp;
using FytSoa.Service.DtoModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FytSoa.Service.Interfaces
{
    /// <summary>
    /// 店铺会员管理服务接口
    /// </summary>
    public interface IErpShopUserService
    {
        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<ErpShopUser>>> GetPagesAsync(PageParm parm);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<ErpShopUser>> GetByGuidAsync(string parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(ErpShopUser parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(string parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(ErpShopUser parm);
    }
}
