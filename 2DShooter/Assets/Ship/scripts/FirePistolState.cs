using UnityEngine;

public class FirePistolState : FireBaseState
{
    public override void EnterState( FireStateManager fire )
    {
        Debug.Log("Pistol");
    }

    public override void UpdateState( FireStateManager fire )
    {
        if( Input.GetButton("Fire1") )
        {
            fire.ShootPistol();
        }
        else if( Input.GetKeyDown(KeyCode.Alpha2))
        {
            fire.SwitchState(fire.machineState);
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
        if( coll.gameObject.tag == ("Shotgun"))
        {
            fire.SwitchState(fire.shotgunState);
        }
        else if( coll.gameObject.tag == ("Machine"))
        {
            fire.SwitchState(fire.machineState);
        }
        else if( coll.gameObject.tag == ("Rocket"))
        {
            fire.SwitchState(fire.rocketState);
        }
    }
}
