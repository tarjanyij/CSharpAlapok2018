namespace _04ConstruktorFinalizer
{
    internal class Base
    {
        /// <summary>
        /// readonly azt jelenti hogy a konstruktorban lehet csak értéket adni
        /// </summary>
        private readonly bool IsConstructed;


        /// <summary>
        /// Base Konstruktor
        /// </summary>
        public Base()
        {
            System.Console.WriteLine("Baselétrehozó Base()");
            IsInitiated = true;

            IsConstructed = true;

        }

        /// <summary>
        /// Második konstruktor
        /// </summary>
        /// <param name="name"></param>
        public Base(string name) : this()
        {
            Name = name;
            System.Console.WriteLine("Base létrehozó:Base(name)");
        }

        public Base(string name, string email) : this (name)
        {
            System.Console.WriteLine("Base létrehozó:Base(name),email");
            Email = email;
        }
        public string Name { get; private set; }

        /// <summary>
        /// megmutatja hogy az objektumpéldány létrehozáskor létrejötte a beállítáa
        /// </summary>
        public bool IsInitiated { get; set; }
        public string Email { get; }
    }
}