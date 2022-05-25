using AlatAssessment.Entity.DTOs;
using System.Threading.Tasks;

namespace AlatAssessment.Application.Services.Interfaces
{
    public interface IBankService
    {
        Task<GetBankResponseDto> GetAllBanksAsync();
    }
}
