using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 27, 2017
 * Description: This is the abstract superclass CardList
 * Version: 0.1 - Created the CardList abstract class
 */

namespace COMP123_S2017_Lesson11B
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}