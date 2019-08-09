﻿
using Models.Domain;
using Models.DTO;
using System.Collections.Generic;

namespace Models.Mapping.Helper
{
    public static class ParticipantMapper
    {
        public static ParticipantDto toDto(this Participant participant)
            => AutoMapper.Mapper.Map<Participant, ParticipantDto>(participant);

        public static Participant toEntity(this ParticipantDto participantDto)
            => AutoMapper.Mapper.Map<ParticipantDto, Participant>(participantDto);

        public static IEnumerable<Participant> toEntities(this IEnumerable<ParticipantDto> participantDtos)
            => AutoMapper.Mapper.Map<IEnumerable<ParticipantDto>, IEnumerable<Participant>>(participantDtos);

        public static IEnumerable<ParticipantDto> toDtos(this IEnumerable<Participant> participants)
            => AutoMapper.Mapper.Map<IEnumerable<Participant>, IEnumerable<ParticipantDto>>(participants);
    }
}
