﻿using DAL.Interfaces;
using Models.Domain;
using Models.DTO;
using Models.Mapping.Helper;
using System;
using System.Linq;

namespace DAL.Entities
{
    public class InstantWinMomentManager : GenericManager<InstantWinMoment>, IInstantWinMomentManager
    {
        public InstantWinMomentManager()
        {

        }

        public InstantWinMomentDto FindById(Guid id)
        {
            return GetById(id).toDto();
        }

        public InstantWinMomentDto CheckAvailableWinningMoment()
        {
            //var query = new Sql()
            //                .Select("*")
            //                .From<InstantWinMoment>(_sqlProvider)
            //                .Where<InstantWinMoment>(moment =>
            //                            !moment.IsWon &&
            //                            moment.ActivationDate.ToUniversalTime() <= DateTime.UtcNow, _sqlProvider)
            //                .OrderBy<InstantWinMoment>(m => m.ActivationDate, _sqlProvider);
            var sqlQuery = "SELECT * FROM InstantWinMoment WHERE IsWon = 'False' AND ActivationDate <= @0 ORDER BY ActivationDate";
            return _database.Fetch<InstantWinMoment>(sqlQuery, DateTime.UtcNow).FirstOrDefault().toDto();
        }

        public bool MarkAsWon(InstantWinMomentDto momentDto)
        {
            var moment = GetById(momentDto.Id);
            moment.IsWon = true;
            return Update(moment);
        }

        public bool Create(InstantWinMomentDto momentDto)
        {
            return Create(momentDto);
        }
    }
}
