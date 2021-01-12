﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UtilitiesDraw.BusinessObjects.HouseBuilding;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw
{
    public partial class CanvasForm : Form
    {

        private bool isDrawingVisible = false;

        public CanvasForm()
        {
            InitializeComponent();
        }

        //private void CanvasForm_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    //Pen pen = new Pen(Color.Black, 1.0f);
        //    Pen pen = new Pen(Color.Black, 2.0f);
        //    g.DrawLine(pen, 0, 0, 100, 100);
        //}

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawingVisible)
            {
                //Graphics g = e.Graphics;
                ////Pen pen = new Pen(Color.Black, 1.0f);
                //Pen pen = new Pen(Color.Black, 2.0f);
                //g.DrawLine(pen, 0, 0, 100, 100);
                //pen.Dispose();
                DrawAll(e.Graphics);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            this.isDrawingVisible = true;
            this.panelCanvas.Refresh();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.isDrawingVisible = false;
            this.panelCanvas.Refresh();
        }




        private void DrawAll(Graphics g)
        {
            BlockOfFlats block = BlockOfFlats.GetKLadviBlockOfFlats();
            CanvasContext context = new CanvasContext(0, 0, panelCanvas.Width, panelCanvas.Height);
            block.DrawSelf(g, context);
        }


    }

}
