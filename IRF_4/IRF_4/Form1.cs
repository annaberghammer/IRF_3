﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_4
{
    public partial class Form1 : Form
    {
        List<Flat> flats = new List<Flat>();
        RealEstateEntities context = new RealEstateEntities();

        
        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            flats = context.Flats.ToList();
        }
    }
}
