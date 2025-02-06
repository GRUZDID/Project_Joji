using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public LayerMask playerLayer; // Слой, на котором находится игрок
    public string sceneToLoad = "lvl2"; // Имя сцены, на которую нужно перейти

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, что объект, вошедший в триггер, находится на нужном слое
        if (((1 << collision.gameObject.layer) & playerLayer) != 0)
        {
            // Загружаем следующую сцену
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
