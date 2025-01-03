public abstract class Car
{
    private IBreakBehavior BreakBehavior;

    public Car(IBreakBehavior breakBehavior){
        BreakBehavior = breakBehavior;
    }

    public void ApplyHorn(){
        Console.WriteLine("Horn executed!");
    }

    public void ApplyBreak(){
        BreakBehavior.ApplyBreak();
    }
}