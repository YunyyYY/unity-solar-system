using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    public Button mButton;
    public string sceneName;

    // Use this for initialization
    void Start () {
        //Gets ButtonMount
        Button btnMount = mButton.GetComponent<Button>();
        //add a listener to ButtonMount, executing TaskOnClick() when click ButtonMount
        btnMount.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Loading Scene1
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string sceneName;
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Click () {
        SceneManager.LoadScene(sceneName);
    }
}
*/
