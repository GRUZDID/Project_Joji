using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    void Update()
    {
       
        if (Input.GetMouseButton(1)) 
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float direction = Mathf.Sign(mousePosition.x - transform.position.x);
            transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);
        }
    }
}
