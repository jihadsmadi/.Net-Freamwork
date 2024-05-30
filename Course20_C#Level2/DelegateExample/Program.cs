using ConsoleApp1;
using System;


namespace ConsoleApp1
{
	/* 1- Quiz On Eventes 
	when the degree change the thermostate rise an event and tell all the subscribers that the temprature changed*/


	/*public class TempratureChangeEventArgs : EventArgs
	{

		public double OldTemprature { get;}
		public double NewTemprature { get;}
		public double Diffrence { get;}

		public TempratureChangeEventArgs(double oldTemprature, double newTemprature)
		{
			OldTemprature = oldTemprature;
			NewTemprature = newTemprature;

			if(oldTemprature >= newTemprature)
			{
				Diffrence = oldTemprature - newTemprature;
			}else
			{
				Diffrence = newTemprature - oldTemprature;
			}

		}
	}

	public class Theromstate
	{
		public event EventHandler<TempratureChangeEventArgs> TempratureChanged;

		private double OldTemprature;
		private double CurentTemprature;

		public void SetTemprature(double newTemprature)
		{
			if(CurentTemprature != newTemprature)
			{
				OldTemprature = this.CurentTemprature;
				this.CurentTemprature = newTemprature;
				OnTempratureChanged(this.OldTemprature, this.CurentTemprature);
			}

		}

		private void OnTempratureChanged(double OldTemprature,double NewTemprature)
		{
			OnTempratureChanged(new TempratureChangeEventArgs(OldTemprature, NewTemprature)) ;
		}

		protected virtual void OnTempratureChanged(TempratureChangeEventArgs e)
		{
			TempratureChanged?.Invoke(this, e);
		}

	}

	public class Display
	{
		public void Subscribe(Theromstate theromstate)
		{
			theromstate.TempratureChanged += OnTempratureChanged;
		}
		private void OnTempratureChanged(object sender, TempratureChangeEventArgs e)
		{


			if (e.NewTemprature > e.OldTemprature)
			{
				Console.BackgroundColor = ConsoleColor.Green;
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
			}

			Console.WriteLine("\nTemprature Is Chanched Now \n");
			Console.WriteLine($"Temprature Changed From {e.OldTemprature}°C \n");
			Console.WriteLine($"Temprature Changed To   {e.NewTemprature}°C \n");
			Console.WriteLine($"Temprature Diffrence Is {e.Diffrence}°C \n");
			Console.WriteLine("-----------------------------------------------\n\n");
		}

	}*/


	/* 2- Quiz On Eventes 
	when The puplisher Add New Artical All Chanells Who Subscirbe With It Get A Sign And Handel What They Wants*/
	/*	public class Artical
		{
			public string title { get;  }
			public string content { get; }

			public Artical(string title, string content)
			{
				this.title = title;
				this.content = content;
			}
		}
		public class NewsPuplisher
		{

			public event EventHandler<Artical> NewNewsArtical;

			public void SetArtical(string title,string content)
			{
				OnNewNewsArtical(new Artical(title,content));
			}
			protected virtual void OnNewNewsArtical(Artical artical)
			{
				NewNewsArtical?.Invoke(this, artical);
			}
		}
		public class channel
		{
			public string name { get; }
			public channel(string name)
			{
				this.name = name;
			}

			public void Subscribe(NewsPuplisher puplisher)
			{
				puplisher.NewNewsArtical += HandelNewArticalAdded;
			}
			public void Unsubscribe(NewsPuplisher puplisher)
			{
				puplisher.NewNewsArtical -= HandelNewArticalAdded;
			}

			public void HandelNewArticalAdded(object sender, Artical artical)
			{
				Console.WriteLine($"Subscibe Class Name {name}\n");
				Console.WriteLine($"--------------------------\n");
				Console.WriteLine($"Articlal Title: {artical.title}\n");
				Console.WriteLine($"Articlal Content: {artical.content}\n");
				Console.WriteLine($"--------------------------\n\n");
			}
	/*
		Main Program:
			NewsPuplisher puplisher = new NewsPuplisher();
		channel Aljazira = new channel("Aljazira");
		channel BBC = new channel("BBC");

		Aljazira.Subscribe(puplisher);
				BBC.Subscribe(puplisher);

				puplisher.SetArtical("Gaza Under The Fire", "After More Than 10 monthes Isrial didn't stop killing palastine children and any shape of humen " +
					"and all countries around the word didn't do any thing");

				puplisher.SetArtical("China rocket blasts off for far side of Moon", "An uncrewed rocket carrying the Chang'e-6 probe blasted off from the Wenchang Space Launch Center" +
					" at about 17:27 local time (10:27 BST)");

				BBC.Unsubscribe(puplisher);
				puplisher.SetArtical("Liberia's President Joseph Boakai to set up first war crimes court", "Mr Boakai said Liberia had endured downpours of agony");

				Aljazira.Unsubscribe(puplisher);
				puplisher.SetArtical("And Then There Were None", "There is No Subscirbers Any More So It Dose not Importaint " );*/

	/* 3- Quiz On Delegate */

	public class calculater
	{
		public delegate double onCalculate(double num1, double num2);
		private onCalculate _onCalculate;

		public calculater(onCalculate calculateOperation)
		{
			_onCalculate = calculateOperation;
		}

		public double Calc(double num1, double num2)
		{
			if(_onCalculate != null)
			{
				return _onCalculate(num1,num2);
			}
			return -1;
		}
		
	}	



}



internal class Program
{
	static public double Add(double num1, double num2)
	{
		return num1 + num2;
	}
	static public double Sub(double num1, double num2)
	{
		return num1 - num2;
	}
	static public double Multi(double num1, double num2)
	{
		return num1 * num2;
	}
	static public double Divide(double num1, double num2)
	{
		return num1 / num2;
	}
	static void Main(string[] args)
	{
		calculater Addingcalc = new calculater(Add);
		calculater SubCalc = new calculater(Sub);
		calculater MultiCalc = new calculater(Multi);
		calculater Dividecalc = new calculater(Divide);

		Console.WriteLine($"Adding Func 25 + 5 = {Addingcalc.Calc(25, 5)} ");
		Console.WriteLine($"Sub Func 30 - 20   = {SubCalc.Calc(30, 20)} ");
		Console.WriteLine($"Multi Func 7 x 3 = {MultiCalc.Calc(7, 3)} ");
		Console.WriteLine($"Divide Func 36 / 6 = {Dividecalc.Calc(36, 6)} ");

	

		Console.ReadKey();
	}
}

