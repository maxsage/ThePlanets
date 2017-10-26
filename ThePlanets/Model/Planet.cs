using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlanets.Model
{
    // Because these properties are not dependency properties like 
    // some of the properties of the controls in WPF are
    // (e.g. TextBlock.HeightProperty and Slider.ValueProperty)
    // we need to manually notify the binding system of any 
    // value changes.
    // This is accomplished through the INotifyPropertyChanged 
    // interface or, in the case of an MVVM Toolkit like MVVM Light
    // via the ObservableObject base class.
    // http://visualbasic.about.com/od/quicktips/qt/isdepenprop.htm
    // MVVM Light provides two code snippets mvvminpc and mvvminpclambda
    // mvvminpc provides skeleton code for getting and setting the 
    // property plus raising PropertyChanging and PropertyChanged 
    // events. 
    // mvvminpclambda provides the same functionality but uses lambda
    // expressions. The advantage of this to using mvvminpc is that
    // mvvminpc specifies the property name as a string whereas 
    // lambdas have the advantage of compile time checking for
    // property names.
    public class Planet : ObservableObject
    {
        private int _id;
        /// <summary>
        /// Sets and gets the Id property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                Set(() => Id, ref _id, value);
            }
        }

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

        /// <summary>
        /// The <see cref="Description" /> property's name.
        /// </summary>
        public const string DescriptionPropertyName = "Description";

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

        private int _radius = 0;

        /// <summary>
        /// Sets and gets the Radius property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                Set(() => Radius, ref _radius, value);
            }
        }

        private List<string> _aka;

        /// <summary>
        /// Sets and gets the AKA property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public List<string> AKA
        {
            get
            {
                return _aka;
            }
            set
            {
                Set(() => AKA, ref _aka, value);
            }
        }

        /// <summary>
        /// The <see cref="LengthOfDay" /> property's name.
        /// </summary>

        private TimeSpan _lengthOfDay;

        /// <summary>
        /// Sets and gets the LengthOfDay property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public TimeSpan LengthOfDay
        {
            get
            {
                return _lengthOfDay;
            }
            set
            {
                Set(() => LengthOfDay, ref _lengthOfDay, value);
            }
        }

        /// <summary>
        /// The <see cref="ComparedToEarthImage" /> property's name.
        /// </summary>
        public const string ComparedToEarthImagePropertyName = "ComparedToEarthImage";
            
        private string _comparedToEarthImage;

        /// <summary>
        /// Sets and gets the ComparedToEarthImage property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string ComparedToEarthImage
        {
            get
            {
                return _comparedToEarthImage;
            }
            set
            {
                Set(() => ComparedToEarthImage, ref _comparedToEarthImage, value);
            }
        }

        /// <summary>
        /// The <see cref="FromOrbitImage" /> property's name.
        /// </summary>
        public const string FromOrbitImagePropertyName = "FromOrbitImage";

        private string _fromOrbitImage;

        /// <summary>
        /// Sets and gets the FromOrbitImage property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string FromOrbitImage
        {
            get
            {
                return _fromOrbitImage;
            }
            set
            {
                Set(() => FromOrbitImage, ref _fromOrbitImage, value);
            }
        }

        /// <summary>
        /// The <see cref="FromSurfaceImage" /> property's name.
        /// </summary>
        public const string FromSurfaceImagePropertyName = "FromSurfaceImage";

        private string _fromSurfaceImage;

        /// <summary>
        /// Sets and gets the FromSurfaceImage property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string FromSurfaceImage
        {
            get
            {
                return _fromSurfaceImage;;
            }
            set
            {
                Set(() => FromSurfaceImage, ref _fromSurfaceImage, value);
            }
        }
    }
}
