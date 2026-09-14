using UnityEngine;
using UnityEngine.InputSystem;

public class vectorMath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        DrawSquare(currentMousePosition, 5, Color.red, 0.5f);
    }

    public static float GetMag(Vector2 vector)
    {
        return Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y);
            
    }

    public static void DrawSquare(Vector2 centerPoint, float size, Color colour, float duration)
    {
        //top line
        Vector2 Srartpoint = centerPoint + new Vector2(-size,size);
        Vector2 endpoint = centerPoint + new Vector2(size,size);

        Debug.DrawLine(endpoint, Srartpoint, colour, duration);

        //left line
         Srartpoint = centerPoint + new Vector2(-size, size);
         endpoint = centerPoint + new Vector2(-size, -size);

        Debug.DrawLine(endpoint, Srartpoint, colour, duration);

        //right
         Srartpoint = centerPoint + new Vector2(size, size);
         endpoint = centerPoint + new Vector2(size, -size);

        Debug.DrawLine(endpoint, Srartpoint, colour, duration);

        //bottom
        Srartpoint = centerPoint + new Vector2(size, -size);
        endpoint = centerPoint + new Vector2(-size, -size);

        Debug.DrawLine(endpoint, Srartpoint, colour, duration);




    }

    public static Vector2 GetNormalizedVector (Vector2 vector)
    {

        float sizeOfVector = GetMag(vector);
        Vector2 normalizedvector = new Vector2(vector.x, vector.y) / sizeOfVector;

        return normalizedvector;
    }
}


