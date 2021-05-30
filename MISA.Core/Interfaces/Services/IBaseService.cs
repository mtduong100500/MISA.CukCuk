using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public interface IBaseService<MisaEntity>
    {
        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="entity">Đối tượng thêm mới</param>
        /// <returns>Số bản ghi thêm mới thành công</returns>
        /// CreatedBy: MTDUONG(28/5/2021)
        int? Insert(MisaEntity entity);

        /// <summary>
        /// Sửa
        /// </summary>
        /// <param name="entity">Đối tượng chỉnh sửa</param>
        /// <returns>Bản ghi sửa thành công</returns>
        /// CreatedBy: MTDUONG(28/05/2021)
        int? Update(MisaEntity entity, Guid entityId);
    }
}
