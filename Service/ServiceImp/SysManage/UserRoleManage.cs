using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ServiceImp
{
    /// <summary>
    /// Service层用户与角色关系接口
    /// </summary>
    public class UserRoleManage : RepositoryBase<Domain.SYS_USER_ROLE>, IService.IUserRoleManage
    {
        /// <summary>
        /// 设置用户角色
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="roleId">角色ID字符串</param>
        public bool SetUserRole(int userId, string roleId)
        {
            try
            {
                //1、删除用户角色
                this.Delete(p => p.FK_USERID == userId);
                //2、设置当前用户的角色
                if (string.IsNullOrEmpty(roleId))
                    return true;
                var entityList = roleId.Split(',').Select(t => new Domain.SYS_USER_ROLE()
                {
                    FK_USERID = userId,
                    FK_ROLEID = int.Parse(t)
                }).ToList();
                return this.SaveList(entityList);
            }
            catch (Exception e) { throw e; }
        }
    }
}
