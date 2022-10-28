using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStateManager : MonoBehaviour
{

    FireBaseState currentState;
    public FirePistolState pistolState = new FirePistolState();
    public FireMachineState machineState = new FireMachineState();
    public FireShotgunState shotgunState = new FireShotgunState();
    public FireRocketState rocketState = new FireRocketState();

    public Round round;

    // Start is called before the first frame update
    void Start()
    {
        currentState = pistolState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState( FireBaseState state )
    {
        currentState = state;
        state.EnterState(this);
    }

    public void ShootPistol()
    {
        round.ShootPistol();
    }

    public void ShootMachine()
    {
        round.ShootMachine();
    }

    public void ShootShotgun()
    {
        round.ShootShotgun();
    }

    public void ShootRocket()
    {
        round.ShootRocket();
    }
}
