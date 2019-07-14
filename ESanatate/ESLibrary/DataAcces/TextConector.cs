using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESLibrary.Model;

namespace ESLibrary
{
    public class TextConector : IDataConnection
    {
        public ModelMedic AdaugaMedicNou (ModelMedic model)
        {
            model.Id = 1;
            return model;
        }
    }
}
