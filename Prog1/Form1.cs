//Program 1
//By: Richard Patrick
//Due Date: 2/14/16
//Section: CIS 199-01
//Description: This program allows the user to enter the square feet of wall space to paint,
//the number of coats, and the price of paint to calculate how much sq ft to be painted, how many gallons needed,
//along with the hours of labor required. It then gives the cost of paint, cost of labor, and the total cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double SQUARE_FT = 325;       // To declare a constant for square feet per gallon
            const double HOURS_PER_GALLON = 8;  // Declare a constant for hours per gallon
            const decimal LABOR_COST = 10.50m;  // To declare a constant for labor cost per hour

            double squareFootage;    // To hold the entered square footage
            byte paintCoats;         // To hold the amounts of coats of paint
            decimal pricePerGallon;  // To hold the price per gallon for paint
            double totalSquareFt;    // To hold the amount of total square footage
            double gallonsTotal;     // To hold the amount of total gallons needed
            double hoursTotal;       // To hold the needed total hours of labor
            decimal costPaint;       // To hold the cost of the paint
            decimal costLabor;       // To hold the cost of labor
            decimal costTotal;       // To hold the total cost of everything
            double ceiling;          // To hold the math ceiling for gallonsTotal

            squareFootage = double.Parse(squareFtTextBox.Text);  // Get the square footage from the squareFtTextBox
            paintCoats = byte.Parse(coatsTextBox.Text);          // Get the paint coats from the coatsTextBox
            pricePerGallon = decimal.Parse(costTextBox.Text);    // Get the price per gal from the costTextBox

            totalSquareFt = squareFootage * paintCoats;          // Calculate total squareft
            sqFtTotalLabel.Text = totalSquareFt.ToString("f1");  // Display total squareft
           
            gallonsTotal = totalSquareFt / SQUARE_FT;    // Calculate total gallons of paint
            ceiling = Math.Ceiling(gallonsTotal);        // Apply Math.Ceiling to round total gallons up
            gallonsUsedLabel.Text = ceiling.ToString();  //Display total gallons with the ceiling applied

            hoursTotal = gallonsTotal * HOURS_PER_GALLON;   // Calculate total hours of labor
            laborHrsLabel.Text = hoursTotal.ToString("n1"); // Display total hours of labor with one decimal

            costPaint = pricePerGallon*(decimal)ceiling;      // Convert ceiling and pricepergal to decimal and calcualte paint cost
            costPaintLabel.Text = costPaint.ToString("c");    // Display paint cost in currency formatting

            costLabor = (decimal)hoursTotal * LABOR_COST;   // Convert hoursTotal to decimal and calculate labor cost
            costLaborLabel.Text = costLabor.ToString("c");  // Display labor cost in currency formatting  

            costTotal = costPaint + costLabor;              // Calculate total cost
            totalCostLabel.Text = costTotal.ToString("c");  // Display total cost in currency formatting





        }
    }
}
