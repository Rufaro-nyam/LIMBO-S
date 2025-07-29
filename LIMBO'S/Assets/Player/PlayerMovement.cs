using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    Vector2 horizontalinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Horizontalvelocity = (transform.right * horizontalinput.x + transform.forward * horizontalinput.y) * speed;
        controller.Move(Horizontalvelocity * Time.deltaTime);
    }

    public void recieveInput(Vector2 _horizontalinput) 
    {
        horizontalinput = _horizontalinput;
        print(horizontalinput);
    }
}
