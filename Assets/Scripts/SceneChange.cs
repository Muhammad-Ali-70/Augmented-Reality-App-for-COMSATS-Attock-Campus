using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_Scene_to()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Open_CS_Indoor()
    {
        SceneManager.LoadScene("CS_Indoor");
    }
    public void Open_EE_Indoor()
    {
        SceneManager.LoadScene("EE_Indoor");
    }
    public void Open_BBA_indoor()
    {
        SceneManager.LoadScene("BBA_Indoor");
    }

    public void Open_GeospatialScene()
    {
        SceneManager.LoadScene("Geospatial");
    }
}
