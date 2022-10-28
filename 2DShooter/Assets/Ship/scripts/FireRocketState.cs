using UnityEngine;

public class FireRocketState : FireBaseState
{
    public override void EnterState( FireStateManager fire )
    {
        Debug.Log("Rocket");
    }
    
    public override void UpdateState( FireStateManager fire )
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire.ShootRocket();
        }
        else if( Input.GetKeyDown(KeyCode.Alpha1))
        {
            fire.SwitchState(fire.pistolState);
        }
        else if( Input.GetKeyDown(KeyCode.Alpha2))
        {
            fire.SwitchState(fire.machineState);
        }
        else if( Input.GetKeyDown(KeyCode.Alpha3))
        {
            fire.SwitchState(fire.shotgunState);
        }
    }

    public override void OnCollisionEnter2D( FireStateManager fire, Collision2D coll )
    {

    }

    public override void OnTriggerEnter2D( FireStateManager fire, Collider2D coll )
    {

    }
}
