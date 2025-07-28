using UnityEngine;

public class InputManager : MonoBehaviour
{

    PlayerInput controls;
    PlayerInput.MovementActions groundmovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controls = new PlayerInput();
        groundmovement = controls.Movement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
