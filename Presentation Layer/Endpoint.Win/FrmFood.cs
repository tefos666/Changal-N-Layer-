﻿using Changal.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endpoint.Win
{
    public partial class FrmFood : FrmPattern
    {
        private readonly FoodService foodService;
        public FrmFood()
        {
            InitializeComponent();
            foodService = new FoodService();
        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            var listFood = foodService.foodList();
            DgvFood.DataSource = listFood;
            DgvFood.Columns[0].HeaderText= "نام";
            DgvFood.Columns[1].HeaderText = "شرح";
            DgvFood.Columns[2].HeaderText = "قیمت";

            DgvFood.Columns[0].Width = 200;
            DgvFood.Columns[1].Width = 200;
            DgvFood.Columns[2].Width = 200;
        }
    }
}
