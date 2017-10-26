using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlanets.Model
{
    public class PlanetDataService
    {

        // This is a dummy data service. 
        // A real data service would:
        // - Pull the data from a datasource (WebApi, WebService or Database)
        // - Include functions for adding and deleting data.
        private static PlanetDataService _current = null;
        public static PlanetDataService Current
        {
            get
            {
                if (_current == null)
                    _current = new PlanetDataService();

                return _current;
            }
        }

        public IList<Planet> GetPlanets()
        {
            var planets = new List<Planet>();

            planets.Add(new Planet()
            {
                Id  = 1,
                Name = "Mercury",
                Description = "Mercury is the smallest and closest to the Sun of the eight planets in the Solar System, with an orbital period of about 88 Earth days.",
                Radius = 2440,
                AKA = new List<string>{ "Mercurius" },
                LengthOfDay = new TimeSpan(58, 15, 30, 00),
                ComparedToEarthImage = "ms-appx:/Assets/MercuryCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/MercuryFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/MercuryFromSurface.png"
            });

            planets.Add(new Planet()
            {
                Id = 2,
                Name = "Venus",
                Description = "Venus is the second planet from the Sun, orbiting it every 224.7 days. The planet is names after the Roman goddess of love and beauty.",
                Radius = 6052,
                AKA = new List<string> { "The Morning Star", "The Evening Star" },
                LengthOfDay = new TimeSpan(116, 18, 0, 0),
                ComparedToEarthImage = "ms-appx:/Assets/VenusCompareToEarth.jpg",
                FromOrbitImage = "ms-appx:/Assets/VenusFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/VenusFromSurface.jpg"
            });

            planets.Add(new Planet()
            {
                Id = 3,
                Name = "Earth",
                Description = "Earth is the third planet from the Sun, and the densest and fifth-largest of the eight planets in the Solar System. It is also the largets of the Solar System's four terrestrial planets.",
                Radius = 6371,
                AKA = new List<string> { "The World", "The Blue" },
                LengthOfDay = new TimeSpan(1, 0, 0, 0),
                ComparedToEarthImage = "ms-appx:/Assets/MercuryCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/MercuryFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/MercuryFromSurface.png"
            });

            planets.Add(new Planet()
            {
                Id = 4,
                Name = "Mars",
                Description = "Mars is the fourth planet from the Sun and the second smallest planet in the Solar System. Named after the Roman god of war, it is often described as the 'Red Planet', as the iron oxide prevalent on its surface gives it a reddish appearence.",
                Radius = 3396,
                AKA = new List<string> { "The Red Planet", "Her Desher" },
                LengthOfDay = new TimeSpan(1, 0, 40, 0),
                ComparedToEarthImage = "ms-appx:/Assets/MarsCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/MarsFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/MarsFromSurface.jpg"
            });

            planets.Add(new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                Description = "Jupiter is the fifth planet from the Sun and largest planet in the Solar System. It is a gas giant with mass one-thousandth that of the Sun but is two and a half times the mass of all the other planets in the Solar System combined.",
                Radius = 69911,
                AKA = new List<string> { "Zeus" },
                LengthOfDay = new TimeSpan(0, 9, 56, 0),
                ComparedToEarthImage = "ms-appx:/Assets/JupiterCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/JupiterFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/JupiterFromSurface.jpg"
            });

            planets.Add(new Planet()
            {
                Id = 6,
                Name = "Saturn",
                Description = "Saturn is the sixth planet from the Sun and second largest planet in the Solar System, after Jupiter. Named after the Roman god of agriculture, Saturn, its astronimical symbol represents the god's sickle.",
                Radius = 58232,
                AKA = new List<string> { "Cronos" },
                LengthOfDay = new TimeSpan(0, 10, 39,  0),
                ComparedToEarthImage = "ms-appx:/Assets/SaturnCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/SaturnFromOrbit.png",
                FromSurfaceImage = "ms-appx:/Assets/SaturnFromSurface.jpg"
            });


            // TODO Earth and Saturn still pointing to Mercury - SORT IT OUT
 
            planets.Add(new Planet()
            {
                Id = 7,
                Name = "Uranus",
                Description = "Uranus is the seventh planet from the Sun. It has the third-largest planetary radius and fourth-largets planetary mass in the Solar System.",
                Radius = 25362,
                AKA = new List<string> { "Georgian Sidus" },
                LengthOfDay = new TimeSpan(0, 17, 14, 0),
                ComparedToEarthImage = "ms-appx:/Assets/UranusCompareToEarth.jpg",
                FromOrbitImage = "ms-appx:/Assets/UranusFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/UranusFromSurface.jpg"
            });

            planets.Add(new Planet()
            {
                Id = 8,
                Name = "Neptune",
                Description = "Neptuen is the eighth and farthest planet from the Sun in the Solar System. It is the fourth-largest planet by diameter and the third-largest by mass. Among the gaseous planets in the solar system, Neptune is the most dense.",
                Radius = 24622,
                AKA = new List<string> { " " },
                LengthOfDay = new TimeSpan(0, 16, 6, 0),
                ComparedToEarthImage = "ms-appx:/Assets/NeptuneCompareToEarth.png",
                FromOrbitImage = "ms-appx:/Assets/NeptuneFromOrbit.jpg",
                FromSurfaceImage = "ms-appx:/Assets/NeptuneFromSurface.jpg"
            });

            return planets;
        }
    }
}
