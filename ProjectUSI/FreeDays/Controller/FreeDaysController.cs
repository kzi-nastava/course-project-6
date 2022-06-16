using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    public class FreeDaysController
    {
        private FreeDays _model;
        private FreeDaysRepository _freeDaysRepository;
        private FreeDaysWindow _view;

        public FreeDaysController(FreeDays model, FreeDaysWindow view, FreeDaysRepository freeDaysRepository)
        {
            this._model = model;
            this._freeDaysRepository = freeDaysRepository;
            this._view = view;
        }
    }
}