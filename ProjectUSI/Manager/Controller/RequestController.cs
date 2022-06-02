using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class RequestController
    {
        private Request _model;
        private RequestRepository _requestRepository;
        private RequestWindow _view;

        public RequestController(Request model, RequestWindow view, RequestRepository requestRepository)
        {
            this._model = model;
            this._requestRepository = requestRepository;
            this._view = view;
        }
    }
}