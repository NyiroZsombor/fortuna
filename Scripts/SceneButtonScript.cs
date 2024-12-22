using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DynamicButton : MonoBehaviour {
    public Button button;
    public Text text ;
    public string newText;
    public string SceneName;

    void Start() {
        text = button.GetComponentInChildren<Text>();
        if (text != null) {
            text.text = newText;
        }
        else {
            Debug.LogError("could not find text");
        }

        if (button != null) {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    public void OnButtonClick() {  
        SceneManager.LoadScene(SceneName);
    }



}