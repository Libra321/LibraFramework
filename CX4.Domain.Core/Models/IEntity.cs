/********************************************************************************
 ****** 创 建 者    ：pengdong
 ****** 创建日期    ：2019/5/14 13:34:51
 ****** 功能描述    ：IEntity
 *******************************************************************************/

namespace CX4.Domain.Core.Models
{
    /// <summary>
    ///  用作泛型约束，表示继承自该接口的为领域实体
    /// </summary>
    public interface IEntity<TKey>
    {
        /// <summary>
        ///
        /// </summary>
        TKey ID { get; set; }
    }
}
