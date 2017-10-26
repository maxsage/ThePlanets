using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace ThePlanets.ViewModel
{
    // Maybe have surface, to earth and from orbit camera's
    // could also have from ocean where applicable (earth only)
 
    // Inheriting from the MVVMLight ViewModelBase provides functionality around 
    // change tracking, design mode support (blendability) and messaging.
    public class CameraViewModel : ViewModelBase
    {
        private string _name = "";

        /// <summary>
        /// Sets and gets the Name property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Set(() => Name, ref _name, value);
            }
        }

        private string _description = "";

        /// <summary>
        /// Sets and gets the Description property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Set(() => Description, ref _description, value);
            }
        }

        private int _zoom = 0;

        /// <summary>
        /// Sets and gets the Zoom property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int Zoom
        {
            get
            {
                return _zoom;
            }
            set
            {
                Set(() => Zoom, ref _zoom, value);
            }
        }

        private bool _isEnabled = false;

        /// <summary>
        /// Sets and gets the IsEnabled property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                Set(() => IsEnabled, ref _isEnabled, value);
            }
        }

        private bool _isSelected = false;
        public bool IsSelected
        {
            get 
            { 
                return _isSelected; 
            }
            set 
            {
                Set<bool>(() => IsSelected, ref _isSelected, value); 
            }
        }

        /// <summary>
        /// The <see cref="Image" /> property's name.
        /// </summary>
        public const string ImagePropertyName = "Image";

        private ImageSource _image;                                     

        /// <summary>
        /// Sets and gets the Image property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ImageSource Image
        {
            get
            {
                return _image;
            }
            set
            {
                Set(() => Image, ref _image, value);
            }
        }
    }
}
