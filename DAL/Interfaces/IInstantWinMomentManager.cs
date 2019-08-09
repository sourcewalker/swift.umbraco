using Models.DTO;
using System;

namespace DAL.Interfaces
{
    public interface IInstantWinMomentManager
    {
        bool MarkAsWon(InstantWinMomentDto momentDto);

        InstantWinMomentDto CheckAvailableWinningMoment();

        InstantWinMomentDto FindById(Guid id);

        bool Create(InstantWinMomentDto momentDto);
    }
}
