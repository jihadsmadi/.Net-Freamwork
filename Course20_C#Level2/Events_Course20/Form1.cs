using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Course20
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void uctlCalculater1_onCalculationComplete(object sender, uctlCalculater.onCalculationEventArgs e)
		{
			MessageBox.Show($"Result = {e.result} | Value1 = {e.val1} | Value2 = {e.val2}","done");

		}
	}
}
