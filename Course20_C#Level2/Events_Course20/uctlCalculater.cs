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
	public partial class uctlCalculater : UserControl
	{
		public uctlCalculater()
		{
			InitializeComponent();
		}

		public class onCalculationEventArgs : EventArgs
		{
			public int val1 { get; }
			public int val2 { get; }
			public int result { get; }

			public onCalculationEventArgs(int val1, int val2, int result)
			{
				this.val1 = val1;
				this.val2 = val2;
				this.result = result;
			}
		}
		public event EventHandler<onCalculationEventArgs> onCalculationComplete;
		public void RiseOnCalculation(int val1 ,int val2,int result)
		{
			RiseOnCalculation(new onCalculationEventArgs(val1, val2, result));
		}
		protected virtual void  RiseOnCalculation(onCalculationEventArgs e)
		{
			onCalculationComplete?.Invoke(this,e);
		}
		private void uctlCalculater_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int val1 = Convert.ToInt32(textBox1.Text);
			int val2 = Convert.ToInt32(textBox2.Text);
			int result = val1 + val2;



			label2.Text = result.ToString();

			if(onCalculationComplete!= null)
			{
				RiseOnCalculation(val1,val2,result);
			}
		}
	}
}
