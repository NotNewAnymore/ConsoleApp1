namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bike bicycle = new bike(2, "Yeah", "32") { Wheeltype = "Yeah!", Handles = "Tru" };
			
			Console.WriteLine("start! \n" + bicycle + "\n end");
		}//main
	}//class

	public class bike
	{
		enum chaintypes { chain1, chain2, chain3 }
		//Fields
		string _breaks;
		chaintypes _chain;
		string _wheeltype;
		int _gearnumber;
		string _frame;
		string _peadals;
		string _handles;
		int _seats;
		string _serial;

		//Quick action
		//CLick light bulb, alt+enter, or ctrl + .

		//Constructors
		public bike(int seats, string _handles, string serial)
		{
			_seats = seats;
			this._handles = _handles;
			_serial = serial;
		}
		//Properties
		public string Serial
		{
			//get { return _serial; }
			//set { _serial = value; }
			get => _serial;
			//set => _serial = value; //We've got to change the serial number all the time!
		}
        public string Breaks { get => _breaks; set => _breaks = value; }
        private chaintypes Chain { get => _chain; set => _chain = value; }
        public string Wheeltype { get => _wheeltype; set => _wheeltype = value; }
        public int Gearnumber { get => _gearnumber; set => _gearnumber = value; }
        public string Frame { get => _frame; set => _frame = value; }
        public string Peadals { get => _peadals; set => _peadals = value; }
        public string Handles { get => _handles; set => _handles = value; }
        public int Seats { get => _seats;
			set
			{
				if (value > 0)
				{
					Seats = value;
				}
				else
				{
					Console.WriteLine("Please enter a positive value");
				}
			}
		}

        //Methods
        public override string ToString()
		{
			return $"{Serial}";
		}
	}//class
}//mainspace