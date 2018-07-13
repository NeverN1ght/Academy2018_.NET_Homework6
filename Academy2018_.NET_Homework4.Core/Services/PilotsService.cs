﻿using System.Collections.Generic;
using System.Linq;
using Academy2018_.NET_Homework4.Core.Abstractions;
using Academy2018_.NET_Homework4.Infrastructure.Abstractions;
using Academy2018_.NET_Homework4.Infrastructure.Models;
using Academy2018_.NET_Homework4.Shared.DTOs;
using AutoMapper;

namespace Academy2018_.NET_Homework4.Core.Services
{
    public class PilotsService: IService<PilotDto>
    {
        private readonly IRepository<Pilot> _repository;
        private readonly IMapper _mapper;

        public PilotsService(IRepository<Pilot> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<PilotDto> GetAll()
        {
            return _mapper.Map<IEnumerable<Pilot>, IEnumerable<PilotDto>>(
                _repository.Get());
        }

        public PilotDto GetById(object id)
        {
            return _mapper.Map<Pilot, PilotDto>(
                _repository.Get().FirstOrDefault(p => p.Id == (int)id));
        }

        public void Add(PilotDto pilotDto)
        {
            _repository.Create(
                _mapper.Map<PilotDto, Pilot>(pilotDto));
        }

        public void Update(object id, PilotDto pilotDto)
        {
            _repository.Update((int)id, _mapper.Map<PilotDto, Pilot>(pilotDto));
        }

        public void Delete(object id)
        {
            _repository.Delete((int)id);
        }
    }
}