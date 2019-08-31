using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrtanjeGrafovaZaRad
{
    class PressureVolumeGraph
    {
        

        /// <summary>
        /// Checking input point data and saving new point if data is good
        /// </summary>
        /// <param name="pr">pressure</param>
        /// <param name="vol">volume</param>
        /// <param name="temp">temperature</param>
        /// <returns>returns true if data is saved succesfully</returns>
        public static bool AddPoint(string pr, string vol)
        {
            double pressure;
            double volume;            
            bool isSuccesfull = false;

            if (double.TryParse(pr, out pressure) && double.TryParse(vol, out volume))
            {
                using (StreamWriter writer = new StreamWriter("Points.txt",true))
                {
                    string line = pressure + " " + volume;
                    writer.WriteLine(line);
                    isSuccesfull = true;
                }                
            }

            return isSuccesfull;
        }

        /// <summary>
        /// Delete file with points
        /// </summary>
        public static void DeletePoints()
        {
            File.Delete("Points.txt");
        }

        /// <summary>
        /// Updates List of points
        /// </summary>
        /// <returns>Updated list of points</returns>
        public static List<GraphPoint> UpdateListOfPoints()
        {
            List<GraphPoint> points = new List<GraphPoint>();

            if (File.Exists("Points.txt"))
            {
                using (StreamReader reader = new StreamReader("Points.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        string[] values = line.Split(' ');
                        GraphPoint newPoint = new GraphPoint();
                        newPoint.Pressure = Double.Parse(values[0]);
                        newPoint.Volume = Double.Parse(values[1]);

                        points.Add(newPoint);

                        line = reader.ReadLine();
                    }
                }
            }

            return points;
        }
    }

    public class GraphPoint
    {
        public double Pressure { get; set; }
        public double Volume { get; set; }
    }
}
