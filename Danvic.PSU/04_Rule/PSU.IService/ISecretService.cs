﻿//-----------------------------------------------------------------------
// <copyright file= "ISecretService.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/2/11 星期日 13:46:31
// Modified by:
// Description: Secret控制器邻域功能接口
//-----------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
using PSU.EFCore;
using PSU.Entity.Basic;
using System.Threading.Tasks;

namespace PSU.IService
{
    public interface ISecretService
    {
        #region Service

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="account">账户</param>
        /// <param name="password">密码</param>
        /// <param name="context">数据库上下文对象</param>
        /// <returns></returns>
        Task<IdentityUser> GetUserAsync(string account, string password, ApplicationDbContext context);

        /// <summary>
        /// 设置当前登录用户
        /// </summary>
        /// <param name="oid"></param>
        /// <param name="context"></param>
        /// <param name="httpContextAccessor"></param>
        Task SetCurrentUser(string oid, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context);

        /// <summary>
        /// 移除当前用户
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <returns></returns>
        void RemoveCurrentUser(IHttpContextAccessor httpContextAccessor);

        /// <summary>
        /// 清除session数据
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <returns></returns>
        void ClearSession(IHttpContextAccessor httpContextAccessor);

        #endregion
    }
}
