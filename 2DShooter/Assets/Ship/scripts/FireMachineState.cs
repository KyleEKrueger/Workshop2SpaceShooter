using UnityEngine;

public class FireMachineState : FireBaseState
{
    public override void EnterState( FireStateManager fire )
    {
        Debug.Log("Machine");
    }

    public override void UpdateState( FireStateManager fire)
    {
        if( Input.GetButton("Fire1"))
        {
            fire.ShootMachine();
        }
        else if( Input.GetKeyDown(KeyCode.Alpha1))
        {
            fire.SwitchState(fire.pistolState);
        }
        else if( Input.GetKeyDown(KeyCode.Alpha3))
        {
            fire.SwitchState(fire.shotgunState);
        }
        else if( Input.GetKeyDown(KeyCode.Alpha4))
        {
            fire.SwitchState(fire.rocketState);
        }
    }

    public override void OnCollisionEnter2D( FireStateManager fire, Collision2D coll )
    {

    }
    
    public override void OnTriggerEnter2D( FireStateManager fire, Collider2D coll )
    {

    }
}
