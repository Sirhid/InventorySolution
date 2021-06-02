using HRIS.Application.DTOs.SubCategory;
using System.Collections.Generic;

namespace HRIS.Application.Interfaces.Repositories
{
    public interface ISubCategoryService
    {
        int CreateSubCategory(CreateSubCategoryDTO model);
        int UpdateSubCategory(UpdateSubCategoryDTO model);
        int DeleteSubCategory(DeleteSubCategoryDTO model);
        List<SubCategoryDTO> GetAllSubCategory();
        SubCategoryDTO GetSubCategoryById(int subCategoryId);
    }
}
