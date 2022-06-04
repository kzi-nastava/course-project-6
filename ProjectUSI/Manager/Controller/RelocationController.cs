using System;
using System.Collections.Generic;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class RelocationController
    {
        private Relocation _model;
        private RelocationRepository _relocateRepository;
        private MainRepository _mainRepository;
        private RelocateWindow _view;

        public RelocationController(Relocation model, RelocateWindow view, MainRepository mainRepository)
        {
            this._mainRepository = mainRepository;
            this._model = model;
            this._relocateRepository = _mainRepository.RelocationRepository;
            this._view = view;
        }

        public void AddRelocation(Relocation relocation)
        {
            _relocateRepository.Add(relocation);
        }

        public List<String> Rooms()
        {
            List<String> roomsFilledWithEquipment = new List<string>();
            foreach (Room room in _relocateRepository.GetRoomRepository().GetRooms())
            {
                roomsFilledWithEquipment.Add(room.Name);
            }

            return roomsFilledWithEquipment;
        }

        public void Relocate(string from, string to, string date)
        {
            Room fromRoom = _relocateRepository.GetRoomRepository().GetRoomByName(from);
            Room toRoom = _relocateRepository.GetRoomRepository().GetRoomByName(date);
            Relocation relocation = new Relocation(fromRoom, toRoom, date);
            _relocateRepository.Add(relocation);
            //TODO: ispraviti kada se ubaci glavni repozitorijum sa podacima i kvalitetno azurirati;
            _relocateRepository.GetEquipmentRepository().DecreaseQuantity(relocation.From.Id);
        }


    }
}