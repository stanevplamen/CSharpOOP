using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryAPI
{
    public class FigureControllerExtended : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D c = Vector3D.Parse(splitFigString[1]);
                        double r = double.Parse(splitFigString[2]);
                        currentFigure = new Circle(c, r);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D bot = Vector3D.Parse(splitFigString[1]);
                        Vector3D top = Vector3D.Parse(splitFigString[2]);
                        double r = double.Parse(splitFigString[3]);
                        currentFigure = new Cylinder(bot, top, r);
                        break;
                    }
                default:
                    base.ExecuteFigureCreationCommand(splitFigString);
                    break;
            }
            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        IAreaMeasurable areaMeasurableFigure = currentFigure as IAreaMeasurable;
                        if (areaMeasurableFigure != null)
                        {
                            Console.WriteLine(areaMeasurableFigure.GetArea().ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        IVolumeMeasurable volumeMeasurableFigure = currentFigure as IVolumeMeasurable;
                        if (volumeMeasurableFigure != null)
                        {
                            Console.WriteLine(volumeMeasurableFigure.GetVolume().ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        IFlat flatFigure = currentFigure as IFlat;
                        if (flatFigure != null)
                        {
                            Console.WriteLine(flatFigure.GetNormal());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }

            base.ExecuteFigureInstanceCommand(splitCommand);
        }
    }
}