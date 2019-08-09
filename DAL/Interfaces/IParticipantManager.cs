using Models.DTO;
using System;

namespace DAL.Interfaces
{
    public interface IParticipantManager
    {
        ParticipantDto FindById(Guid id);

        Guid GetOrCreateParticipant(ParticipantDto participant);

        bool UpdateParticipant(ParticipantDto participant);

        ParticipantDto GetByEmail(string email);
    }
}
