using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитування значень
                double sideA = double.Parse(txtSquareSide.Text);
                double radiusR = double.Parse(txtCircleRadius.Text);

                // Створення об'єктів
                Shape square = new Square(sideA);
                Shape circle = new Circle(radiusR);

                // Обчислення площ
                double squareArea = square.GetArea();
                double circleArea = circle.GetArea();

                // Виведення результатів
                txtSquareArea.Text = squareArea.ToString("F2");
                txtCircleArea.Text = circleArea.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу: " + ex.Message);
            }
        }
    }
}
