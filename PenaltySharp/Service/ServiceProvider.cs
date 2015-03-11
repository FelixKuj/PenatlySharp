// -------------------------------------------------------------------------
// File name.........: ServiceProvider.cs
// Purpose ..........: Provide a instance of a Service for each entities in 
//                     the system
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 
// --------------------------------------------------------------------------


using PenaltySharp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PenaltySharp
{
    class ServiceProvider
    {
        static SpelareController _spelareControllerService;
        static RegelController _regelControllerSevice;
        static BöterController _böterControllerSevice;
        public static SpelareController GetSpelareService()
        {
            if (_spelareControllerService == null)
                _spelareControllerService = new SpelareController();

            return _spelareControllerService;
        }

        public static RegelController GetReglerService()
        {
            if (_regelControllerSevice == null)
                _regelControllerSevice = new RegelController();

            return _regelControllerSevice;
        }

        public static BöterController GetBöterService()
        {
            if (_böterControllerSevice == null)
                _böterControllerSevice = new BöterController();

            return _böterControllerSevice;
        }
    }

}