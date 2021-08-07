using System;
using System.Threading;

namespace _01Disposable
{

    /// <summary>
    /// Saját maga után takarítani képes osztály készítése
    /// a beépített IDisposable felület segítségével
    /// 
    /// Mikor kell magunk után takarítani?
    /// -Külső függőség (file, hálózat) esetén, ha managelt objektumot használunk akkor a GC megoldja
    ///   - kivéve ha a nmanagelt kód IDisposable mintát használ, akkor kötelező implementálni
    ///  - nagy memóriaigényű alkalmazás
    ///  - direk mem kezelés
    /// </summary>
    public class ItSelfCleaner : IDisposable
    {

        //logikai érték lesz 0 fals ; 1 true; jelzi hogy lefutott e már a dispose
        private int isDisposed = 0;

        public ItSelfCleaner()
        {
        }

        public void Dispose()
        {
           Dispose(true);
            // kiveszi a finalizer queu-ból az osztálypáldányt
            GC.SuppressFinalize(this);
        }

        ~ItSelfCleaner()
        {
            Dispose(false);
        }

        private void Dispose(bool dispose)
        {
            // race condition elkerülése
            // egy logikai lépésben végrehajtja a következőket
            //1, elmenti az isdispose értékét
            //2, az isdispose értékét átállítja 1-re
            //3, visszatér a régi isdispose értékével
            if (Interlocked.Exchange(ref isDisposed, 1)==1 )
            {
                //return;
                //amennyiben kétszer futna le a finalizer
                throw new ObjectDisposedException(nameof(ItSelfCleaner));
            }
            

            //itt takaritunk
            if (dispose)
            {
                //ha disposból hítuk meg, a managelt részeket is takarítjuk

            }



            
        }
    }
}