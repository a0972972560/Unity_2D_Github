using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScence(string scenename)
    {
        //�����޲z�� �� ���J��ĵ(�����W��)
        SceneManager.LoadScene(scenename);
    }
    public void QuitGame()
    {
        //���ε{�� �� ���}()
        Application.Quit();
    }

}
