using System;
using System.Collections;
using System.Collections.Generic;

namespace _01IEnurableT
{
    public class BejarhatoAdatok<TAdat> : IEnumerable<TAdat>, IEnumerator<TAdat>
    {
                
        List<TAdat> adatok = new List<TAdat>();
        int position = -1;

        #region Adatok karbantartására szolgáló felület
        public void Add(TAdat adat)
        {
            adatok.Add(adat);
        }

        
        public bool Remove(TAdat adat)
        {
            return adatok.Remove(adat);
        }
        #endregion

        public IEnumerator<TAdat> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



        #region IEnumerator 
        public TAdat Current { get { return adatok[position]; } } 

        object IEnumerator.Current { get { return Current; } }
        public bool MoveNext()
        {
            position++;
            return position < adatok.Count;

        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            
        }
        #endregion IEnumerator
    }
}