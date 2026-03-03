class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
         
        return $"Player{{Name : {Name}, Lvel : {Level}, Health : {Health}}}";
    }
}