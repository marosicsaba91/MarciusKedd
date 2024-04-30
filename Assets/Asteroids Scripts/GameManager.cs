using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] string gameSceneName;
    //[SerializeField] Texture2D pressedCursor;
    //[SerializeField] Texture2D idleCursor;

    public void RestartGame() 
    {
        SceneManager.LoadScene(gameSceneName);
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //        Cursor.SetCursor(pressedCursor, Vector2.zero, CursorMode.Auto);
    //    if (Input.GetMouseButtonUp(0))
    //        Cursor.SetCursor(idleCursor, Vector2.zero, CursorMode.Auto);
    //}

}
