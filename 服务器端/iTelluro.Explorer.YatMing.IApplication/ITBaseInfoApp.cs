using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TBaseInfo基础方法接口
    /// </summary>
    public interface ITBaseInfoApp
    {
        /// <summary>
        /// 新增一条TBaseInfo记录
        /// </summary>
        /// <param name="dto">TBaseInfo实体</param>
        /// <returns>是否新增成功</returns>
        bool Add(TBaseInfoDTO dto);

        /// <summary>
        /// 根据主键删除一条TBaseInfo记录
        /// </summary>
        /// <param name="guid">TBaseInfo主键值</param>
        /// <returns>是否删除成功</returns>
        bool Remove(string guid);

        /// <summary>
        /// 更新一条TBaseInfo记录
        /// </summary>
        /// <param name="dto">TBaseInfo实体</param>
        /// <returns>是否更新成功</returns>
        bool Update(TBaseInfoDTO dto);

        /// <summary>
        /// 根据TBaseInfo主键获取一条记录
        /// </summary>
        /// <param name="guid">TBaseInfo主键值</param>
        /// <returns>根据主键查询到的TBaseInfo记录</returns>
        TBaseInfoDTO Get(string guid);

        /// <summary>
        /// 查询所有TBaseInfo记录
        /// </summary>
        /// <returns>TBaseInfo所有记录集合</returns>
        List<TBaseInfoDTO> GetAll();

        List<TBaseInfoDTO> QueryByKeyword(string key);

    }
}
