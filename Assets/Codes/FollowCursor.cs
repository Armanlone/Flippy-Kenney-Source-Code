using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    
    public float followSpeed = 10f;

    public Camera mainCamera = null;

    private void Update()
    {
        this.transform.position = CursorPosition;
    }

    public Vector2 CursorPosition => mainCamera.ScreenToWorldPoint(Input.mousePosition);

}