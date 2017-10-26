using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlanets.Model
{
    public class NoteDataService
    {
        private static NoteDataService _current = null;
        public static NoteDataService Current
        {
            get
            {
                if (_current == null)
                    _current = new NoteDataService();

                return _current;
            }
        }

        public IList<Note> GetNotes()
        {
            var notes = new List<Note>();

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury is the planet closest to the Sun. It is not, however, very close, since it is 36 million miles, or 58 million kilometres away from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "The distances of planets from each other and from the Sun are often measured in Astronomical Units, AU. One AU is the average distance between the Earth and the Sun, 93 million miles, or 150 million kilometres. Using this system of measurement, Mercury is 0.39 AU from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Like all the other planets Mercury orbits round the Sun, but its orbit of the Sun lasts for only 88 days. The Earth's orbit lasts for 365 days and Pluto's orbit takes 249 years!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Because Mercury goes round the Sun so quickly, the planet was named after the messenger of the Roman Gods. The messenger Mercury, or Hermes as the Greeks knew him, is usually show as having wings on his helmet or on his sandals.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "When Mercury orbits the Sun, it travels 36 million miles, or 58 million kilometres in the 88 days of the orbit. It moves at a speed of 48 kilometres a second, or 107,372 miles an hour!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Unlike the Earth and most other planets Mercury only turns very slowly on it's axis, taking 59 days to complete the turn from day to night",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury's sunny side has a temperature rising to 400° Celsius or 750° Fahrenheit. Compare this to a warm summer's day in London, when the temperature might be 26° Celsius or 80° Fahrenheit.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury's dark side, however, is very cold indeed, with the temperature going down to -200° Celsius or -328° Fahrenheit.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury has no atmosphere around it to protect it from the Sun or to retain any heat when it rotates on it's axis.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus - some other fact about Venus",
                Source = "Somewhere else in my head"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus - some other fact about Venus",
                Source = "Somewhere else in my head"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus - some other fact about Venus",
                Source = "Somewhere else in my head"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus - some other fact about Venus",
                Source = "Somewhere else in my head"
            });

            return notes;
        }

        public IList<Note> GetNotesByPlanet(Planet planet)
        {
            var notes = new List<Note>();

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury is the planet closest to the Sun. It is not, however, very close, since it is 36 million miles, or 58 million kilometres away from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "The distances of planets from each other and from the Sun are often measured in Astronomical Units, AU. One AU is the average distance between the Earth and the Sun, 93 million miles, or 150 million kilometres. Using this system of measurement, Mercury is 0.39 AU from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Like all the other planets Mercury orbits round the Sun, but its orbit of the Sun lasts for only 88 days. The Earth's orbit lasts for 365 days and Pluto's orbit takes 249 years!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Because Mercury goes round the Sun so quickly, the planet was named after the messenger of the Roman Gods. The messenger Mercury, or Hermes as the Greeks knew him, is usually show as having wings on his helmet or on his sandals.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "When Mercury orbits the Sun, it travels 36 million miles, or 58 million kilometres in the 88 days of the orbit. It moves at a speed of 48 kilometres a second, or 107,372 miles an hour!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Unlike the Earth and most other planets Mercury only turns very slowly on it's axis, taking 59 days to complete the turn from day to night",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury's sunny side has a temperature rising to 400° Celsius or 750° Fahrenheit. Compare this to a warm summer's day in London, when the temperature might be 26° Celsius or 80° Fahrenheit.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury's dark side, however, is very cold indeed, with the temperature going down to -200° Celsius or -328° Fahrenheit.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury has no atmosphere around it to protect it from the Sun or to retain any heat when it rotates on it's axis.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury is quite a small planet. It's diameter, the distance right round it's middle, is only 3100 miles or 4990 kilometres. The diameter of the Earth is 7962 miles or 12,760 kilometres.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury's distance from the Earth is 57 million miles, or 92 million kilometres. Using Astronmical Units Mercury is 0.61 AU from the Earth.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury has no moons. Moons are satelites that travel with a planet as it orbits the Sun. The Earth has one moon, Mars has two very small ones, Jupiter, the giant of the planets, has 16!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "The surface of Mercury is covered with craters and completely dry. There is no possibility of life on Mercury",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "The first photographs of the surface of Mercury were taken by the USA Space Agency, NASA. The Mariner 10 spacecraft passed close to the planet in 1974 and 1975 and took very clear photographs.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "NASA's latest mission to Mercury is called Messenger. The Messenger spacecraft entered Mercury's orbit in March 2011 and is sending back new pictures of the planet. Messenger is now moving with Mercury round the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "From Messenger we know that Mercury has a large number of very deep and irregular pits. Some of these pits are several miles deep.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "Mercury is one of five planets that can be seen without using a telescope, the others are Venus, Mars, Jupiter and Saturn. When you look at the sky at night, the planets do not twinkle in the way that stars do. Mercury is not very easy to see, but it can be seen low in the West just after sunset or in the east just before dawn.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 1,
                NoteText = "About once every ten of fifteen years Mercury can be seen crossing the Sun. At this point it's orbit has come between the Sun and the Earth. This event is known as a transit. When watching any event near the Sun a proper filter must be used to protect the sight. With this filter Mercury can be seen as a tiny black dot slowly passing across the Sun. You must never try to look directly at the Sun without a filter.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is the brightest planet in the Solar System and can be seen even in daylight if you know where to look. When Venus is west of the Sun, she rises before the Sun in the morning and is known as the Morning Star. When she is east of the Sun, she shines in the evening just after sunset and is know as the Evening Star.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The word planet is from the ancient Greek word πλάνητης, planets, which means a wanderer, because they move through the stars, which seem to be fixed in the sky. This movement is becuase the planets are all orbiting around the sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus orbits round the Sun in 262 days. The Earth takes 365 days to complete an orbit of the Sun. So a year on Venus only lasts for 262 days!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus has phases like the moon because the orbit of Venus is between the Earth and the Sun. When Venus shows only a crescent, like the crescent moon, she is at her brightest because she is then very close to the Earth. You can only see the crescent with the help of a telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus has phases like the moon because the orbit of Venus is between the Earth and the Sun. When Venus shows only a crescent, like the crescent moon, she is at her brightest because she is then very close to the Earth. You can only see the crescent with the help of a telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is the 2nd planet from the Sun. The closest planet to the Sun is Mercury. Then comes Venus and then Earth, followed by Mars, Saturn, Jupiter, Uranus, Neptune and Pluto. There are other orbiting bodies beyond Pluto but astonomers do not agree about whether these are planets.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The planets in the Solar System are given the names of Roman Gods or their attendants. Venus is named after the Roman Goddess of love and beauty.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is the planet which is closest to the Earth and is a little smaller than Earth. The diameter of the Earth (the distance right round the middle of the Earth at the Equator) is 12,760 kilometres, or 7926 miles. The diameter of Venus is 12,103 kilometres, or 7520 miles.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus looks bigger than the Earth in figure 1 because of the very deep layer of gases that surround the planet.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus, like the other planet between the Earth and the Sun, Mercury, has no moons.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is 67 million miles, or 108 million kilometres, from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is covered by clouds of water vapour and sulphuric acid and the surface cannot be seen with an ordinary astronomy telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus is the hottest planet in the Solar System, even hotter than Mercury, which is closer to the Sun.  The temperature on the surface of Venus is about 860° Fahrenheit or 460° Celsius.  Compare this to a warm summer’s day in London, when the temperature might be 80° Fahrenheit or 26° Celsius.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The atmosphere on Venus is composed of carbon dioxide.  The surface is heated by radiation from the sun, but the heat cannot escape through the clouds and layer of carbon dioxide. (This is a “greenhouse effect”).",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "In 1975 the Soviet Union sent two spacecraft landers to Venus, Venera 9 and Venera 10. These landers were the very first to reach the planet’s surface and they  sent back images to the Earth.  It is not a very clear picture but it is famous since this is the first photograph we have of the surface of Venus.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The USA space agency, NASA, were able to see more of the surface of Venus by using advanced radar systems.  NASA’s Magellan spacecraft completed a full map of Venus’ surface in 1993.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "Venus has continents, mountains and craters.  This NASA photograph, taken by Magellan spacecraft radar that can get through the cloud, shows a planet that looks quite like the Earth.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "There is no life at all on Venus and life could never be supported there because of the extreme heat and the atmosphere.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The mountains and craters on Venus have all been given female names such as the crater called Billie Holiday after a female American jazz singer.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "There is only one male name -  the Maxwell Mountains which are called after the Scottish scientist James Clerk Maxwell.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 2,
                NoteText = "The largest continent on Venus has been named Aphrodite.  Aphrodite was the Greek Goddess of love and beauty and is really the same deity as Venus.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "Earth is the only planet that has an atmosphere containing 21 percent oxygen.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "Earth is the only planet that has liquid water on its surface.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is the only inner planet (Mercury, Venus, Earth and Mars) to have one large satellite, the Moon.  Mars has two very tiny moons.  Mercury and Venus have none.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is fragile.  Its surface is split into plates (tectonic plates) which float on a rocky mantle – the layer between the surface of the earth, its crust, and its hot liquid core.  The inside of the Earth is active and earthquakes, volcanoes and mountain building takes place along the boundaries of the tectonic plates. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "As a result of the Earth’s geological activity (the volcanoes and earthquakes) the surface of the Earth has far fewer craters than the surface of planets such as Mars, Venus and Mercury or the surface of the Moon.  The craters have sunk down or been worn away by wind and rain over millions of years.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "When viewed from outer space much of the Earth’s surface cannot be seen because of clouds of water vapour.  The water vapour makes the Earth, when seen from outside, into a brilliant shining orb.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is the third planet from the Sun and comes between the planet Venus and the planet Mars.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth takes 365¼ days to complete its orbit round the Sun.  The Earth’s year is therefore 365 days long but the ¼ days are added up and every fourth year has one extra day, on the 29th of February.  This fourth year is called a Leap Year (366 days) and is always a year which can be divided exactly by 4 – 2000, 2004, 2008, 2012, 2016.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The planets closer to the Sun, Mercury and Venus, have shorter years than the Earth.  The planets further away from the Sun have longer years; Pluto takes 249 of our years to make one orbit of the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "As the Earth orbits round the Sun it turns on its axis, rotating right round in 24 hours.  The side of the Earth that faces the Sun has daytime and the side of the Earth that is turned away from the Sun has night-time.  When it is daytime in Britain, it is night-time on the opposite side of the Earth in New Zealand.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "As the Earth orbits round the Sun it tilts very slightly and so gives us the seasons.  When the Earth has tilted so that the northern half of the Earth is a little away from the Sun, the northern hemisphere (meaning half of the Earth’s sphere) has winter. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "At this time the southern hemisphere is tilted very slightly towards the Sun and the southern hemisphere has summer.  Winter in  Britain means summer in  New Zealand.  Closer to the Equator there is much less difference between summer and winter.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is 93 million miles, or 150 million kilometres from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "We can also say that the Earth is 1 AU from the Sun. Astronomers (people who study the planets and stars) use a measurement called an Astronomical Unit, AU.  Earth’s measurements are taken as the standard for this system, so Earth is 1 AU from the Sun, Venus is 0.72 AU from the Sun and Mars is 1.52 AU from the Sun.  Pluto, furthest out, is 39.5 AU from the Sun.  How many million miles from the Sun is Pluto?",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth’s diameter, the distance round its middle at the Equator, is 7928 miles, or 12760 kilometres.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is not an exact sphere; the diameter going round the North and South Poles is slightly less than the diameter round the Equator.  The Polar diameter is 7891 miles, or 12700 kilometres.  (Try measuring the different diameters of an orange and you will see how they can differ).",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth is larger than Mercury, Venus and Mars, the planets closest to it.  On astronomy maps it often looks smaller than Venus because Venus is shown with a thick layer  of sulphuric acid which lies 40 miles above the surface.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 3,
                NoteText = "The Earth differs from all the other planets because it has such a wide diversity of life and intelligent beings.  This has only been possible because of the Earth’s atmosphere which has protected the Earth and allowed life to flourish. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars has both North and South polar ice caps, much like Earth. Also like Earth, both ice caps are made mostly of frozen water. With so much water frozen in the ice caps of Mars, some scientists think that life could have once existed there. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars is not much farther from the Sun than Earth. As a result, a typical year on Mars is 1 year and 320 days. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "While a year on Mars might be almost twice as long as a year on Earth, the length of a day there is almost identical. A Martian day is 24 hours and 39 minutes long, less than an hour longer than a day on Earth.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars has seasons like Earth too. These seasons are much longer than Earth seasons because Mars is so much farther from the sun. And don’t get your swim suits out just yet – the average high during a Martian summer day is 23 degrees F (-5 degrees C) – not exactly beach weather. ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars is one of only two planets in the solar system to be significantly smaller than Earth. If you looked at the two planets side by side, Earth would be a basketball while Mars is a softball.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Olympus Mons on Mars is the largest mountain in the solar system at more than 25 kilometers high (that’s three times higher than Mount Everest). It is so big that astronomers could see it through telescopes in the 19th century, almost 200 years ago! ",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Valles Marineris is the largest canyon in the solar system, stretching 4,000 kilometers across the planet’s surface. If you look at a picture of Mars taken from a telescope, you will see the giant gash that is Valles Marineris.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "The Borealis Basin makes up 40% of the planet’s surface, taking up almost the entire northern hemisphere.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars doesn’t have a protective layer of atmosphere like Earth, so it cannot store heat from the sun. As a result, the temperature on Mars regularly drops to -125 degrees F (-82 degrees C) in the winter and only rises to 23 degrees F (-5 degrees C) in the summer.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "The dust storms on Mars are larger than on any other planet in the solar system. Some dust storms on Mars can blanket almost the entire planet in just a few days.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 4,
                NoteText = "Mars has two moons Phobos and Deimos.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter is the giant of the Solar System, with a mass more than 300 times the mass of the Earth and is called after the ancient Roman sky-god, Jupiter, known to the Greeks as Zeus.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter has a diameter of 88,700 miles, or 142,750 kilometres.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter is the fifth planet in order from the Sun and is about 483 million miles, or 777 million kilometres from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "All planets in the Solar system orbit round the Sun.  The Earth takes just over 365 days, so the Earth’s year is 365 days.  It takes Jupiter 11.9 of the Earth’s years to make its orbit round the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Although Jupiter’s orbit, and therefore its year, is so much longer than the Earth’s, its day is much shorter.  The Earth turns on its own axis, turning away from the Sun and so giving us day and night, once every 24 hours.  Jupiter spins round much faster, turning on its axis once every 9.84 hours!",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter's fast spinning gives rise to very strong weather patterns in the clouds which surround the planet and so its appearance changes rapidly.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter is the stormiest planet in the Solar System.  There is a permanent, but ever-changing whirlpool of storms, known as Jupiter’s Great Red Spot which can be seen using a telescope.  The Red Spot was first seen by Robert Hooke in 1664.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter is the first of the “gas giants”, Jupiter, Saturn, Uranus and Neptune.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "The gas giants are entirely  composed of dense layers of gas.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter is made of  hydrogen, helium, methane and ammonia. The cloudy sphere has bright belts on it which change their shape.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Jupiter can be seen without a telescope and so was known in the ancient world, but it was not until the invention of telescopes that astronomers were able to see Jupiter’s moons.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "There are 64 moons in total, four of which are large enough to be easily observed with a small telescope.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "The first person to discover and observe Jupiter’s moons was Galileo (1564-1642).",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Closest to Jupiter is Io,  further away is Europa, and there are two large outer moons, Ganymede and Callisto.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Io is so close to the planet that the pull of Jupiter’s gravity is constantly disturbing Io’s surface with volcanic eruptions.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "Europa is coated with smooth ice, while Ganymede and Callisto both have much older ice, deeply pitted with craters.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "There is still much to be learnt about Jupiter.  On 5th August 2011 NASA, the US National Aeronautic and Space Administration launched the Juno unmanned spacecraft on a mission to Jupiter to try to learn more.  Juno was a Roman goddess and the wife of the god Jupiter.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 5,
                NoteText = "The spacecraft Juno will take five years to reach the planet Jupiter.  It is the first spacecraft to be solar-powered.",
                Source = "www.planetsforkids.org"
            });



            
            
            
            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn is the sixth planet in the Solar system and, when seen through a telescope, by far the most beautiful.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The bright globe of Saturn is surrounded by rings which may be composed of ice.  Three of these rings are visible from the Earth using a telescope.  Photographs sent back from the US Voyager spacecraft in the 1980s were able to identify further narrower rings “ringlets” in between the three main rings.  The main rings are labelled A, B and C, with A the outermost ring.  Recently more rings have been found.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn is the last planet that can be seen without using a telescope or binoculars and the planet was known in the ancient world before telescopes were invented.  The rings, however, can only be seen using a telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The rings were first seen by Galileo in 1610 through a telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn has at least 18 moons, satellites which orbit round the planet attracted to it by the planet’s gravity.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The largest of the moons, Titan, is the 2nd largest in the Solar system, after Jupiter’s moon, Ganymede.  Titan is larger than the Earth and is the only moon in the Solar system which is known to have an atmosphere.  The atmosphere consists of nitrogen and methane. Titans were  Jupiter’s giant sons.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn itself is named, like all the planets, after a Roman God.  Saturn was a rather mysterious God but it is believed that he was the God of sowing seed and of the harvest.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn is the second largest planet in the Solar System, after the giant Jupiter. Its mass is 95 times that of the Earth and it has a diameter of 75,098 miles, or 142,750 kilometres.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn is 886 million miles, or 1426 million kilometres, from the Sun.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Distances from the Sun are measured in Astronomical Units (AU).  The Earth is the standard unit, and is one AU from the Sun, so an AU equals 150 million kilometres (93 million miles), the distance of the Earth from the Sun.  Saturn is 9.5 AU from the Sun.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn takes 29½ years to make one complete orbit of the Sun.  The Earth takes one year.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Like Jupiter, however, Saturn spins much faster on its axis than the Earth.  The Earth completes one rotation (turning) on its axis in 24 hours, turning away from the Sun and back again to give us night and day.  Saturn, although so much bigger, completes a full rotation in just over 10 hours.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "This rapid spinning leads to hurricane-like storms far, far stronger than anything that is seen on the Earth.  There is a constant whirlwind storm at Saturn’s south pole which can be observed with the strongest telescopes.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The four largest outer planets, Jupiter, Saturn, Uranus and Neptune, are known as the “gas giants” since it is thought they are entirely made up of dense layers of gas.  Saturn is a great ball of hydrogen and helium.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "Saturn’s axis is tilted and as the planet orbits the Sun we get different views of the rings.  Twice in every orbit only the edge of the outermost ring can be seen; even that can only be seen by using the strongest telescopes.  Twice during the orbit we can see the fully opened rings.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The rings all orbit Saturn at different speeds and have gaps between them.  In 2010 a spacecraft from the NASA (US National Aeronautics and Space Administration)  Cassini mission went between rings F and G and is now orbiting Saturn.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 6,
                NoteText = "The instruments on board this Cassini spacecraft are sending back valuable information which may help scientists to understand more about these mysterious and beautiful rings.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus cannot be seen from the Earth without a telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "The seventh planet from the Sun, it was not known in ancient times, unlike the planets from Mercury to Saturn.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus was first seen by William Herschel in 1781 during a survey of the sky using a telescope.  In 1782 George III appointed Herschel as Astronomer Royal.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "William Herschel was born in Hanover, Germany.  He moved to England in 1757 in order to follow a career as a musician but after buying a book on astronomy he became interested only in watching the sky.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Herschel also discovered 2 of Uranus’ moons with a larger telescope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus has a total of 27 moons, most of whom are named after characters in Shakespeare’s Midsummer Night’s Dream.  The five major moons are called  Titania, Oberon, Miranda, Ariel and Umbriel.  Umbriel is not from Shakespeare but is the “melancholy sprite” in a poem by Alexander Pope.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus is one of the “gas giants”, the four outer planets which are entirely composed of gas, Jupiter, Saturn, Uranus and Neptune.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Most of the centre of Uranus is a frozen mass of ammonia and methane, which gives it the blue-green colour.  The atmosphere also contains hydrogen and helium.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus orbits the Sun lying on its side and takes 84 years to complete one orbit.  The Earth goes round the Sun in 365 days, one year.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Because Uranus is lying on its side as it orbits the sun, for nearly a quarter of its orbit one pole of the planet is in complete darkness.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus takes 17.9 hours to turn once on its own axis, faster than the Earth, which takes 24 hours and gives us the change from day to night.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus was the ancient Greek God of the heavens whose sons were the Giants and Titans.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus is the smallest of the four “giants”, but is still several times larger than the Earth.  It has a diameter of 29297 miles, or 47, 150 kilometres, compared to the Earth’s diameter of just under 8000 miles, or 12,760 kilometres.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Uranus is 1782 million miles, or 2869 million kilometres from the Sun.  Figure 1 does not show the distances from the Sun to scale, but Figure 2 lets you have an idea of how much further Uranus is from the Sun than the Earth.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "In 1977 Uranus passed in front of a star and astronomers observing the planet through giant telescopes saw nine rings around the planet.  These are very faint and not easily seen, unlike the rings around Saturn.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Photographs sent back by the Voyager spacecraft in the 1980s showed a further two rings round the planet.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "The Hubble Space telescope found two more very faint rings, very distant from the planet, between 2003 and 2005, so we now know of a total of 13 rings.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "Scientists do not yet understand exactly what causes these rings or exactly what they consist of.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "From the time when Uranus was first observed scientists noticed that at certain points in Uranus’ orbit the planet was being pulled further out into space. In the 19th century certain astronomers worked out that this must be because of the pull of gravity from another planet beyond Uranus.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 7,
                NoteText = "By making mathematical calculations based on the observations of Uranus, two astronomers, Adams and Le Verrier, identified where this other planet must be. The planet which was exerting a gravitational pull on Uranus was Neptune, 10.9 AU further out into space.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "The discovery of the planet Neptune was one of the most exciting discoveries in astronomy.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune cannot be seen without a large telescope and was first seen in 1846 from the observatory in Berlin. The existence of Neptune had actually been “discovered” a year earlier, in 1845.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune is the 8th planet from the Sun.  Uranus, the 7th planet, was first discovered by means of a telescope in 1781.  Two astronomers (scientists who study the stars and planets), J.C.Adams in England and Urbain Le Verrier in France, had been puzzled by the shape of Uranus’ orbit.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "The Berlin observatory, following Le Verrier’s calculations giving the possible position of this object, searched for Neptune and found the planet.  They named it Neptune after the Roman God of the Sea.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune is the third largest planet in the Solar System, much smaller than the real giants, Jupiter and Saturn, and only a little bigger than Uranus.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune has a diameter of 29,297 miles, or 47,150 kilometres.  The Earth has a diameter of 7928 miles (12,760 kilometres).",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune is one of the four “gas giants”.  Like Jupiter, Saturn and Uranus, it is composed only of gas.  Neptune is a great ball of hydrogen and helium.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Like all the other planets in the Solar System, Neptune moves in an orbit round the Sun at the centre of the system.  It takes Neptune 165 of our Earth years to orbit the Sun.  The Earth orbits the Sun in 365 days, one year.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "In 2011 Neptune completed the first orbit of the Sun since its discovery 165 years before in 1846.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Like all the other planets, Neptune turns on its own axis as it is orbiting the sun.  (Imagine walking round a large pond, but turning round and round as you go.)",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "The Earth turns right round on its own axis in 24 hours, giving us the change from day, when we face the Sun, to night, when our part of the Earth turns away from the Sun.  Neptune spins slightly faster on its axis, taking just over 19 hours to turn right round.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "The Earth is 150 million kilometres from the Sun (93 million miles) and this measurement is taken as the standard for astronomical measurements of distance.  Astronomers say that the Earth is one Astronomical Unit (1 AU) from the Sun.  Neptune is unimaginably further.",
                Source = "www.planetsforkids.org"
            });
            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Neptune is 30.1 Astronomical Units from the Sun, a staggering 2793 million miles (4495 million kilometres) from the Sun, and 2700 million miles from the Earth.",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "In the same year that Neptune was first seen, 1846, its first moon was also spotted and named Triton. Triton is a most unusual moon since it orbits Neptune in the opposite direction of Neptune’s own rotation on its axis.  All the other major satellites (moons) in the Solar System follow their planets round as they turn. Try orbiting the pond again, turning on your own axis, but this time take a friend to orbit round you.  If you are turning on your axis clockwise, have him go round you anticlockwise (be careful not to get so dizzy you fall in the pond!)",
                Source = "www.planetsforkids.org"
            });

            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "Triton is about the same size as our own moon.  A smaller moon, Nereid, was discovered by telescope in 1949 and six further moons were discovered in the 1980s by the Voyager spacecraft.  All these moons are between Triton and Neptune.",
                Source = "www.planetsforkids.org"
            });
            
            notes.Add(new Note()
            {
                PlanetId = 8,
                NoteText = "We now know that Neptune has 13 moons in total.  Since Neptune was the God of the Sea, all the moons are named after less important ancient Greek sea gods, like Triton, or sea nymphs, like Nereid.",
                Source = "www.planetsforkids.org"
            });
            
            return notes.Where(p => p.PlanetId == planet.Id).ToList();
        }
    }
}
