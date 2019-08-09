using Models.DTO;
using Models.Enum;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IParticipationService
    {
        Task<(bool creationStatus, Guid participationId, Guid participantId)> GetOrCreateEmailValidatedParticipationAsync(string email);

        Task<bool> UpdateLogoValidatedParticipationAsync(ParticipationDto participation);

        Task<(bool winStatus, PrizeDto prize)> UpdateInstantWinStatusAsync(ParticipationDto participationDto);

        string GetWonPrize(Guid participationId);

        string GetEmail(Guid participationId);

        bool CheckStatus(Guid participationId, JourneyStatus status);

        Task<(bool success, string consumerId)> UpdateUserInformationAsync(UserInfoDto userInfo);
    }
}
