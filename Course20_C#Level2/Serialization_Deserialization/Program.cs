using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Serialization_Deserialization
{
	[Serializable]
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address{ get; set; }

		
		public void Print()
		{
			Console.WriteLine($"Person Name: {this.Name}\nperson ID: {this.Id}\nPerson Address: {this.Address}");
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{

			Person person = new Person();
			person.Id = 1;
			person.Name = "MHD Jihad Alsmadi";
			person.Address= "Syria,Damascus,Rukn Aldeen,Shikh Khaled";

			/*XML */
			XmlSerializer serializer = new XmlSerializer(typeof(Person));

			using(TextWriter writer = new StreamWriter("Person.xml"))
			{
				serializer.Serialize(writer,person);
			}

			using(TextReader reader = new StreamReader("Person.xml"))
			{
				Person personAfterDesirealiz= (Person)serializer.Deserialize(reader);
				personAfterDesirealiz.Print();
			}


			/*JSON*/
			DataContractJsonSerializer serializer2 = new DataContractJsonSerializer(typeof(Person));
			using (MemoryStream stream = new MemoryStream())
			{
				serializer2.WriteObject(stream, person);
				string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());


				// Save the JSON string to a file (optional)
				File.WriteAllText("person.json", jsonString);
			}


			// Deserialize the object back
			using (FileStream stream = new FileStream("person.json", FileMode.Open))
			{
				Person deserializedPerson = (Person)serializer2.ReadObject(stream);
				Console.WriteLine($"Name: {deserializedPerson.Name}, Address: {deserializedPerson.Address}");
				Console.ReadKey();

			}
			Console.ReadKey();
		}
	}
}
