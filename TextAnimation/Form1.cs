using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnimation
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private async void GoAnimation_Click(object sender, EventArgs e)
        {
            int startPosition = 30;

            while (startPosition < Size.Width - label1.Size.Width - 50)
            {
                await Task.Delay(20);
                label1.Location = new System.Drawing.Point(startPosition += 5, 100);
            }
        }
    }
}