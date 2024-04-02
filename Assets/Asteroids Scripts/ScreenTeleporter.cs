using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    new Collider2D collider2D;
    new Camera camera;

    void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new (camera.orthographicSize * camera.aspect, camera.orthographicSize);

        Rect cameraRect = new Rect(cameraCenter - cameraSize, cameraSize * 2);
        Bounds objectBounds = collider2D.bounds;

        // INNEN FOLYTATJUK

    }

    void OnDrawGizmos()
    {
        if (collider2D == null) return;

        Bounds bounds = collider2D.bounds;  // Befoglaló téglatest

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
