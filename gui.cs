using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class gui : Form
    {
        enum Shape
        {
            Square,
            Circle,
            Sphere,
            Cube,
            Cylinder
        }

        private Shape selectedShape = Shape.Square;

        public gui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            selectedShape = Shape.Square;
            shapeLabel.Text = "Square";

            dim1Label.Text = "Length";
            dim1Label.Show();
            dim1Input.Show();

            dim2Label.Text = "Width";
            dim2Label.Show();
            dim2Input.Show();

            dim3Label.Hide();
            dim3Input.Hide();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            selectedShape = Shape.Circle;
            shapeLabel.Text = "Circle";

            dim1Label.Text = "Radius";
            dim1Label.Show();
            dim1Input.Show();

            dim2Label.Hide();
            dim2Input.Hide();

            dim3Label.Hide();
            dim3Input.Hide();
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            selectedShape = Shape.Sphere;
            shapeLabel.Text = "Sphere";

            dim1Label.Text = "Radius";
            dim1Label.Show();
            dim1Input.Show();

            dim2Label.Hide();
            dim2Input.Hide();

            dim3Label.Hide();
            dim3Input.Hide();
        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            selectedShape = Shape.Cube;
            shapeLabel.Text = "Cube";

            dim1Label.Text = "Length";
            dim1Label.Show();
            dim1Input.Show();

            dim2Label.Text = "Width";
            dim2Label.Show();
            dim2Input.Show();

            dim3Label.Text = "Height";
            dim3Label.Show();
            dim3Input.Show();
        }

        private void cylinerButton_Click(object sender, EventArgs e)
        {
            selectedShape = Shape.Cylinder;
            shapeLabel.Text = "Cylinder";

            dim1Label.Text = "Radius";
            dim1Label.Show();
            dim1Input.Show();

            dim2Label.Text = "Height";
            dim2Label.Show();
            dim2Input.Show();

            dim3Label.Hide();
            dim3Input.Hide();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            float length, width, height, radius;
            BaseShape chosenShape;

            switch (selectedShape)
            {
                case Shape.Square:
                    length  = float.Parse(dim1Input.Text);
                    width = float.Parse(dim2Input.Text);
                    chosenShape = new Square(length, width);
                    break;

                case Shape.Circle:
                    radius = float.Parse(dim1Input.Text);
                    chosenShape = new Circle(radius);
                    break;

                case Shape.Sphere:
                    radius = float.Parse(dim1Input.Text);
                    chosenShape = new Sphere(radius);
                    break;

                case Shape.Cube:
                    length = float.Parse(dim1Input.Text);
                    width = float.Parse(dim2Input.Text);
                    height = float.Parse(dim3Input.Text);
                    chosenShape = new Cube(length, width, height);
                    break;

                case Shape.Cylinder:
                    radius = float.Parse(dim1Input.Text);
                    height = float.Parse(dim2Input.Text);
                    chosenShape = new Cylinder(radius, height);
                    break;

                default:
                    chosenShape = new Square(0f, 0f);
                    break;
            }

            areaText.Text = chosenShape.area().ToString();
            perimeterText.Text = chosenShape.perimeter().ToString();
        }
    }
}
