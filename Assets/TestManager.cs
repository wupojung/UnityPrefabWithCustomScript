using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public MsgPanelHandler Panel;
    
	void Start () {
        
		Panel.gameObject.SetActive(true);
	    Panel.Title = "系統訊息";
	    Panel.Content = "aaa\nbbb\n";
	    Panel.YesText = "沒有問題";
	    Panel.NoText = "我才不要";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
