using HRIS.Application.DTOs.Expenditure;
using System.Collections.Generic;

namespace HRIS.Infrastructure.Interfaces.Repositories
{
    public interface IExpenditureRepository
    {
        int CreateExpenditure(ExpenditureDTO model);
        int DeleteExpenditure(int ExpenditureID);
        List<ExpenditureDTO> GetAllExpenditure();
        ExpenditureDTO GetExpenditureByID(int ExpenditureID);
        int UpdateExpenditure(UpdateExpenditureDTO model);
    }
}