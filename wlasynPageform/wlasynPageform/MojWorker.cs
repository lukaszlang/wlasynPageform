using Soneta.Business;
using Soneta.Core;
using System;
using System.Collections.Generic;
using System.Text;


[assembly: Worker(typeof(wlasynPageform.MojWorker), typeof(Soneta.Towary.Towar))]

namespace wlasynPageform
{
    public class MojWorker
    {


        [Action("Uruchom worker", Target = ActionTarget.ToolbarWithText, Mode = ActionMode.SingleSession, Icon = ActionIcon.Book, Priority = 110)]
        public object worker()
        {
            return new MojaKlasa();
        }

    }
}
