using AutoMapper;
using Models.Domain;
using Models.DTO;

namespace Models.Mapping
{
    public class DomainMapperProfile : Profile
    {
        public DomainMapperProfile()
        {
            Mapper.CreateMap<Consumer, ConsumerDto>()
                .ForMember(dest => dest.CountryEnum,
                           opts => opts.Ignore());
            Mapper.CreateMap<ConsumerDto, Consumer>();

            Mapper.CreateMap<Country, CountryDto>();
            Mapper.CreateMap<CountryDto, Country>();

            Mapper.CreateMap<FailedTransaction, FailedTransactionDto>();
            Mapper.CreateMap<FailedTransactionDto, FailedTransaction>();

            Mapper.CreateMap<InstantWinMoment, InstantWinMomentDto>();
            Mapper.CreateMap<InstantWinMomentDto, InstantWinMoment>();

            Mapper.CreateMap<Participation, ParticipationDto>()
                .ForMember(dest => dest.Email,
                           opts => opts.Ignore());
            Mapper.CreateMap<ParticipationDto, Participation>();

            Mapper.CreateMap<Participant, ParticipantDto>()
                .ForMember(dest => dest.Country,
                           opts => opts.Ignore())
                .ForMember(dest => dest.ConsumerId,
                           opts => opts.Ignore());
            Mapper.CreateMap<ParticipantDto, Participant>();

            Mapper.CreateMap<Prize, PrizeDto>();
            Mapper.CreateMap<PrizeDto, Prize>();
        }
    }
}
