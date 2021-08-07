namespace Objektumok
{
   public class Plane
    {
        public Plane()
        {
        }
        //Állapot : mező(field) vagy tulajdonsáh(property)

        //nagyonhasonló a belső osztályszintű változó
        // csak az osztályon belül érhető el
        private int NumberOfNodes;

        //mező
        //tartalmazza az élek számát
        //kívülről elérhető, használata nem javasolt
        public int NumberOfEdge;

        //property ugyanaszt tudja mint a mező, ha alapértelmezetten használjuk
        //ez tartalamz egy backing field mezőt ami a visszatérési értéket tartalmazza
        //egy getter mezőt amivel beállitjuk az értékét
        //egy setter mezőt amivel az értékét lehet változtatni
        public int NumberOfArcs { get; set; }

               
        //csak olvasható
        public int Data1 { get; }

        //csak irható
        private int _data2;
        public int Data2 { set { _data2 = value} }

        //láthatóság
        //olvasni csak osztályon belül, írni osztályon kívül is lehet
        public int Data4 { private get; set; }

        //olvasni mindenhonnan, írni csak osztályon belül
        public int Data5 { get; private set; }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        //Viselkedés: függvényeken keresztöl függvényeken keresztül 

        public void Show()
        {

        }
        //nem a név hanem szignatúra számít; ami a függvény név és a paramétereit jelenti
        // lehet több ugyanazon nevű függvény 
        public void Show(bool disabled) { }
        
        public void Show(int x, int y) { }
        //a paraméternév nem a szignatúra része
        //a visszatérési érték sem a szignatúra része

        //a függvények paraméterei lehetnek:

        public void Show(int height)
        {
            System.Console.WriteLine($"height: {height}");
            height = height * 2;
            System.Console.WriteLine($"height: {height}");
        }

        




    }
}