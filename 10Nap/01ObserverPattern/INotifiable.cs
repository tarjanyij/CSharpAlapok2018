namespace _01ObserverPattern
{
    /// <summary>
    /// Definiáljuk az Observer "tudását":
    /// rendelkeznie kell egy függvénnyel, ahol értesíteni lehet
    /// </summary>
    public interface INotifiable 
    {
        void Message(IMessage data);
    }

}