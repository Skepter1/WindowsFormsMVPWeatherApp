using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogodynka
{
    internal class Presenter
    {
        private readonly IView _view;
        private Model _model;

        public Presenter(Model model, IView view)
        {
            _model = model;
            _view = view;
        }
    }
}
