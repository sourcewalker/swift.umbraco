﻿using Swift.Umbraco.Models.DTO;
using System;

namespace Swift.Umbraco.Business.Manager.Interfaces
{
    public interface IParticipantManager
    {
        ParticipantDto FindById(Guid id);

        Guid GetOrCreateParticipant(ParticipantDto participant);

        bool UpdateParticipant(ParticipantDto participant);

        ParticipantDto GetByEmail(string email);
    }
}
