using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScence(string scenename)
    {
        //場景管理器 的 載入場警(場景名稱)
        SceneManager.LoadScene(scenename);
    }
    public void QuitGame()
    {
        //應用程式 的 離開()
        Application.Quit();
    }

}
