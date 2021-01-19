﻿using System;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Window : BuildingElement
    {



        private string modelName;
        private double width;
        private double height;



        public Window(string modelName, double width, double height)
        {
            this.modelName = modelName;
            this.width = width;
            this.height = height;
        }



        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }



        // Model "Standard", 0,8 metru x 1,5 metru
        public static Window GetStandardWindow()
        {
            Window window = new Window("Standard", 0.8, 1.5);
            return window;
        }



        // Model "Francouz", 1,0 metru x 2,2 metru
        public static Window GetFrenchWindow()
        {
            Window window = new Window("Francouz", 1.0, 2.2);
            return window;
        }

        public override void DrawSelf(Graphics g, CanvasContext context)
        {
            float f = 6.9f;
            using (Pen pen = new Pen(Color.Red, f))
            {
                g.DrawRectangle(pen, context.Left + f, context.Top + f,
                                     context.Width - 2 * f, context.Height - 2 * f);
            }
        }

    }



}
