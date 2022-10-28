using UnityEngine; 

public abstract class FireBaseState 
{
    public abstract void EnterState( FireStateManager fire );

    public abstract void UpdateState( FireStateManager fire);

    public abstract void OnCollisionEnter2D( FireStateManager fire, Collision2D coll);

    public abstract void OnTriggerEnter2D( FireStateManager fire, Collider2D coll );
}