using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ThePlanets.Model;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media.Imaging;

namespace ThePlanets.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <notes>
        /// Don't consider the viewmodel as just a replacement for the code-behind
        /// Don't make a big, fat viewmodel full of all the code you yanked from 
        /// a .xaml.cs file. Instead, treat the viewmodel more like a light, 
        /// page-specific facade into the model and various service classes.+
        /// </notes>

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            LoadPlanets();

            _cameras = new CameraViewModel[3];
            for (int i = 0; i < _cameras.Length; i++)
            {
                _cameras[i] = new CameraViewModel();
            }

            _cameras[0].Name = "Compare To Earth Camera";
            _cameras[0].IsEnabled = true;
            _cameras[1].Name = "From Orbit Camera";
            _cameras[1].IsEnabled = true;
            _cameras[2].Name = "From Surface Camera";
            _cameras[2].IsEnabled = true;
            
            _cameras[0].PropertyChanged += CameraViewModel_PropertyChanged;
            _cameras[0].IsSelected = true;

            CreateNewNote();

            PostNewNoteCommand = new RelayCommand(
                () => PostNewNote(),
                () => CanPostNewNote());

            SelectedPlanet = Planets[0];
            
            LoadNotes(SelectedPlanet);
            LoadImages(SelectedPlanet);
        }

        private void CameraViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var cvm = sender as CameraViewModel;

            if (e.PropertyName == "IsSelected" && cvm.IsSelected)
                SelectedCamera = cvm;
        }

        private CameraViewModel[] _cameras;
        public CameraViewModel[] Cameras 
        {
            get { return _cameras; }
        }

        private void LoadImages(Planet planet)
        {
             _cameras[0].Image = new BitmapImage(
                new Uri(SelectedPlanet.ComparedToEarthImage));
             _cameras[1].Image = new BitmapImage(
                new Uri(SelectedPlanet.FromOrbitImage));
            _cameras[2].Image = new BitmapImage(
                new Uri(SelectedPlanet.FromSurfaceImage));
        }

        private CameraViewModel _selectedCamera;
        public CameraViewModel SelectedCamera
        {
            get { return  _selectedCamera; }
            set 
            { 
                Set<CameraViewModel>(() => SelectedCamera, ref  _selectedCamera, value);
            }
        }

        private Planet _selectedPlanet;
        public Planet SelectedPlanet
        {
            get
            {
                return _selectedPlanet;
            }
            set
            {
                Set<Planet>(() => SelectedPlanet, ref _selectedPlanet, value);
            }
        }

        public ICommand SelectedPlanetChanged
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    if (p != null)
                    {
                        LoadNotes(p);
                        LoadImages(p);
                    }
                });
            }
        }

        public ICommand MercuryTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[0];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand VenusTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[1];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand EarthTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[2];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand MarsTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[3];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand JupiterTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[4];
                        LoadNotes(p);
                        LoadImages(p);
                });
            }
        }

        public ICommand SaturnTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[5];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand UranusTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[6];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }

        public ICommand NeptuneTapped
        {
            get
            {
                return new RelayCommand<Planet>((p) =>
                {
                    SelectedPlanet = Planets[7];
                    LoadNotes(p);
                    LoadImages(p);
                });
            }
        }




        private Note _newNote;
        public Note NewNote
        {
            get { return _newNote; }
            set { Set<Note>(() => NewNote, ref _newNote, value); }
        }

        private void CreateNewNote()
        {
            if (NewNote != null)
                NewNote.PropertyChanged -= NewNote_PropertyChanged;

            NewNote = new Note();
            NewNote.PropertyChanged += NewNote_PropertyChanged;
        }
        
        void NewNote_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "NoteText")
            {
                PostNewNoteCommand.RaiseCanExecuteChanged();
            }
        }

        public void PostNewNote()
        {
            NewNote.Source = "MOSW";
            Notes.Add(NewNote);
            
            CreateNewNote(); // I guess this clears out the note text after you post and rewires the event - see the CreateNewNote method
        }

        public bool CanPostNewNote()
        {
            return NewNote != null &&
                !string.IsNullOrEmpty(NewNote.NoteText);
        }

        private ObservableCollection<Note> _notes =
            new ObservableCollection<Note>();
        public ObservableCollection<Note> Notes
        {
            get { return _notes; }
        }

        public void LoadNotes(Planet planet)
        {
            // Clear out any previous notes.
            Notes.Clear();

            var notes = NoteDataService.Current.GetNotesByPlanet(planet);

            foreach (var note in notes)
                if (!Notes.Contains(note))
                    Notes.Add(note);
        }

        private ObservableCollection<Planet> _planets =
            new ObservableCollection<Planet>();
        public ObservableCollection<Planet> Planets
        {
            get { return _planets; }
        }

        public void LoadPlanets()
        {
            var planets = PlanetDataService.Current.GetPlanets();

            foreach (var planet in planets)
                if (!Planets.Contains(planet))
                    Planets.Add(planet);
        }

        public RelayCommand PostNewNoteCommand
        {
            get; private set;
        }


    }
}