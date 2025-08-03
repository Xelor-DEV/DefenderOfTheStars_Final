using UnityEngine;

public class InfiniteScrollLeft : MonoBehaviour
{
    public float scrollSpeed = 1.0f;

    private float startPositionX;
    private float spriteWidth;

    void Start()
    {
        startPositionX = transform.position.x;
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        // Mover el fondo hacia la izquierda
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime, Space.World);

        float currentPositionX = transform.position.x;
        float distanceMoved = startPositionX - currentPositionX;

        if (distanceMoved >= spriteWidth)
        {
            float offset = distanceMoved % spriteWidth;
            transform.position = new Vector3(
                startPositionX - offset,
                transform.position.y,
                transform.position.z
            );
        }
    }
}