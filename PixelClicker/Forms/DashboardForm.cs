using System;
using System.Drawing;
using System.Windows.Forms;
using PixelClicker.Services;

namespace PixelClicker.Forms
{
    public class DashboardForm : Form
    {
        public Label Label;

        public DashboardForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ClickerService clickerService = new ClickerService();
            clickerService.Start();

            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            Label = new Label();
            SuspendLayout();
            // 
            // Label
            // 
            Label.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label.Location = new Point(12, 9);
            Label.Name = "Label";
            Label.Size = new Size(260, 243);
            Label.TabIndex = 0;
            Label.Text = "Click on a location in any window where the colour which you want to be clicked on resides";
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(Label);
            Name = "DashboardForm";
            ResumeLayout(false);
        }
    }
}