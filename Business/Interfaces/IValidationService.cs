﻿using Models.DTO;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IValidationService
    {
        Task<bool> IsOpenHoursForParticipationAsync();

        Task<(bool status, string errorMessage)> CanUserParticipateAsync(string email);

        Task<bool> CheckValidLogoAsync(string imageFilePath);

        bool ValidateCaptcha(string imageFilePath);

        Task<(bool Status, Guid ParticipationId, Guid ParticipantId)> HasNotCompletedPreviousWonFlow(string email);
    }
}
