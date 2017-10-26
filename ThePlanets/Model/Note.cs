using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ThePlanets.Model
{
    public class Note : ObservableObject
    {

        /// <summary>
        /// The <see cref="PlanetId" /> property's name.
        /// </summary>
        public const string PlanetIdPropertyName = "PlanetId";

        private int _planetId;

        /// <summary>
        /// Sets and gets the PlanetId property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int PlanetId
        {
            get
            {
                return _planetId;
            }
            set
            {
                Set(() => PlanetId, ref _planetId, value);
            }
        }

        /// <summary>
        /// The <see cref="NoteText" /> property's name.
        /// </summary>
        public const string NoteTextPropertyName = "NoteText";

        private string _noteText = "";

        /// <summary>
        /// Sets and gets the NoteText property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                Set(() => NoteText, ref _noteText, value);
            }
        }

        /// <summary>
        /// The <see cref="Source" /> property's name.
        /// </summary>
        public const string SourcePropertyName = "Source";

        private string  _source = "";

        /// <summary>
        /// Sets and gets the Source property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
                Set(() => Source, ref _source, value);
            }
        }


    }
}
