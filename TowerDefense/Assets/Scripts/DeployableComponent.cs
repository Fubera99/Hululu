public abstract class DeployableComponent : Components
{
    public int belongsTo;
    public int health;
    public int price;
    public string state;

    public abstract bool IsDestroyed();
}
