using UnityEngine;

public class InputManager : MonoBehaviour
{

    PlayerInput controls;
    PlayerInput.MovementActions groundmovement;

    [SerializeField] PlayerMovement movement;

    

    Vector2 horizontal_input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        controls = new PlayerInput();
        groundmovement = controls.Movement;
        groundmovement.Horizontal.performed += ctx => horizontal_input = ctx.ReadValue<Vector2>();
    }


    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        movement.recieveInput(horizontal_input);
    }

}
