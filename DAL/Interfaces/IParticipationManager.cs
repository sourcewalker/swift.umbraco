using Models.DTO;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IParticipationManager
    {
        ParticipationDto FindById(Guid id);

        ParticipationDto FindByEmail(string email);

        IEnumerable<ParticipationDto> FindAllByEmail(string email);

        (Guid participationId, Guid participantId) CreateParticipation(string email);

        bool UpdateParticipation(ParticipationDto participation);
    }
}
