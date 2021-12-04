/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 12/09/2021
Description:
    A GUI app that utilizes OOP concepts to calculate the area and perimeter of a shape given the dimensions.
*/

/*
NOTE: i need to use inheritence or polymorphism for my area and perimeter functions
maybe make objects for each shape that each have a area() and perimeter() functions?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    static class assignment5
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gui());
        }
    }
}
