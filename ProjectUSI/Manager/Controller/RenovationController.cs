using System;
using System.Collections.Generic;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class RenovationController
    {
        private Renovation _model;
        private RenovationRepository _renovationRepository;
        private MainRepository _mainRepository;
        private RenovationWindow _view;

        public RenovationController(Renovation model, RenovationWindow view, MainRepository mainRepository)
        {
            this._model = model;
            this._mainRepository = mainRepository;
            this._renovationRepository = _mainRepository._RenovationRepository;
            this._view = view;
        }

        public void AddRenovation(Renovation Renovation)
        {
            _renovationRepository.Add(Renovation);
        }
        

        public void Renovate(string from, string to, string date)
        {
            // Room fromRoom = _renovationRepository.GetRoomRepository().GetRoomByName(from);
            // Room toRoom = _renovationRepository.GetRoomRepository().GetRoomByName(date);
            // Renovation Renovation = new Renovation(fromRoom, toRoom, date);
            // _RenovateRepository.Add(Renovation);
            // //TODO: ispraviti kada se ubaci glavni repozitorijum sa podacima i kvalitetno azurirati;
            // _RenovateRepository.GetEquipmentRepository().DecreaseQuantity(Renovation.From.Id);
        }


    }
}