using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTranstion : MonoBehaviour
{
    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }
}
