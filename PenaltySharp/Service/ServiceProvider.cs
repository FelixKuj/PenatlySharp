﻿// -------------------------------------------------------------------------
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
        /// <summary>
        /// Kollar om SpelareController redan finns, annars skapar den.
        /// </summary>
        /// <returns>SpelareController</returns>
        public static SpelareController GetSpelareService()
        {
            if (_spelareControllerService == null)
                _spelareControllerService = new SpelareController();

            return _spelareControllerService;
        }
        /// <summary>
        /// Kollar om RegelController redan finns, annars skapar den.
        /// </summary>
        /// <returns>RegelController</returns>
        public static RegelController GetReglerService()
        {
            if (_regelControllerSevice == null)
                _regelControllerSevice = new RegelController();

            return _regelControllerSevice;
        }
        /// <summary>
        /// Kollar om BöterController redan finns, annars skapar den.
        /// </summary>
        /// <returns>BöterController</returns>
        public static BöterController GetBöterService()
        {
            if (_böterControllerSevice == null)
                _böterControllerSevice = new BöterController();

            return _böterControllerSevice;
        }
    }

}